using SongSystem.Infra.Extensions;
using SongSystem.Models.DTOs;
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

namespace SongSystem.Forms.User
{
	public partial class CreateUserForm : Form
	{
		public CreateUserForm()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string account = txtAccount.Text;
			string password = txtPassword.Text;
			string name = txtName.Text;
			int permissions = txtPermissions.Text.ToInt(0);

			UserVM model = new UserVM
			{
				Account = account,
				Password = password,
				Name = name,
				Permissions = permissions
			};

			//欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", txtAccount },
				{"Password", txtPassword },
				{"Name", txtName},
				{"Permissions", txtPermissions },
			};
			if (ValidationHelper.Validate(model, map, this.errorProvider1) == false) return;

			//If input passes the validation, create a new record
			UserDTO dto = model.ToUserDTO();

			try
			{
				new UserService().Create(dto);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Creation Failed, because " + ex.Message);
			}
		}
	}
}
