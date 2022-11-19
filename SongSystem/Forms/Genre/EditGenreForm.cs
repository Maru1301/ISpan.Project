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
	public partial class EditGenreForm : Form
	{
		private int id;
		public EditGenreForm(int id)
		{
			InitializeComponent();

			this.id = id;
		}

		private void EditGenreForm_Load(object sender, EventArgs e)
		{
			var model = new GenreService().Get(id);

			if (model == null)
			{
				MessageBox.Show("No Data Found!");
				this.DialogResult = DialogResult.OK;
				return;
			}

			DataBind(model);
		}

		private void DataBind(GenreVM model)
		{
			txtGenreName.Text = model.GenreName;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string genreName = txtGenreName.Text;

			GenreVM model = new GenreVM
			{
				Id = id,
				GenreName = genreName,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>
			{
				{ "GenreName", txtGenreName },
			};
			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (isValid == false) return;

			try
			{
				new GenreService().Update(model);

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

			new GenreService().Delete(id);

			this.DialogResult = DialogResult.OK;
		}
	}
}
