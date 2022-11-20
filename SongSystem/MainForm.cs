using SongSystem.Forms.Album;
using SongSystem.Forms.Genre;
using SongSystem.Forms.Group;
using SongSystem.Forms.Singer;
using SongSystem.Forms.Song;
using SongSystem.Forms.User;
using SongSystem.Infra.DAOs;
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

namespace SongSystem
{
	public partial class MainForm : Form
	{
		UserVM user;
		public MainForm(string account)
		{
			InitializeComponent();

			user = new UserService().Get(account);

			if(user.Permissions < 3)
			{
				maintainUsersToolStripMenu.Visible = false;
			}
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

		private void maintainUsersToolStripMenu_Click(object sender, EventArgs e)
		{
			UsersForm frm = new UsersForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to leave?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}
	}
}
