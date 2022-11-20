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
	public partial class SongsForm : Form
	{
		private SongIndexVM[] songs;

		private DateTimePicker pickerStart = new DateTimePicker();

		private DateTimePicker pickerEnd = new DateTimePicker();

		private Label tilde = new Label();

		private DateTimePicker releasedDate = new DateTimePicker();

		public SongsForm()
		{
			InitializeComponent();

			InitForm();

			DisplaySongs();
		}

		private void InitForm()
		{
			cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbSearch.DropDownStyle = ComboBoxStyle.DropDown;
			cmbSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cmbSearch.AutoCompleteSource = AutoCompleteSource.ListItems;

			//DateTimePicker
			pickerStart.Font= cmbSearch.Font;
			pickerStart.Format = DateTimePickerFormat.Custom;
			pickerStart.CustomFormat = "mm:ss";
			pickerStart.ShowUpDown= true;
			pickerStart.Size = new Size(cmbSearch.Width / 2 + 10, cmbSearch.Height);
			pickerStart.Location = new Point(cmbSearch.Location.X, cmbSearch.Location.Y);
			pickerStart.Value = new DateTime(2000,1,1);
			pickerStart.Hide();
			this.Controls.Add(pickerStart);

			//tilde
			tilde.Font= cmbSearch.Font;
			tilde.Location= new Point(cmbSearch.Location.X + 95, cmbSearch.Location.Y);
			tilde.Text = "~";
			tilde.Size = new Size(30, 20);
			this.Controls.Add(tilde);

			//PickerEnd
			pickerEnd.Font = cmbSearch.Font;
			pickerEnd.Format = DateTimePickerFormat.Custom;
			pickerEnd.CustomFormat = "mm:ss";
			pickerEnd.ShowUpDown = true;
			pickerEnd.Size = new Size(cmbSearch.Width / 2 + 10, cmbSearch.Height);
			pickerEnd.Location = new Point(cmbSearch.Location.X + 125, cmbSearch.Location.Y);
			pickerEnd.Value = new DateTime(2000, 1, 1);
			pickerEnd.Hide();
			this.Controls.Add(pickerEnd);

			//releasedDate
			releasedDate.Font = cmbSearch.Font;
			releasedDate.Format = DateTimePickerFormat.Custom;
			releasedDate.CustomFormat = "yyyy/MM/dd";
			releasedDate.Size = cmbSearch.Size;
			releasedDate.Location = cmbSearch.Location;
			releasedDate.Value = DateTime.Today;
			releasedDate.Hide();
			this.Controls.Add(releasedDate);
		}

		private void DisplaySongs()
		{
			if(cmbCategory.Text == "Length")
			{
				TimeSpan tsStart = pickerStart.Value.Subtract(new DateTime(2000, 1, 1));
				TimeSpan tsEnd = pickerEnd.Value.Subtract(new DateTime(2000, 1, 1));
				try
				{
					songs = new SongDetailService().GetByLength(tsStart, tsEnd).ToArray();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Search failed! Because " + ex.Message);
				}
			}
			else if(cmbCategory.Text == "Released")
			{
				DateTime dt = releasedDate.Value;
				songs = new SongDetailService().GetByReleased(dt).ToArray();
			}
			else
			{
				string value = cmbSearch.Text;
				if (value.Length == 0 || cmbCategory.Text == "")
				{
					songs = new SongDetailService().GetAll().ToArray();
					DataBind(songs);
					return;
				}
				else
				{
					value = "%" + value + "%";
				}
				if(cmbCategory.Text == "Singer")
				{
					songs = new SongDetailService().GetBySinger(value).ToArray();
				}
				else if (cmbCategory.Text == "Group")
				{
					songs = new SongDetailService().GetByGroup(value).ToArray();
				}
				else if (cmbCategory.Text == "Song Genre")
				{
					songs = new SongDetailService().GetByGenre(value).ToArray();
				}
				else if (cmbCategory.Text == "Album")
				{
					songs = new SongDetailService().GetByAlbum(value).ToArray();
				}
				else if (cmbCategory.Text == "Langauge")
				{
					songs = new SongDetailService().GetByLangauge(value).ToArray();
				}
				else if (cmbCategory.Text == "Record Company")
				{
					songs = new SongDetailService().GetByRecordCompany(value).ToArray();
				}
			}

			DataBind(songs);
		}

		private void DataBind(SongIndexVM[] model)
		{
			dataGridView1.DataSource = model;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			CreateSongForm frm = new CreateSongForm();
			if (frm.ShowDialog() == DialogResult.OK)
				DisplaySongs();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex < 0) return;

			SongIndexVM model = this.songs[rowIndex];
			int songId = model.SongId;
			int singerId = model.SingerId;

			EditSongForm frm = new EditSongForm(songId, singerId);
			if (frm.ShowDialog() == DialogResult.OK)
				DisplaySongs();
		}

		private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbCategory.Text == "Singer")
			{
				var singers = new SingerService().GetAll().Prepend(new SingerIndexVM { }).ToArray();
				cmbSearch.DataSource = singers;
				cmbSearch.DisplayMember = "SingerName";
				cmbSearch.ValueMember = "Id";
				cmbSearch.Show();
				HideLengthPicker();
				btnSearch.Location = new Point(483, btnSearch.Location.Y);
			}
			else if(cmbCategory.Text == "Group")
			{
				var groups = new GroupService().GetAll().Prepend(new GroupIndexVM { }).ToArray();
				cmbSearch.DataSource = groups;
				cmbSearch.DisplayMember = "GroupName";
				cmbSearch.ValueMember = "Id";
				cmbSearch.Show();
				HideLengthPicker();
				releasedDate.Hide();
				btnSearch.Location = new Point(483, btnSearch.Location.Y);
			}
			else if (cmbCategory.Text == "Length")
			{
				cmbSearch.Hide();
				ShowLengthPicker();
				releasedDate.Hide();
				btnSearch.Location = new Point(523, btnSearch.Location.Y);
			}
			else if (cmbCategory.Text == "Song Genre")
			{
				var genres = new GenreService().GetAll().Prepend(new GenreIndexVM { }).ToArray();
				cmbSearch.DataSource = genres;
				cmbSearch.DisplayMember = "GenreName";
				cmbSearch.ValueMember = "Id";
				cmbSearch.Show();
				HideLengthPicker();
				releasedDate.Hide();
				btnSearch.Location = new Point(483, btnSearch.Location.Y);
			}
			else if (cmbCategory.Text == "Album")
			{
				var albums = new AlbumService().GetAll().Prepend(new AlbumIndexVM { }).ToArray();
				cmbSearch.DataSource = albums;
				cmbSearch.DisplayMember = "AlbumName";
				cmbSearch.ValueMember = "Id";
				cmbSearch.Show();
				HideLengthPicker();
				releasedDate.Hide();
				btnSearch.Location = new Point(483, btnSearch.Location.Y);
			}
			else if (cmbCategory.Text == "Released")
			{
				cmbSearch.Hide();
				HideLengthPicker();
				releasedDate.Show();
				btnSearch.Location = new Point(483, btnSearch.Location.Y);
			}
			else if (cmbCategory.Text == "Langauge")
			{
				cmbSearch.Show();
				cmbSearch.DataSource = null;
				HideLengthPicker();
				releasedDate.Hide();
				btnSearch.Location = new Point(483, btnSearch.Location.Y);
			}
			else if (cmbCategory.Text == "Record Company")
			{
				cmbSearch.Show();
				cmbSearch.DataSource = null;
				HideLengthPicker();
				releasedDate.Hide();
				btnSearch.Location = new Point(483, btnSearch.Location.Y);
			}
		}

		private void ShowLengthPicker()
		{
			pickerStart.Show();
			tilde.Show();
			pickerEnd.Show();
		}

		private void HideLengthPicker()
		{
			pickerStart.Hide();
			tilde.Hide();
			pickerEnd.Hide();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			DisplaySongs();
		}
	}
}
