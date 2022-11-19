using SongSystem.Forms.Group;
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

namespace SongSystem.Forms.Singer
{
	public partial class EditSingerForm : Form
	{
		private int id;

		private SingerVM singer;

		public EditSingerForm(int id)
		{
			InitializeComponent();

			this.id = id;

			InitForm();
		}

		private void InitForm()
		{
			cmbGroupName.DropDownStyle = ComboBoxStyle.DropDown;
			cmbGroupName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cmbGroupName.AutoCompleteSource = AutoCompleteSource.ListItems;
			GroupIndexVM[] groups = new GroupService().GetAll()
					.Prepend(new GroupIndexVM { GroupName = "", Established = DateTime.Today })
					.ToArray();

			cmbGroupName.DataSource = groups;
			cmbGroupName.SelectedIndex = groups.Length - 1;
		}

		private void EditSingerForm_Load(object sender, EventArgs e)
		{
			singer = new SingerService().Get(id);
			if (singer == null)
			{
				MessageBox.Show("No Data Found!");
				this.DialogResult = DialogResult.OK;
				return;
			}

			DataBind();
		}

		private void DataBind()
		{
			txtSingerName.Text = singer.SingerName;
			if (singer.Gender == true)
				rdBtnMale.Select();
			else
				rdBtnFemale.Select();
			dtpDateOfBirth.Text = singer.DateOfBirth.ToString("yyyy/MM/dd");
			txtSingerCountry.Text = singer.Country;
			cmbGroupName.SelectedValue = singer.GroupId == null ? 0 : singer.GroupId;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string singerName = txtSingerName.Text;
			bool? gender = null;
			if (rdBtnMale.Checked)
			{
				gender = true;
			}
			else if (rdBtnFemale.Checked)
			{
				gender = false;
			}
			DateTime dateOfBirth = dtpDateOfBirth.Value;
			string country = txtSingerCountry.Text;
			int? groupId = Convert.ToInt32(cmbGroupName.SelectedValue);
			string groupName = cmbGroupName.Text;

			SingerVM model = new SingerVM
			{
				Id = id,
				SingerName = singerName,
				Gender = gender,
				DateOfBirth = dateOfBirth,
				Country = country,
				GroupId = groupId == 0 ? null : groupId,
				GroupName = groupName,
			};
			Dictionary<string, Control> map = new Dictionary<string, Control>
			{
				{ "SingerName", txtSingerName },
				{ "DateOfBirth", dtpDateOfBirth },
				{ "Gender", rdBtnFemale },
				{ "Country", txtSingerCountry },
				{ "GroupName", cmbGroupName },
			};
			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			try
			{
				new SingerService().Update(model);
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
				new SingerService().Delete(id);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Deletion failed! Because " + ex.Message);
			}
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			CreateGroupForm frm = new CreateGroupForm();
			frm.ShowDialog();

			InitForm();
		}
	}
}
