namespace SongSystem.Forms.Song
{
	partial class CreateSongForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateSongForm));
			this.cmbAlbumName = new System.Windows.Forms.ComboBox();
			this.cmbGenreName = new System.Windows.Forms.ComboBox();
			this.cmbGroupName = new System.Windows.Forms.ComboBox();
			this.cmbSingerName = new System.Windows.Forms.ComboBox();
			this.dtpReleased = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddAlbum = new System.Windows.Forms.Button();
			this.btnAddGenre = new System.Windows.Forms.Button();
			this.btnAddGroup = new System.Windows.Forms.Button();
			this.btnAddSinger = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblReleased = new System.Windows.Forms.Label();
			this.lblLength = new System.Windows.Forms.Label();
			this.lblLanguage = new System.Windows.Forms.Label();
			this.lblArranger = new System.Windows.Forms.Label();
			this.lblAlbumName = new System.Windows.Forms.Label();
			this.lblRecordCompany = new System.Windows.Forms.Label();
			this.lblProducer = new System.Windows.Forms.Label();
			this.lblComposer = new System.Windows.Forms.Label();
			this.lblGenreName = new System.Windows.Forms.Label();
			this.lblGroupName = new System.Windows.Forms.Label();
			this.lblSingerId = new System.Windows.Forms.Label();
			this.txtArranger = new System.Windows.Forms.TextBox();
			this.txtRecordCompany = new System.Windows.Forms.TextBox();
			this.txtProducer = new System.Windows.Forms.TextBox();
			this.txtComposer = new System.Windows.Forms.TextBox();
			this.lblSongName = new System.Windows.Forms.Label();
			this.txtMinute = new System.Windows.Forms.TextBox();
			this.txtSecond = new System.Windows.Forms.TextBox();
			this.txtLanguage = new System.Windows.Forms.TextBox();
			this.txtSongName = new System.Windows.Forms.TextBox();
			this.lblLyricist = new System.Windows.Forms.Label();
			this.txtLyricist = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.lblLyric = new System.Windows.Forms.Label();
			this.txtLyric = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbAlbumName
			// 
			this.cmbAlbumName.DisplayMember = "AlbumName";
			this.cmbAlbumName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbAlbumName.FormattingEnabled = true;
			this.cmbAlbumName.Location = new System.Drawing.Point(650, 162);
			this.cmbAlbumName.Name = "cmbAlbumName";
			this.cmbAlbumName.Size = new System.Drawing.Size(208, 34);
			this.cmbAlbumName.TabIndex = 56;
			this.cmbAlbumName.ValueMember = "Id";
			// 
			// cmbGenreName
			// 
			this.cmbGenreName.DisplayMember = "GenreName";
			this.cmbGenreName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbGenreName.FormattingEnabled = true;
			this.cmbGenreName.Location = new System.Drawing.Point(223, 162);
			this.cmbGenreName.Name = "cmbGenreName";
			this.cmbGenreName.Size = new System.Drawing.Size(208, 34);
			this.cmbGenreName.TabIndex = 55;
			this.cmbGenreName.ValueMember = "Id";
			// 
			// cmbGroupName
			// 
			this.cmbGroupName.DisplayMember = "GroupName";
			this.cmbGroupName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbGroupName.FormattingEnabled = true;
			this.cmbGroupName.Location = new System.Drawing.Point(652, 95);
			this.cmbGroupName.Name = "cmbGroupName";
			this.cmbGroupName.Size = new System.Drawing.Size(208, 34);
			this.cmbGroupName.TabIndex = 54;
			this.cmbGroupName.ValueMember = "Id";
			// 
			// cmbSingerName
			// 
			this.cmbSingerName.DisplayMember = "SingerName";
			this.cmbSingerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbSingerName.FormattingEnabled = true;
			this.cmbSingerName.Location = new System.Drawing.Point(223, 95);
			this.cmbSingerName.Name = "cmbSingerName";
			this.cmbSingerName.Size = new System.Drawing.Size(208, 34);
			this.cmbSingerName.TabIndex = 53;
			this.cmbSingerName.ValueMember = "Id";
			// 
			// dtpReleased
			// 
			this.dtpReleased.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpReleased.Location = new System.Drawing.Point(223, 229);
			this.dtpReleased.Name = "dtpReleased";
			this.dtpReleased.Size = new System.Drawing.Size(208, 32);
			this.dtpReleased.TabIndex = 52;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(740, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 26);
			this.label1.TabIndex = 51;
			this.label1.Text = ":";
			// 
			// btnAddAlbum
			// 
			this.btnAddAlbum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAlbum.BackgroundImage")));
			this.btnAddAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAddAlbum.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddAlbum.Location = new System.Drawing.Point(877, 166);
			this.btnAddAlbum.Name = "btnAddAlbum";
			this.btnAddAlbum.Size = new System.Drawing.Size(25, 25);
			this.btnAddAlbum.TabIndex = 38;
			this.btnAddAlbum.UseVisualStyleBackColor = true;
			// 
			// btnAddGenre
			// 
			this.btnAddGenre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddGenre.BackgroundImage")));
			this.btnAddGenre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAddGenre.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddGenre.Location = new System.Drawing.Point(448, 166);
			this.btnAddGenre.Name = "btnAddGenre";
			this.btnAddGenre.Size = new System.Drawing.Size(25, 25);
			this.btnAddGenre.TabIndex = 37;
			this.btnAddGenre.UseVisualStyleBackColor = true;
			// 
			// btnAddGroup
			// 
			this.btnAddGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddGroup.BackgroundImage")));
			this.btnAddGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAddGroup.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddGroup.Location = new System.Drawing.Point(877, 99);
			this.btnAddGroup.Name = "btnAddGroup";
			this.btnAddGroup.Size = new System.Drawing.Size(25, 25);
			this.btnAddGroup.TabIndex = 36;
			this.btnAddGroup.UseVisualStyleBackColor = true;
			// 
			// btnAddSinger
			// 
			this.btnAddSinger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSinger.BackgroundImage")));
			this.btnAddSinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAddSinger.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddSinger.Location = new System.Drawing.Point(448, 99);
			this.btnAddSinger.Name = "btnAddSinger";
			this.btnAddSinger.Size = new System.Drawing.Size(25, 25);
			this.btnAddSinger.TabIndex = 35;
			this.btnAddSinger.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(632, 457);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(102, 38);
			this.btnSave.TabIndex = 34;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblReleased
			// 
			this.lblReleased.AutoSize = true;
			this.lblReleased.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReleased.Location = new System.Drawing.Point(102, 235);
			this.lblReleased.Name = "lblReleased";
			this.lblReleased.Size = new System.Drawing.Size(111, 26);
			this.lblReleased.TabIndex = 39;
			this.lblReleased.Text = "Released:";
			// 
			// lblLength
			// 
			this.lblLength.AutoSize = true;
			this.lblLength.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLength.Location = new System.Drawing.Point(552, 36);
			this.lblLength.Name = "lblLength";
			this.lblLength.Size = new System.Drawing.Size(90, 26);
			this.lblLength.TabIndex = 40;
			this.lblLength.Text = "Length:";
			// 
			// lblLanguage
			// 
			this.lblLanguage.AutoSize = true;
			this.lblLanguage.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLanguage.Location = new System.Drawing.Point(526, 235);
			this.lblLanguage.Name = "lblLanguage";
			this.lblLanguage.Size = new System.Drawing.Size(118, 26);
			this.lblLanguage.TabIndex = 41;
			this.lblLanguage.Text = "Language:";
			// 
			// lblArranger
			// 
			this.lblArranger.AutoSize = true;
			this.lblArranger.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblArranger.Location = new System.Drawing.Point(531, 308);
			this.lblArranger.Name = "lblArranger";
			this.lblArranger.Size = new System.Drawing.Size(111, 26);
			this.lblArranger.TabIndex = 48;
			this.lblArranger.Text = "Arranger:";
			// 
			// lblAlbumName
			// 
			this.lblAlbumName.AutoSize = true;
			this.lblAlbumName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlbumName.Location = new System.Drawing.Point(492, 165);
			this.lblAlbumName.Name = "lblAlbumName";
			this.lblAlbumName.Size = new System.Drawing.Size(150, 26);
			this.lblAlbumName.TabIndex = 45;
			this.lblAlbumName.Text = "Album Name:";
			// 
			// lblRecordCompany
			// 
			this.lblRecordCompany.AutoSize = true;
			this.lblRecordCompany.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRecordCompany.Location = new System.Drawing.Point(24, 457);
			this.lblRecordCompany.Name = "lblRecordCompany";
			this.lblRecordCompany.Size = new System.Drawing.Size(191, 26);
			this.lblRecordCompany.TabIndex = 47;
			this.lblRecordCompany.Text = "Record Company:";
			// 
			// lblProducer
			// 
			this.lblProducer.AutoSize = true;
			this.lblProducer.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProducer.Location = new System.Drawing.Point(102, 380);
			this.lblProducer.Name = "lblProducer";
			this.lblProducer.Size = new System.Drawing.Size(110, 26);
			this.lblProducer.TabIndex = 46;
			this.lblProducer.Text = "Producer:";
			// 
			// lblComposer
			// 
			this.lblComposer.AutoSize = true;
			this.lblComposer.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblComposer.Location = new System.Drawing.Point(92, 308);
			this.lblComposer.Name = "lblComposer";
			this.lblComposer.Size = new System.Drawing.Size(121, 26);
			this.lblComposer.TabIndex = 49;
			this.lblComposer.Text = "Composer:";
			// 
			// lblGenreName
			// 
			this.lblGenreName.AutoSize = true;
			this.lblGenreName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGenreName.Location = new System.Drawing.Point(65, 165);
			this.lblGenreName.Name = "lblGenreName";
			this.lblGenreName.Size = new System.Drawing.Size(148, 26);
			this.lblGenreName.TabIndex = 44;
			this.lblGenreName.Text = "Genre Name:";
			// 
			// lblGroupName
			// 
			this.lblGroupName.AutoSize = true;
			this.lblGroupName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGroupName.Location = new System.Drawing.Point(494, 98);
			this.lblGroupName.Name = "lblGroupName";
			this.lblGroupName.Size = new System.Drawing.Size(148, 26);
			this.lblGroupName.TabIndex = 43;
			this.lblGroupName.Text = "Group Name:";
			// 
			// lblSingerId
			// 
			this.lblSingerId.AutoSize = true;
			this.lblSingerId.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSingerId.Location = new System.Drawing.Point(60, 98);
			this.lblSingerId.Name = "lblSingerId";
			this.lblSingerId.Size = new System.Drawing.Size(152, 26);
			this.lblSingerId.TabIndex = 42;
			this.lblSingerId.Text = "Singer Name:";
			// 
			// txtArranger
			// 
			this.txtArranger.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtArranger.Location = new System.Drawing.Point(650, 305);
			this.txtArranger.Name = "txtArranger";
			this.txtArranger.Size = new System.Drawing.Size(208, 32);
			this.txtArranger.TabIndex = 30;
			// 
			// txtRecordCompany
			// 
			this.txtRecordCompany.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRecordCompany.Location = new System.Drawing.Point(223, 457);
			this.txtRecordCompany.Name = "txtRecordCompany";
			this.txtRecordCompany.Size = new System.Drawing.Size(208, 32);
			this.txtRecordCompany.TabIndex = 29;
			// 
			// txtProducer
			// 
			this.txtProducer.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProducer.Location = new System.Drawing.Point(223, 380);
			this.txtProducer.Name = "txtProducer";
			this.txtProducer.Size = new System.Drawing.Size(208, 32);
			this.txtProducer.TabIndex = 28;
			// 
			// txtComposer
			// 
			this.txtComposer.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComposer.Location = new System.Drawing.Point(223, 308);
			this.txtComposer.Name = "txtComposer";
			this.txtComposer.Size = new System.Drawing.Size(208, 32);
			this.txtComposer.TabIndex = 27;
			// 
			// lblSongName
			// 
			this.lblSongName.AutoSize = true;
			this.lblSongName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSongName.Location = new System.Drawing.Point(76, 36);
			this.lblSongName.Name = "lblSongName";
			this.lblSongName.Size = new System.Drawing.Size(137, 26);
			this.lblSongName.TabIndex = 50;
			this.lblSongName.Text = "Song Name:";
			// 
			// txtMinute
			// 
			this.txtMinute.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMinute.Location = new System.Drawing.Point(692, 34);
			this.txtMinute.Name = "txtMinute";
			this.txtMinute.Size = new System.Drawing.Size(42, 32);
			this.txtMinute.TabIndex = 32;
			// 
			// txtSecond
			// 
			this.txtSecond.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSecond.Location = new System.Drawing.Point(763, 33);
			this.txtSecond.Name = "txtSecond";
			this.txtSecond.Size = new System.Drawing.Size(42, 32);
			this.txtSecond.TabIndex = 31;
			// 
			// txtLanguage
			// 
			this.txtLanguage.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLanguage.Location = new System.Drawing.Point(650, 232);
			this.txtLanguage.Name = "txtLanguage";
			this.txtLanguage.Size = new System.Drawing.Size(208, 32);
			this.txtLanguage.TabIndex = 33;
			// 
			// txtSongName
			// 
			this.txtSongName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSongName.Location = new System.Drawing.Point(223, 33);
			this.txtSongName.Name = "txtSongName";
			this.txtSongName.Size = new System.Drawing.Size(208, 32);
			this.txtSongName.TabIndex = 26;
			// 
			// lblLyricist
			// 
			this.lblLyricist.AutoSize = true;
			this.lblLyricist.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLyricist.Location = new System.Drawing.Point(549, 380);
			this.lblLyricist.Name = "lblLyricist";
			this.lblLyricist.Size = new System.Drawing.Size(93, 26);
			this.lblLyricist.TabIndex = 64;
			this.lblLyricist.Text = "Lyricist:";
			// 
			// txtLyricist
			// 
			this.txtLyricist.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLyricist.Location = new System.Drawing.Point(650, 377);
			this.txtLyricist.Name = "txtLyricist";
			this.txtLyricist.Size = new System.Drawing.Size(208, 32);
			this.txtLyricist.TabIndex = 63;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// lblLyric
			// 
			this.lblLyric.AutoSize = true;
			this.lblLyric.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLyric.Location = new System.Drawing.Point(916, 36);
			this.lblLyric.Name = "lblLyric";
			this.lblLyric.Size = new System.Drawing.Size(69, 26);
			this.lblLyric.TabIndex = 66;
			this.lblLyric.Text = "Lyric:";
			// 
			// txtLyric
			// 
			this.txtLyric.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLyric.Location = new System.Drawing.Point(921, 77);
			this.txtLyric.Multiline = true;
			this.txtLyric.Name = "txtLyric";
			this.txtLyric.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtLyric.Size = new System.Drawing.Size(417, 418);
			this.txtLyric.TabIndex = 65;
			// 
			// CreateSongForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1367, 535);
			this.Controls.Add(this.lblLyric);
			this.Controls.Add(this.txtLyric);
			this.Controls.Add(this.lblLyricist);
			this.Controls.Add(this.txtLyricist);
			this.Controls.Add(this.cmbAlbumName);
			this.Controls.Add(this.cmbGenreName);
			this.Controls.Add(this.cmbGroupName);
			this.Controls.Add(this.cmbSingerName);
			this.Controls.Add(this.dtpReleased);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAddAlbum);
			this.Controls.Add(this.btnAddGenre);
			this.Controls.Add(this.btnAddGroup);
			this.Controls.Add(this.btnAddSinger);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lblReleased);
			this.Controls.Add(this.lblLength);
			this.Controls.Add(this.lblLanguage);
			this.Controls.Add(this.lblArranger);
			this.Controls.Add(this.lblAlbumName);
			this.Controls.Add(this.lblRecordCompany);
			this.Controls.Add(this.lblProducer);
			this.Controls.Add(this.lblComposer);
			this.Controls.Add(this.lblGenreName);
			this.Controls.Add(this.lblGroupName);
			this.Controls.Add(this.lblSingerId);
			this.Controls.Add(this.txtArranger);
			this.Controls.Add(this.txtRecordCompany);
			this.Controls.Add(this.txtProducer);
			this.Controls.Add(this.txtComposer);
			this.Controls.Add(this.lblSongName);
			this.Controls.Add(this.txtMinute);
			this.Controls.Add(this.txtSecond);
			this.Controls.Add(this.txtLanguage);
			this.Controls.Add(this.txtSongName);
			this.Name = "CreateSongForm";
			this.Text = "CreateSongForm";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbAlbumName;
		private System.Windows.Forms.ComboBox cmbGenreName;
		private System.Windows.Forms.ComboBox cmbGroupName;
		private System.Windows.Forms.ComboBox cmbSingerName;
		private System.Windows.Forms.DateTimePicker dtpReleased;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddAlbum;
		private System.Windows.Forms.Button btnAddGenre;
		private System.Windows.Forms.Button btnAddGroup;
		private System.Windows.Forms.Button btnAddSinger;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblReleased;
		private System.Windows.Forms.Label lblLength;
		private System.Windows.Forms.Label lblLanguage;
		private System.Windows.Forms.Label lblArranger;
		private System.Windows.Forms.Label lblAlbumName;
		private System.Windows.Forms.Label lblRecordCompany;
		private System.Windows.Forms.Label lblProducer;
		private System.Windows.Forms.Label lblComposer;
		private System.Windows.Forms.Label lblGenreName;
		private System.Windows.Forms.Label lblGroupName;
		private System.Windows.Forms.Label lblSingerId;
		private System.Windows.Forms.TextBox txtArranger;
		private System.Windows.Forms.TextBox txtRecordCompany;
		private System.Windows.Forms.TextBox txtProducer;
		private System.Windows.Forms.TextBox txtComposer;
		private System.Windows.Forms.Label lblSongName;
		private System.Windows.Forms.TextBox txtMinute;
		private System.Windows.Forms.TextBox txtSecond;
		private System.Windows.Forms.TextBox txtLanguage;
		private System.Windows.Forms.TextBox txtSongName;
		private System.Windows.Forms.Label lblLyricist;
		private System.Windows.Forms.TextBox txtLyricist;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label lblLyric;
		private System.Windows.Forms.TextBox txtLyric;
	}
}