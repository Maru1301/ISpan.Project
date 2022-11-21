using SongSystem.Forms.Album;
using SongSystem.Forms.Genre;
using SongSystem.Forms.Group;
using SongSystem.Forms.Singer;
using SongSystem.Infra.Extensions;
using SongSystem.Models.Services;
using SongSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongSystem.Forms.Song
{
	public partial class EditSongForm : Form
	{
		private int songId;

		private int singerId;

		private SongValidationVM song;

		private Dictionary<int, string> singerList = new Dictionary<int, string>();

		private Length length = new Length();

		public EditSongForm(int songId, int singerId)
		{
			InitializeComponent();

			this.songId = songId;

			this.singerId = singerId;
		}

		private void EditSongForm_Load(object sender, EventArgs e)
		{
			song = new SongDetailService().Get(songId);
			if (song == null)
			{
				MessageBox.Show("No Data Found!");
				this.DialogResult = DialogResult.OK;
				return;
			}

			InitForm();

			DataBind();
		}

		private void InitForm()
		{
			ComboBox[] cmbs = new ComboBox[] { cmbSingerName, cmbGroupName, cmbGenreName, cmbAlbumName };
			SetComboBox(cmbs);

			BindSinger();

			BindGroup();

			BindGenre();

			BindAlbum();
			cmbSingerName.SelectedIndex = 0;
			cmbGroupName.SelectedIndex = 0;
			cmbGenreName.SelectedIndex = 0;
			cmbAlbumName.SelectedIndex = 0;
		}

		private void BindAlbum()
		{
			AlbumIndexVM[] albums = new AlbumService().GetAll()
									.Prepend(new AlbumIndexVM())
									.ToArray();

			cmbAlbumName.DataSource = albums;
			length.AlbumLength = albums.Length - 1;
		}

		private void BindGenre()
		{
			GenreIndexVM[] genres = new GenreService().GetAll()
									.Prepend(new GenreIndexVM())
									.ToArray();

			cmbGenreName.DataSource = genres;
			length.GenreLength = genres.Length - 1;
		}

		private void BindGroup()
		{
			GroupIndexVM[] groups = new GroupService().GetAll()
									.Prepend(new GroupIndexVM())
									.ToArray();

			cmbGroupName.DataSource = groups;
			length.GroupLength = groups.Length - 1;
		}

		private void BindSinger()
		{
			SingerIndexVM[] singers = new SingerService().GetAll()
										.Prepend(new SingerIndexVM())
										.ToArray();
			cmbSingerName.DataSource = singers;
			length.SingerLength = singers.Length - 1;
		}

		private void SetComboBox(ComboBox[] cmbs)
		{
			foreach (ComboBox cmb in cmbs)
			{
				cmb.DropDownStyle = ComboBoxStyle.DropDown;
				cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
				cmb.AutoCompleteSource = AutoCompleteSource.ListItems;
			}
		}

		private void DataBind()
		{
			txtSongName.Text = song.SongName;

			//todo manipulate the string
			string singerValue = song.SingerName;
			string[] singers = singerValue.Split(',');

			//get singerId
			foreach(string singer in singers)
			{
				txtSingerName.Text += singer + "\r\n";

				string processed = "%" + singer + "%";
				var singerArr = new SingerService().GetBySingerName(processed).ToArray();
				var VM = singerArr[0];
				int singerId = VM.Id;

				singerList.Add(singerId, singer);
			}

			cmbGroupName.Text = song.GroupName;
			string length = song.Length.ToString();
			txtMinute.Text = length.Substring(3, 2);
			txtSecond.Text = length.Substring(6, 2);
			cmbGenreName.Text = song.GenreName;
			cmbAlbumName.Text = song.AlbumName;
			txtLanguage.Text = song.Language;
			dtpReleased.Text = song.Released.ToString();
			txtLanguage.Text = song.Language;
			txtComposer.Text = song.Composer;
			txtArranger.Text = song.Arranger;
			txtProducer.Text = song.Producer;
			txtRecordCompany.Text = song.RecordCompany;
			txtLyricist.Text = song.Lyricist;
			txtLyric.Text= song.Lyric;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			ModelSet modelSet = SetModels();

			singerList.Clear();
			string singerValue = txtSingerName.Text;
			string[] singers = singerValue.Split('\r');
			foreach (string singer in singers)
			{
				string processed = singer;
				for (int i = 0; i < singer.Length; i++)
				{
					if (singer[i] == '\n')
					{
						processed = singer.Substring(1);
						break;
					}
				}
				if(string.IsNullOrEmpty(processed) == false)
				{
					var tempSingerName = processed;
					processed = "%" + processed + "%";
					var singerArr = new SingerService().GetBySingerName(processed).ToArray();
					var VM = singerArr[0];
					int singerId = VM.Id;

					singerList.Add(singerId, tempSingerName);
				}
			}

			string singerName = txtSingerName.Text;
			modelSet.ValiModel.SingerName = singerName;

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"SongName", txtSongName },
				{"SingerName", txtSingerName },
				{"Length", txtSecond },
				{"GenreName", cmbGenreName },
				{"Language", txtLanguage },
				{"Released", dtpReleased },
				{"GroupName", cmbGroupName },
				{"AlbumName", cmbAlbumName },
				{"Composer", txtComposer },
				{"Arranger", txtArranger },
				{"Lyricist", txtLyricist },
				{"Producer", txtProducer },
				{"RecordCompany", txtRecordCompany },
				{"Lyric", txtLyric },
			};
			if (ValidationHelper.Validate(modelSet.ValiModel, map, this.errorProvider1) == false) return;

			//update song
			try
			{
				new SongService().Update(modelSet.SongModel);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Update failed! Because " + ex.Message);
				return;
			}

			int songId = new SongService().Get(modelSet.SongModel.SongName).SongId;
			modelSet.DetailModel.SongId = songId;

			//update song detail
			try
			{
				new SongDetailService().Update(modelSet.DetailModel, singerList);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Update failed! Because " + ex.Message);
				return;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}

			new SongService().Delete(songId);
			new SongDetailService().Delete(songId, singerId);
			this.DialogResult = DialogResult.OK;
		}

		private ModelSet SetModels()
		{
			ModelSet modelSet = new ModelSet();

			string songName = txtSongName.Text;
			int singerId = Convert.ToInt32(cmbSingerName.SelectedValue);
			string singerName = cmbSingerName.Text;
			int? groupId = Convert.ToInt32(cmbGroupName.SelectedValue);
			string groupName = cmbGroupName.Text;
			TimeSpan length = ("0:" + txtMinute.Text + ":" + txtSecond.Text).ToTimeSpan(TimeSpan.Zero);
			int genreId = Convert.ToInt32(cmbGenreName.SelectedValue);
			string genreName = cmbGenreName.Text;
			int? albumId = Convert.ToInt32(cmbAlbumName.SelectedValue);
			string albumName = cmbAlbumName.Text;
			DateTime released = dtpReleased.Value;
			string language = txtLanguage.Text;
			string composer = txtComposer.Text;
			string arranger = txtArranger.Text;
			string producer = txtProducer.Text;
			string recordCompany = txtRecordCompany.Text;
			string lyricist = txtLyricist.Text;
			string lyric = txtLyric.Text;

			modelSet.ValiModel = new SongValidationVM
			{
				SongName = songName,
				//SingerName = singerName,
				GroupName = groupName,
				Length = length,
				GenreName = genreName,
				AlbumName = albumName,
				Released = released,
				Language = language,
				Composer = composer,
				Arranger = arranger,
				Lyricist = lyricist,
				Producer = producer,
				RecordCompany = recordCompany,
				Lyric = lyric,
			};


			modelSet.SongModel = new SongVM
			{
				SongId= songId,
				SongName = songName,
				Length = length,
				GenreId = genreId,
				GenreName = genreName,
				Language = language,
				Released = released,
			};

			modelSet.DetailModel = new SongDetailVM
			{
				SongId = songId,
				SongName = songName,
				SingerId = singerId,
				//SingerName = singerName,
				GroupId = groupId == 0 ? null : groupId,
				GroupName = groupName,
				AlbumId = albumId == 0 ? null : albumId,
				AlbumName = albumName,
				Composer = composer,
				Arranger = arranger,
				Lyricist = lyricist,
				Producer = producer,
				RecordCompany = recordCompany,
				Lyric = lyric,
			};

			return modelSet;
		}

		private void btnEnterSinger_Click(object sender, EventArgs e)
		{
			EnterSingerList();
			cmbSingerName.Text = string.Empty;
		}

		private void EnterSingerList()
		{
			int singerId = Convert.ToInt32(cmbSingerName.SelectedValue);
			string singerName = cmbSingerName.Text;

			if (singerList.ContainsValue(singerName))
			{
				MessageBox.Show("Singer has been in the list!");
				return;
			}

			singerList.Add(singerId, singerName);
			txtSingerName.AppendText(singerName + "\r\n");
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			singerList.Clear();
			txtSingerName.Text = string.Empty;
		}

		private void btnAddSinger_Click(object sender, EventArgs e)
		{
			CreateSingerForm frm = new CreateSingerForm();
			frm.ShowDialog();

			BindSinger();
			cmbSingerName.SelectedIndex= length.SingerLength;
		}

		private void btnAddGroup_Click(object sender, EventArgs e)
		{
			CreateGroupForm frm = new CreateGroupForm();
			frm.ShowDialog();

			BindGroup();
			cmbGroupName.SelectedIndex= length.GroupLength;
		}

		private void btnAddGenre_Click(object sender, EventArgs e)
		{
			CreateGenreForm frm = new CreateGenreForm();
			frm.ShowDialog();

			BindGenre();
			cmbGenreName.SelectedIndex= length.GenreLength;
		}

		private void btnAddAlbum_Click(object sender, EventArgs e)
		{
			CreateAlbumForm frm = new CreateAlbumForm();
			frm.ShowDialog();

			BindAlbum();
			cmbAlbumName.SelectedIndex= length.AlbumLength;
		}
	}
}
