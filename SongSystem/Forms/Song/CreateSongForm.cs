using SongSystem.Infra.Extensions;
using SongSystem.Models.Services;
using SongSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongSystem.Forms.Song
{
	public partial class CreateSongForm : Form
	{
		public CreateSongForm()
		{
			InitializeComponent();

			InitForm();
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

		private void btnSave_Click(object sender, EventArgs e)
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
			string lyricist = txtLyricist.Text;
			string producer = txtProducer.Text;
			string recordCompany = txtRecordCompany.Text;
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
				Lyric= lyric,
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
				new SongService().Create(songModel);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Creation failed! Because " + ex.Message);
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
				new SongDetailService().Create(detailModel);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Creation failed! Because " + ex.Message);
			}
		}
	}
}
