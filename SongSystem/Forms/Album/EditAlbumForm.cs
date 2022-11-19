using SongSystem.Infra.Extensions;
using SongSystem.Models.Services;
using SongSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongSystem.Forms.Album
{
	public partial class EditAlbumForm : Form
	{
		private int id;
		public EditAlbumForm(int id)
		{
			InitializeComponent();

			this.id = id;
		}

		private void DataDind(AlbumVM model)
		{
			txtAlbumName.Text = model.AlbumName;
			dtpReleased.Text = model.Released.ToString("yyyy/MM/dd");
		}

		private void EditAlbumForm_Load(object sender, EventArgs e)
		{
			var model = new AlbumService().Get(id);
			if (model == null)
			{
				MessageBox.Show("No Data Found!");
				this.DialogResult = DialogResult.OK;
				return;
			}

			DataDind(model);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string albumName = txtAlbumName.Text;
			DateTime released = dtpReleased.Value;

			AlbumVM model = new AlbumVM
			{
				Id = id,
				AlbumName = albumName,
				Released = released,
			};
			Dictionary<string, Control> map = new Dictionary<string, Control>
			{
				{ "AlbumName", txtAlbumName },
				{ "Released", dtpReleased },
			};
			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			new AlbumService().Update(model);
			this.DialogResult = DialogResult.OK;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}

			new AlbumService().Delete(id);
			this.DialogResult = DialogResult.OK;
		}
	}
}
