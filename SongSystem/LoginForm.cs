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

namespace SongSystem
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			LoginVM model = new LoginVM()
			{
				Account = txtAccount.Text,
				Password = txtPassword.Text,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", txtAccount },
				{"Password", txtPassword },
			};
			if (ValidationHelper.Validate(model, map, this.errorProvider1) == false) return;

			bool result = new UserService().Authenticate(model);
			if (result == false)
			{
				MessageBox.Show("Account or Password is wrong");
				return;
			}

			txtAccount.Text = string.Empty;
			txtPassword.Text = string.Empty;

			MainForm frm = new MainForm(model.Account);
			frm.Show();
			frm.Owner = this;
			this.Hide();
		}
	}
}
