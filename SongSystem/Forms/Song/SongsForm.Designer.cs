namespace SongSystem.Forms.Song
{
	partial class SongsForm
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
			this.btnSearch = new System.Windows.Forms.Button();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.cmbSearch = new System.Windows.Forms.ComboBox();
			this.singerIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnAdd = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.songNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.singerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genreNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.albumNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.releasedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.composerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.arrangerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.producerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lyricistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.recordCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.songIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.singerIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.songIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(483, 15);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(134, 50);
			this.btnSearch.TabIndex = 8;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// cmbCategory
			// 
			this.cmbCategory.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Items.AddRange(new object[] {
            "Singer",
            "Group",
            "Song Genre",
            "Album",
            "Length",
            "Released",
            "Langauge",
            "Record Company"});
			this.cmbCategory.Location = new System.Drawing.Point(39, 23);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(214, 36);
			this.cmbCategory.TabIndex = 6;
			this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
			// 
			// cmbSearch
			// 
			this.cmbSearch.DataSource = this.singerIndexVMBindingSource;
			this.cmbSearch.DisplayMember = "SingerName";
			this.cmbSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbSearch.FormattingEnabled = true;
			this.cmbSearch.Location = new System.Drawing.Point(286, 23);
			this.cmbSearch.Name = "cmbSearch";
			this.cmbSearch.Size = new System.Drawing.Size(173, 36);
			this.cmbSearch.TabIndex = 7;
			this.cmbSearch.ValueMember = "Id";
			// 
			// singerIndexVMBindingSource
			// 
			this.singerIndexVMBindingSource.DataSource = typeof(SongSystem.Models.ViewModels.SingerIndexVM);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(1103, 15);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(114, 50);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songNameDataGridViewTextBoxColumn,
            this.singerNameDataGridViewTextBoxColumn,
            this.groupNameDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.genreNameDataGridViewTextBoxColumn,
            this.albumNameDataGridViewTextBoxColumn,
            this.releasedDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn,
            this.composerDataGridViewTextBoxColumn,
            this.arrangerDataGridViewTextBoxColumn,
            this.producerDataGridViewTextBoxColumn,
            this.lyricistDataGridViewTextBoxColumn,
            this.recordCompanyDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.songIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(23, 97);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(1194, 403);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// songNameDataGridViewTextBoxColumn
			// 
			this.songNameDataGridViewTextBoxColumn.DataPropertyName = "SongName";
			this.songNameDataGridViewTextBoxColumn.HeaderText = "SongName";
			this.songNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.songNameDataGridViewTextBoxColumn.Name = "songNameDataGridViewTextBoxColumn";
			this.songNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.songNameDataGridViewTextBoxColumn.Width = 125;
			// 
			// singerNameDataGridViewTextBoxColumn
			// 
			this.singerNameDataGridViewTextBoxColumn.DataPropertyName = "SingerName";
			this.singerNameDataGridViewTextBoxColumn.HeaderText = "SingerName";
			this.singerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.singerNameDataGridViewTextBoxColumn.Name = "singerNameDataGridViewTextBoxColumn";
			this.singerNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.singerNameDataGridViewTextBoxColumn.Width = 125;
			// 
			// groupNameDataGridViewTextBoxColumn
			// 
			this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
			this.groupNameDataGridViewTextBoxColumn.HeaderText = "GroupName";
			this.groupNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
			this.groupNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.groupNameDataGridViewTextBoxColumn.Width = 125;
			// 
			// lengthDataGridViewTextBoxColumn
			// 
			this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
			this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
			this.lengthDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
			this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
			this.lengthDataGridViewTextBoxColumn.Width = 125;
			// 
			// genreNameDataGridViewTextBoxColumn
			// 
			this.genreNameDataGridViewTextBoxColumn.DataPropertyName = "GenreName";
			this.genreNameDataGridViewTextBoxColumn.HeaderText = "GenreName";
			this.genreNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.genreNameDataGridViewTextBoxColumn.Name = "genreNameDataGridViewTextBoxColumn";
			this.genreNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.genreNameDataGridViewTextBoxColumn.Width = 125;
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
			// languageDataGridViewTextBoxColumn
			// 
			this.languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
			this.languageDataGridViewTextBoxColumn.HeaderText = "Language";
			this.languageDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
			this.languageDataGridViewTextBoxColumn.ReadOnly = true;
			this.languageDataGridViewTextBoxColumn.Width = 125;
			// 
			// composerDataGridViewTextBoxColumn
			// 
			this.composerDataGridViewTextBoxColumn.DataPropertyName = "Composer";
			this.composerDataGridViewTextBoxColumn.HeaderText = "Composer";
			this.composerDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.composerDataGridViewTextBoxColumn.Name = "composerDataGridViewTextBoxColumn";
			this.composerDataGridViewTextBoxColumn.ReadOnly = true;
			this.composerDataGridViewTextBoxColumn.Width = 125;
			// 
			// arrangerDataGridViewTextBoxColumn
			// 
			this.arrangerDataGridViewTextBoxColumn.DataPropertyName = "Arranger";
			this.arrangerDataGridViewTextBoxColumn.HeaderText = "Arranger";
			this.arrangerDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.arrangerDataGridViewTextBoxColumn.Name = "arrangerDataGridViewTextBoxColumn";
			this.arrangerDataGridViewTextBoxColumn.ReadOnly = true;
			this.arrangerDataGridViewTextBoxColumn.Width = 125;
			// 
			// producerDataGridViewTextBoxColumn
			// 
			this.producerDataGridViewTextBoxColumn.DataPropertyName = "Producer";
			this.producerDataGridViewTextBoxColumn.HeaderText = "Producer";
			this.producerDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.producerDataGridViewTextBoxColumn.Name = "producerDataGridViewTextBoxColumn";
			this.producerDataGridViewTextBoxColumn.ReadOnly = true;
			this.producerDataGridViewTextBoxColumn.Width = 125;
			// 
			// lyricistDataGridViewTextBoxColumn
			// 
			this.lyricistDataGridViewTextBoxColumn.DataPropertyName = "Lyricist";
			this.lyricistDataGridViewTextBoxColumn.HeaderText = "Lyricist";
			this.lyricistDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.lyricistDataGridViewTextBoxColumn.Name = "lyricistDataGridViewTextBoxColumn";
			this.lyricistDataGridViewTextBoxColumn.ReadOnly = true;
			this.lyricistDataGridViewTextBoxColumn.Width = 125;
			// 
			// recordCompanyDataGridViewTextBoxColumn
			// 
			this.recordCompanyDataGridViewTextBoxColumn.DataPropertyName = "RecordCompany";
			this.recordCompanyDataGridViewTextBoxColumn.HeaderText = "RecordCompany";
			this.recordCompanyDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.recordCompanyDataGridViewTextBoxColumn.Name = "recordCompanyDataGridViewTextBoxColumn";
			this.recordCompanyDataGridViewTextBoxColumn.ReadOnly = true;
			this.recordCompanyDataGridViewTextBoxColumn.Width = 125;
			// 
			// songIndexVMBindingSource
			// 
			this.songIndexVMBindingSource.DataSource = typeof(SongSystem.Models.ViewModels.SongIndexVM);
			// 
			// SongsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1243, 521);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.cmbSearch);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dataGridView1);
			this.Name = "SongsForm";
			this.Text = "SongsForm";
			((System.ComponentModel.ISupportInitialize)(this.singerIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.songIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.ComboBox cmbSearch;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource songIndexVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn songNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn singerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genreNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn albumNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn releasedDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn composerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn arrangerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn producerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lyricistDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn recordCompanyDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource singerIndexVMBindingSource;
	}
}