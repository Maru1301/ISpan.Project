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

			this.txtPassword.KeyPress += new KeyPressEventHandler(CheckEnter);
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Login();
		}

		private void CheckEnter(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar.Equals((char)Keys.Enter))
			{
				// Enter key pressed
				Login();
			}
		}

		private void Login()
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
