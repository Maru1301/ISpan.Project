using SongSystem.Forms.Album;
using SongSystem.Forms.Genre;
using SongSystem.Forms.Group;
using SongSystem.Forms.Singer;
using SongSystem.Forms.Song;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongSystem
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void maintainSongsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SongsForm frm = new SongsForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void maintainSingersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SingersForm frm = new SingersForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void maintainSongGenresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			GenresForm frm = new GenresForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void maintainAlbumsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AlbumsForm frm = new AlbumsForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void maintainGroupsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			GroupsForm frm = new GroupsForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
