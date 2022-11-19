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
	public partial class CreateGroupForm : Form
	{
		public CreateGroupForm()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string groupName = txtGroupName.Text;
			DateTime established = dtpEstablished.Value;

			GroupVM model = new GroupVM()
			{
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
				new GroupService().Create(model);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Creation failed! Because " + ex.Message);
			}
		}
	}
}
