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

namespace SongSystem.Forms.Album
{
	public partial class CreateAlbumForm : Form
	{
		public CreateAlbumForm()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string albumName = txtAlbumName.Text;
			DateTime released = dtpReleased.Value;

			AlbumVM model = new AlbumVM()
			{
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

			try
			{
				new AlbumService().Create(model);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Creation failed! Because " + ex.Message);
			}
		}
	}
}
