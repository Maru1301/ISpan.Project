using SongSystem.Infra.DAOs;
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

namespace SongSystem.Forms.User
{
	public partial class UsersForm : Form
	{
		private UserIndexVM[] users;

		public UsersForm()
		{
			InitializeComponent();

			DisplayProducts();
		}

		private void DisplayProducts()
		{
			users = new UserDAO().GetAll().ToArray();

			BindData(users);
		}

		private void BindData(UserIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var frm = new CreateUserForm();

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayProducts();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;

			if (rowIndex < 0) return;

			UserIndexVM row = this.users[rowIndex];
			int id = row.Id;

			//if(CheckExistence(id) == false) return;

			var frm = new EditUserForm(id);
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayProducts();
			}
		}
	}
}
