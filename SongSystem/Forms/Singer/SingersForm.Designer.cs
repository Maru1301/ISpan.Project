namespace SongSystem.Forms.Singer
{
	partial class SingersForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearchValue = new System.Windows.Forms.TextBox();
			this.cbxCategory = new System.Windows.Forms.ComboBox();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.singerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.singerIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dtpSearchValue = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.singerIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.singerNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.groupNameDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.singerIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(27, 71);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(809, 258);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// btnAddNew
			// 
			this.btnAddNew.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNew.Location = new System.Drawing.Point(747, 19);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(89, 34);
			this.btnAddNew.TabIndex = 2;
			this.btnAddNew.Text = "Add";
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(398, 20);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(93, 33);
			this.btnSearch.TabIndex = 13;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearchValue
			// 
			this.txtSearchValue.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchValue.Location = new System.Drawing.Point(203, 20);
			this.txtSearchValue.Name = "txtSearchValue";
			this.txtSearchValue.Size = new System.Drawing.Size(189, 32);
			this.txtSearchValue.TabIndex = 12;
			// 
			// cbxCategory
			// 
			this.cbxCategory.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCategory.FormattingEnabled = true;
			this.cbxCategory.Items.AddRange(new object[] {
            "Singer name",
            "Date of birth",
            "Country",
            "Group name"});
			this.cbxCategory.Location = new System.Drawing.Point(27, 21);
			this.cbxCategory.Name = "cbxCategory";
			this.cbxCategory.Size = new System.Drawing.Size(158, 34);
			this.cbxCategory.TabIndex = 14;
			this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 125;
			// 
			// singerNameDataGridViewTextBoxColumn
			// 
			this.singerNameDataGridViewTextBoxColumn.DataPropertyName = "SingerName";
			this.singerNameDataGridViewTextBoxColumn.HeaderText = "Singer Name";
			this.singerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.singerNameDataGridViewTextBoxColumn.Name = "singerNameDataGridViewTextBoxColumn";
			this.singerNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.singerNameDataGridViewTextBoxColumn.Width = 125;
			// 
			// dateOfBirthDataGridViewTextBoxColumn
			// 
			this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
			this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
			this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
			this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
			this.dateOfBirthDataGridViewTextBoxColumn.Width = 125;
			// 
			// genderDataGridViewTextBoxColumn
			// 
			this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
			this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
			this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
			this.genderDataGridViewTextBoxColumn.ReadOnly = true;
			this.genderDataGridViewTextBoxColumn.Width = 125;
			// 
			// countryDataGridViewTextBoxColumn
			// 
			this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
			this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
			this.countryDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
			this.countryDataGridViewTextBoxColumn.ReadOnly = true;
			this.countryDataGridViewTextBoxColumn.Width = 125;
			// 
			// groupNameDataGridViewTextBoxColumn
			// 
			this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
			this.groupNameDataGridViewTextBoxColumn.HeaderText = "Group Name";
			this.groupNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
			this.groupNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.groupNameDataGridViewTextBoxColumn.Width = 125;
			// 
			// singerIndexVMBindingSource
			// 
			this.singerIndexVMBindingSource.DataSource = typeof(SongSystem.Models.ViewModels.SingerIndexVM);
			// 
			// dtpSearchValue
			// 
			this.dtpSearchValue.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpSearchValue.Location = new System.Drawing.Point(203, 20);
			this.dtpSearchValue.Name = "dtpSearchValue";
			this.dtpSearchValue.Size = new System.Drawing.Size(189, 32);
			this.dtpSearchValue.TabIndex = 15;
			// 
			// SingersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(867, 359);
			this.Controls.Add(this.dtpSearchValue);
			this.Controls.Add(this.cbxCategory);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearchValue);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnAddNew);
			this.Name = "SingersForm";
			this.Text = "SingersForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.singerIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn singerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource singerIndexVMBindingSource;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearchValue;
		private System.Windows.Forms.ComboBox cbxCategory;
		private System.Windows.Forms.DateTimePicker dtpSearchValue;
	}
}