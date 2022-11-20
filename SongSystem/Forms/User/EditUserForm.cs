using SongSystem.Infra.DAOs;
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
	public partial class EditUserForm : Form
	{
		private int id;
		public EditUserForm(int id)
		{
			InitializeComponent();

			this.id = id;

			BindData(id);
		}

		private void BindData(int id)
		{
			UserDTO dto = new UserDAO().GetOneRow(id);

			UserVM model = ToUserVM(dto);

			txtAccount.Text = model.Account;
			txtPassword.Text = model.Password;
			txtName.Text = model.Name;
			txtPermissions.Text = model.Permissions.ToString();
		}

		private UserVM ToUserVM(UserDTO dto)
		{
			return new UserVM
			{
				Id = dto.Id,
				Account = dto.Account,
				Password = dto.Password,
				Name = dto.Name,
				Permissions = dto.Permissions,
			};
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}

			new UserService().Delete(id);

			this.DialogResult = DialogResult.OK;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string account = txtAccount.Text;
			string password = txtPassword.Text;
			string name = txtName.Text;
			int permissions = Convert.ToInt32(txtPermissions.Text);

			UserVM model = new UserVM
			{
				Id = id,
				Account = account,
				Password = password,
				Name = name,
				Permissions = permissions
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", txtAccount },
				{"Password", txtPassword },
				{"Name", txtName},
				{"Permissions", txtPermissions },
			};
			if (ValidationHelper.Validate(model, map, this.errorProvider1) == false) return;

			UserDTO dto = model.ToUserDTO();

			try
			{
				new UserService().Update(dto);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Update Failed! Because " + ex.Message);
			}
		}
	}
}
