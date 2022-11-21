namespace SongSystem.Forms.Album
{
	partial class AlbumsForm
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
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.albumNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.releasedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.albumIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnAddNew = new System.Windows.Forms.Button();
			this.txtAlbumName = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.albumIndexVMBindingSource)).BeginInit();
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
            this.albumNameDataGridViewTextBoxColumn,
            this.releasedDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.albumIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(21, 69);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(438, 288);
			this.dataGridView1.TabIndex = 5;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
			// albumNameDataGridViewTextBoxColumn
			// 
			this.albumNameDataGridViewTextBoxColumn.DataPropertyName = "AlbumName";
			this.albumNameDataGridViewTextBoxColumn.HeaderText = "AlbumName";
			this.albumNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.albumNameDataGridViewTextBoxColumn.Name = "albumNameDataGridViewTextBoxColumn";
			this.albumNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.albumNameDataGridViewTextBoxColumn.Width = 125;
			// 
			// releasedDataGridViewTextBoxColumn
			// 
			this.releasedDataGridViewTextBoxColumn.DataPropertyName = "Released";
			this.releasedDataGridViewTextBoxColumn.HeaderText = "Released";
			this.releasedDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.releasedDataGridViewTextBoxColumn.Name = "releasedDataGridViewTextBoxColumn";
			this.releasedDataGridViewTextBoxColumn.ReadOnly = true;
			this.releasedDataGridViewTextBoxColumn.Width = 125;
			// 
			// albumIndexVMBindingSource
			// 
			this.albumIndexVMBindingSource.DataSource = typeof(SongSystem.Models.ViewModels.AlbumIndexVM);
			// 
			// btnAddNew
			// 
			this.btnAddNew.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNew.Location = new System.Drawing.Point(370, 16);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(89, 34);
			this.btnAddNew.TabIndex = 4;
			this.btnAddNew.Text = "Add";
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// txtAlbumName
			// 
			this.txtAlbumName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAlbumName.Location = new System.Drawing.Point(31, 17);
			this.txtAlbumName.Name = "txtAlbumName";
			this.txtAlbumName.Size = new System.Drawing.Size(168, 32);
			this.txtAlbumName.TabIndex = 6;
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(205, 17);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(93, 33);
			this.btnSearch.TabIndex = 7;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// AlbumsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 380);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtAlbumName);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnAddNew);
			this.Name = "AlbumsForm";
			this.Text = "Album";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.albumIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn albumNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn releasedDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource albumIndexVMBindingSource;
		private System.Windows.Forms.TextBox txtAlbumName;
		private System.Windows.Forms.Button btnSearch;
	}
}