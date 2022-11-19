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

namespace SongSystem.Forms.Group
{
	public partial class GroupsForm : Form
	{
		private GroupIndexVM[] groups;

		public GroupsForm()
		{
			InitializeComponent();

			DisplayGroups();
		}

		private void DisplayGroups()
		{
			string groupName = txtGroupName.Text;
			if(groupName.Length == 0)
			{
				groups = new GroupService().GetAll().ToArray();
			}
			else
			{
				groupName = "%" + groupName + "%";
				groups = new GroupService().Get(groupName).ToArray();
			}

			DataBind();
		}

		private void DataBind()
		{
			dataGridView1.DataSource = groups;
		}

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			CreateGroupForm frm = new CreateGroupForm();
			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayGroups();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;

			if (rowIndex < 0)
			{
				return;
			}

			GroupIndexVM row = this.groups[rowIndex];
			int id = row.Id;

			EditGroupForm frm = new EditGroupForm(id);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayGroups();
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			DisplayGroups();
		}
	}
}
