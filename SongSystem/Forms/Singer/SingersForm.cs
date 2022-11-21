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
	public partial class SingersForm : Form
	{
		private SingerIndexVM[] singers;

		public SingersForm()
		{
			InitializeComponent();

			DisplaySingers();

			dtpSearchValue.Hide();
			cbxCategory.SelectedIndex = 0;

			this.timer1.Interval = 2000;
			this.timer1.Enabled = true;
		}

		private void DisplaySingers()
		{
			if (cbxCategory.SelectedIndex == 1)
			{
				DateTime dt = dtpSearchValue.Value;
				singers = new SingerService().GetByDateOfBirth(dt).ToArray();
				DataBind();
				return;
			}
			string value = txtSearchValue.Text;
			if(value.Length == 0)
			{
				singers = new SingerService().GetAll().ToArray();
				DataBind();
				return;
			}
			else
			{
				value = "%" + value + "%";
				if (cbxCategory.SelectedIndex == 0)
				{
					singers = new SingerService().GetBySingerName(value).ToArray();
				}
				else if (cbxCategory.SelectedIndex == 2)
				{
					singers = new SingerService().GetByCountry(value).ToArray();
				}
				else if (cbxCategory.SelectedIndex == 3)
				{
					singers = new SingerService().GetByGroupName(value).ToArray();
				}
			}

			DataBind();
		}

		private void DataBind()
		{
			dataGridView1.DataSource = singers;
		}

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			CreateSingerForm frm = new CreateSingerForm();
			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplaySingers();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;

			if (rowIndex < 0)
			{
				return;
			}

			SingerIndexVM row = this.singers[rowIndex];
			int id = row.Id;

			EditSingerForm frm = new EditSingerForm(id);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplaySingers();
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			DisplaySingers();
		}

		private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbxCategory.SelectedIndex == 1) 
			{
				txtSearchValue.Hide();
				dtpSearchValue.Show();
			}
			else
			{
				dtpSearchValue.Hide();
				txtSearchValue.Show();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			DisplaySingers();
		}
	}
}
