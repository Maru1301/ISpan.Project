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

namespace SongSystem.Forms.Group
{
	public partial class EditGroupForm : Form
	{
		private int id;

		public EditGroupForm(int id)
		{
			InitializeComponent();

			this.id = id;
		}

		private void EditGroupForm_Load(object sender, EventArgs e)
		{
			var model = new GroupService().Get(id);
			if (model == null)
			{
				MessageBox.Show("No Data Found!");
				this.DialogResult = DialogResult.OK;
				return;
			}

			DataDind(model);
		}

		private void DataDind(GroupVM model)
		{
			txtGroupName.Text = model.GroupName;
			dtpEstablished.Text = model.Established.ToString("yyyy/MM/dd");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string groupName = txtGroupName.Text;
			DateTime established = dtpEstablished.Value;

			GroupVM model = new GroupVM
			{
				Id = id,
				GroupName = groupName,
				Established = established,
			};
			Dictionary<string, Control> map = new Dictionary<string, Control>
			{
				{ "GroupName", txtGroupName },
				{ "Established", dtpEstablished },
			};
			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			try
			{
				new GroupService().Update(model);
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

			try
			{
				new GroupService().Delete(id);
				this.DialogResult = DialogResult.OK;
			}
			catch(Exception ex)
			{
				MessageBox.Show("Deletion failed! Because " + ex.Message);
			}
		}
	}
}
