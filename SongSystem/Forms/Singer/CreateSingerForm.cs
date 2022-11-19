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
	public partial class CreateSingerForm : Form
	{
		public CreateSingerForm()
		{
			InitializeComponent();

			InitForm();
			cmbGroupName.SelectedIndex = 0;
		}

		private void InitForm()
		{
			cmbGroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
			cmbGroupName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cmbGroupName.AutoCompleteSource = AutoCompleteSource.ListItems;
			GroupIndexVM[] groups = new GroupService().GetAll()
					.Prepend(new GroupIndexVM())
					.ToArray();

			cmbGroupName.DataSource = groups;
			cmbGroupName.SelectedIndex = groups.Length - 1;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string singerName = txtSingerName.Text;
			DateTime dateOfBirth = dtpDateOfBirth.Value;
			bool? gender = null;
			if(rdBtnMale.Checked)
			{
				gender = true;
			}
			if (rdBtnFemale.Checked)
			{
				gender = false;
			}
			string country = txtSingerCountry.Text;
			int? groupId = Convert.ToInt32(cmbGroupName.SelectedValue);
			string groupName = cmbGroupName.Text;

			SingerVM model = new SingerVM()
			{
				SingerName = singerName,
				DateOfBirth = dateOfBirth,
				Gender = gender,
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

			new SingerService().Create(model);

			this.DialogResult = DialogResult.OK;
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			CreateGroupForm frm = new CreateGroupForm();
			frm.ShowDialog();

			InitForm();
		}
	}
}
