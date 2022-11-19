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

namespace SongSystem.Forms.Genre
{
	public partial class CreateGenreForm : Form
	{
		public CreateGenreForm()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string genreName = txtGenreName.Text;

			GenreVM model = new GenreVM
			{
				GenreName = genreName,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>
			{
				{ "GenreName", txtGenreName},
			};
			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (isValid == false) return;

			try
			{
				new GenreService().Create(model);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Creation failed! Because " + ex.Message);
			}
		}
	}
}
