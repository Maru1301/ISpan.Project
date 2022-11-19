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

namespace SongSystem.Forms.Album
{
	public partial class AlbumsForm : Form
	{
		private AlbumIndexVM[] albums;

		public AlbumsForm()
		{
			InitializeComponent();

			DisplayAlbums();
		}

		private void DisplayAlbums()
		{
			string albumName = txtAlbumName.Text;
			if (albumName.Length == 0)
			{
				albums = new AlbumService().GetAll().ToArray();
			}
			else
			{
				albumName = "%" + albumName + "%";
				albums = new AlbumService().Get(albumName).ToArray();
			}

			DataBind();
		}

		private void DataBind()
		{
			dataGridView1.DataSource = albums;
		}

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			CreateAlbumForm frm = new CreateAlbumForm();
			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayAlbums();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;

			if (rowIndex < 0)
			{
				return;
			}

			AlbumIndexVM model = this.albums[rowIndex];
			int id = model.Id;

			EditAlbumForm frm = new EditAlbumForm(id);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayAlbums();
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			DisplayAlbums();
		}
	}
}
