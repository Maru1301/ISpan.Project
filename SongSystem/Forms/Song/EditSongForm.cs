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
		public EditSongForm(int songId, int singerId)
		{
			InitializeComponent();

			this.songId = songId;

			this.singerId = singerId;

			InitForm();
		}

		private void EditSongForm_Load(object sender, EventArgs e)
		{
			song = new SongDetailService().Get(songId, singerId);
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

			SingerIndexVM[] singers = new SingerService().GetAll()
										.Prepend(new SingerIndexVM())
										.ToArray();
			cmbSingerName.DataSource = singers;
			cmbSingerName.Text = string.Empty;

			GroupIndexVM[] groups = new GroupService().GetAll()
									.Prepend(new GroupIndexVM())
									.ToArray();

			cmbGroupName.DataSource = groups;
			cmbGroupName.Text = string.Empty;

			GenreIndexVM[] genres = new GenreService().GetAll()
									.Prepend(new GenreIndexVM())
									.ToArray();

			cmbGenreName.DataSource = genres;
			cmbGenreName.Text = string.Empty;

			AlbumIndexVM[] albums = new AlbumService().GetAll()
									.Prepend(new AlbumIndexVM())
									.ToArray();

			cmbAlbumName.DataSource = albums;
			cmbAlbumName.Text = string.Empty;
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
			cmbSingerName.Text = song.SingerName;
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

			SongValidationVM model = new SongValidationVM
			{
				SongName = songName,
				SingerName = singerName,
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

			SongVM songModel = new SongVM
			{
				SongName = songName,
				Length = length,
				GenreId = genreId,
				GenreName = genreName,
				Language = language,
				Released = released,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"SongName", txtSongName },
				{"SingerName", cmbSingerName },
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
			if (ValidationHelper.Validate(model, map, this.errorProvider1) == false) return;

			try
			{
				new SongService().Update(songModel);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Update failed! Because " + ex.Message);
			}

			int songId = new SongService().Get(songName).SongId;

			SongDetailVM detailModel = new SongDetailVM
			{
				SongId = songId,
				SongName = songName,
				SingerId = singerId,
				SingerName = singerName,
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

			try
			{
				new SongDetailService().Update(detailModel);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Update failed! Because " + ex.Message);
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
	}
}
