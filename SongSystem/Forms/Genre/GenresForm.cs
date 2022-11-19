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

namespace SongSystem.Forms.Genre
{
	public partial class GenresForm : Form
	{
		private GenreIndexVM[] Genres;

		public GenresForm()
		{
			InitializeComponent();

			DisplaySongGenres();
		}

		private void DisplaySongGenres()
		{
			string genreName = txtGenreName.Text;
			if(genreName.Length == 0 )
			{
				Genres = new GenreService().GetAll().ToArray();
			}
			else
			{
				genreName = "%" + genreName + "%";
				Genres = new GenreService().Get(genreName).ToArray();
			}

			BindData();
		}

		private void BindData()
		{
			dataGridView1.DataSource = Genres;
		}

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			CreateGenreForm frm = new CreateGenreForm();
			if (frm.ShowDialog() == DialogResult.OK)
				DisplaySongGenres();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;

			if (rowIndex < 0)
			{
				return;
			}

			GenreIndexVM row = this.Genres[rowIndex];
			int id = row.Id;

			var frm = new EditGenreForm(id);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplaySongGenres();
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			DisplaySongGenres();
		}

		private void txtGenreName_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
