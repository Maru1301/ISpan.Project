namespace SongSystem.Forms.Song
{
	partial class EditSongForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSongForm));
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblLyric = new System.Windows.Forms.Label();
			this.txtLyric = new System.Windows.Forms.TextBox();
			this.lblLyricist = new System.Windows.Forms.Label();
			this.txtLyricist = new System.Windows.Forms.TextBox();
			this.cmbAlbumName = new System.Windows.Forms.ComboBox();
			this.cmbGenreName = new System.Windows.Forms.ComboBox();
			this.cmbGroupName = new System.Windows.Forms.ComboBox();
			this.cmbSingerName = new System.Windows.Forms.ComboBox();
			this.dtpReleased = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddAlbum = new System.Windows.Forms.Button();
			this.btnAddGenre = new System.Windows.Forms.Button();
			this.btnAddGroup = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnEnterSinger = new System.Windows.Forms.Button();
			this.btnAddSinger = new System.Windows.Forms.Button();
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
			this.lblSingerName = new System.Windows.Forms.Label();
			this.lblSingerList = new System.Windows.Forms.Label();
			this.txtArranger = new System.Windows.Forms.TextBox();
			this.txtRecordCompany = new System.Windows.Forms.TextBox();
			this.txtProducer = new System.Windows.Forms.TextBox();
			this.txtComposer = new System.Windows.Forms.TextBox();
			this.lblSongName = new System.Windows.Forms.Label();
			this.txtMinute = new System.Windows.Forms.TextBox();
			this.txtSecond = new System.Windows.Forms.TextBox();
			this.txtSingerName = new System.Windows.Forms.TextBox();
			this.txtLanguage = new System.Windows.Forms.TextBox();
			this.txtSongName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(752, 452);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(102, 38);
			this.btnDelete.TabIndex = 16;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(550, 452);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(102, 38);
			this.btnUpdate.TabIndex = 15;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblLyric
			// 
			this.lblLyric.AutoSize = true;
			this.lblLyric.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLyric.Location = new System.Drawing.Point(924, 49);
			this.lblLyric.Name = "lblLyric";
			this.lblLyric.Size = new System.Drawing.Size(69, 26);
			this.lblLyric.TabIndex = 114;
			this.lblLyric.Text = "Lyric:";
			// 
			// txtLyric
			// 
			this.txtLyric.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLyric.Location = new System.Drawing.Point(929, 90);
			this.txtLyric.Multiline = true;
			this.txtLyric.Name = "txtLyric";
			this.txtLyric.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtLyric.Size = new System.Drawing.Size(417, 418);
			this.txtLyric.TabIndex = 14;
			// 
			// lblLyricist
			// 
			this.lblLyricist.AutoSize = true;
			this.lblLyricist.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLyricist.Location = new System.Drawing.Point(559, 393);
			this.lblLyricist.Name = "lblLyricist";
			this.lblLyricist.Size = new System.Drawing.Size(93, 26);
			this.lblLyricist.TabIndex = 112;
			this.lblLyricist.Text = "Lyricist:";
			// 
			// txtLyricist
			// 
			this.txtLyricist.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLyricist.Location = new System.Drawing.Point(660, 390);
			this.txtLyricist.Name = "txtLyricist";
			this.txtLyricist.Size = new System.Drawing.Size(208, 32);
			this.txtLyricist.TabIndex = 12;
			// 
			// cmbAlbumName
			// 
			this.cmbAlbumName.DisplayMember = "AlbumName";
			this.cmbAlbumName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbAlbumName.FormattingEnabled = true;
			this.cmbAlbumName.Location = new System.Drawing.Point(660, 218);
			this.cmbAlbumName.Name = "cmbAlbumName";
			this.cmbAlbumName.Size = new System.Drawing.Size(208, 34);
			this.cmbAlbumName.TabIndex = 5;
			this.cmbAlbumName.ValueMember = "Id";
			// 
			// cmbGenreName
			// 
			this.cmbGenreName.DisplayMember = "GenreName";
			this.cmbGenreName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbGenreName.FormattingEnabled = true;
			this.cmbGenreName.Location = new System.Drawing.Point(233, 218);
			this.cmbGenreName.Name = "cmbGenreName";
			this.cmbGenreName.Size = new System.Drawing.Size(208, 34);
			this.cmbGenreName.TabIndex = 4;
			this.cmbGenreName.ValueMember = "Id";
			// 
			// cmbGroupName
			// 
			this.cmbGroupName.DisplayMember = "GroupName";
			this.cmbGroupName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbGroupName.FormattingEnabled = true;
			this.cmbGroupName.Location = new System.Drawing.Point(233, 102);
			this.cmbGroupName.Name = "cmbGroupName";
			this.cmbGroupName.Size = new System.Drawing.Size(208, 34);
			this.cmbGroupName.TabIndex = 2;
			this.cmbGroupName.ValueMember = "Id";
			// 
			// cmbSingerName
			// 
			this.cmbSingerName.DisplayMember = "SingerName";
			this.cmbSingerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbSingerName.FormattingEnabled = true;
			this.cmbSingerName.Location = new System.Drawing.Point(660, 46);
			this.cmbSingerName.Name = "cmbSingerName";
			this.cmbSingerName.Size = new System.Drawing.Size(208, 34);
			this.cmbSingerName.TabIndex = 1;
			this.cmbSingerName.ValueMember = "Id";
			// 
			// dtpReleased
			// 
			this.dtpReleased.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpReleased.Location = new System.Drawing.Point(233, 272);
			this.dtpReleased.Name = "dtpReleased";
			this.dtpReleased.Size = new System.Drawing.Size(208, 32);
			this.dtpReleased.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(747, 278);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(21, 26);
			this.label1.TabIndex = 105;
			this.label1.Text = ":";
			// 
			// btnAddAlbum
			// 
			this.btnAddAlbum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAlbum.BackgroundImage")));
			this.btnAddAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAddAlbum.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddAlbum.Location = new System.Drawing.Point(887, 222);
			this.btnAddAlbum.Name = "btnAddAlbum";
			this.btnAddAlbum.Size = new System.Drawing.Size(25, 25);
			this.btnAddAlbum.TabIndex = 91;
			this.btnAddAlbum.UseVisualStyleBackColor = true;
			this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);
			// 
			// btnAddGenre
			// 
			this.btnAddGenre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddGenre.BackgroundImage")));
			this.btnAddGenre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAddGenre.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddGenre.Location = new System.Drawing.Point(458, 222);
			this.btnAddGenre.Name = "btnAddGenre";
			this.btnAddGenre.Size = new System.Drawing.Size(25, 25);
			this.btnAddGenre.TabIndex = 90;
			this.btnAddGenre.UseVisualStyleBackColor = true;
			this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
			// 
			// btnAddGroup
			// 
			this.btnAddGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddGroup.BackgroundImage")));
			this.btnAddGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAddGroup.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddGroup.Location = new System.Drawing.Point(458, 106);
			this.btnAddGroup.Name = "btnAddGroup";
			this.btnAddGroup.Size = new System.Drawing.Size(25, 25);
			this.btnAddGroup.TabIndex = 89;
			this.btnAddGroup.UseVisualStyleBackColor = true;
			this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
			this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRefresh.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefresh.Location = new System.Drawing.Point(887, 163);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(31, 31);
			this.btnRefresh.TabIndex = 86;
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnEnterSinger
			// 
			this.btnEnterSinger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnterSinger.BackgroundImage")));
			this.btnEnterSinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnEnterSinger.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEnterSinger.Location = new System.Drawing.Point(883, 45);
			this.btnEnterSinger.Name = "btnEnterSinger";
			this.btnEnterSinger.Size = new System.Drawing.Size(35, 35);
			this.btnEnterSinger.TabIndex = 87;
			this.btnEnterSinger.UseVisualStyleBackColor = true;
			this.btnEnterSinger.Click += new System.EventHandler(this.btnEnterSinger_Click);
			// 
			// btnAddSinger
			// 
			this.btnAddSinger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSinger.BackgroundImage")));
			this.btnAddSinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAddSinger.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddSinger.Location = new System.Drawing.Point(887, 106);
			this.btnAddSinger.Name = "btnAddSinger";
			this.btnAddSinger.Size = new System.Drawing.Size(25, 25);
			this.btnAddSinger.TabIndex = 88;
			this.btnAddSinger.UseVisualStyleBackColor = true;
			this.btnAddSinger.Click += new System.EventHandler(this.btnAddSinger_Click);
			// 
			// lblReleased
			// 
			this.lblReleased.AutoSize = true;
			this.lblReleased.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReleased.Location = new System.Drawing.Point(112, 278);
			this.lblReleased.Name = "lblReleased";
			this.lblReleased.Size = new System.Drawing.Size(111, 26);
			this.lblReleased.TabIndex = 92;
			this.lblReleased.Text = "Released:";
			// 
			// lblLength
			// 
			this.lblLength.AutoSize = true;
			this.lblLength.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLength.Location = new System.Drawing.Point(559, 277);
			this.lblLength.Name = "lblLength";
			this.lblLength.Size = new System.Drawing.Size(90, 26);
			this.lblLength.TabIndex = 93;
			this.lblLength.Text = "Length:";
			// 
			// lblLanguage
			// 
			this.lblLanguage.AutoSize = true;
			this.lblLanguage.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLanguage.Location = new System.Drawing.Point(109, 163);
			this.lblLanguage.Name = "lblLanguage";
			this.lblLanguage.Size = new System.Drawing.Size(118, 26);
			this.lblLanguage.TabIndex = 94;
			this.lblLanguage.Text = "Language:";
			// 
			// lblArranger
			// 
			this.lblArranger.AutoSize = true;
			this.lblArranger.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblArranger.Location = new System.Drawing.Point(541, 335);
			this.lblArranger.Name = "lblArranger";
			this.lblArranger.Size = new System.Drawing.Size(111, 26);
			this.lblArranger.TabIndex = 102;
			this.lblArranger.Text = "Arranger:";
			// 
			// lblAlbumName
			// 
			this.lblAlbumName.AutoSize = true;
			this.lblAlbumName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlbumName.Location = new System.Drawing.Point(502, 221);
			this.lblAlbumName.Name = "lblAlbumName";
			this.lblAlbumName.Size = new System.Drawing.Size(150, 26);
			this.lblAlbumName.TabIndex = 99;
			this.lblAlbumName.Text = "Album Name:";
			// 
			// lblRecordCompany
			// 
			this.lblRecordCompany.AutoSize = true;
			this.lblRecordCompany.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRecordCompany.Location = new System.Drawing.Point(34, 455);
			this.lblRecordCompany.Name = "lblRecordCompany";
			this.lblRecordCompany.Size = new System.Drawing.Size(191, 26);
			this.lblRecordCompany.TabIndex = 101;
			this.lblRecordCompany.Text = "Record Company:";
			// 
			// lblProducer
			// 
			this.lblProducer.AutoSize = true;
			this.lblProducer.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProducer.Location = new System.Drawing.Point(112, 393);
			this.lblProducer.Name = "lblProducer";
			this.lblProducer.Size = new System.Drawing.Size(110, 26);
			this.lblProducer.TabIndex = 100;
			this.lblProducer.Text = "Producer:";
			// 
			// lblComposer
			// 
			this.lblComposer.AutoSize = true;
			this.lblComposer.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblComposer.Location = new System.Drawing.Point(102, 335);
			this.lblComposer.Name = "lblComposer";
			this.lblComposer.Size = new System.Drawing.Size(121, 26);
			this.lblComposer.TabIndex = 103;
			this.lblComposer.Text = "Composer:";
			// 
			// lblGenreName
			// 
			this.lblGenreName.AutoSize = true;
			this.lblGenreName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGenreName.Location = new System.Drawing.Point(75, 221);
			this.lblGenreName.Name = "lblGenreName";
			this.lblGenreName.Size = new System.Drawing.Size(148, 26);
			this.lblGenreName.TabIndex = 98;
			this.lblGenreName.Text = "Genre Name:";
			// 
			// lblGroupName
			// 
			this.lblGroupName.AutoSize = true;
			this.lblGroupName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGroupName.Location = new System.Drawing.Point(75, 105);
			this.lblGroupName.Name = "lblGroupName";
			this.lblGroupName.Size = new System.Drawing.Size(148, 26);
			this.lblGroupName.TabIndex = 97;
			this.lblGroupName.Text = "Group Name:";
			// 
			// lblSingerName
			// 
			this.lblSingerName.AutoSize = true;
			this.lblSingerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSingerName.Location = new System.Drawing.Point(497, 105);
			this.lblSingerName.Name = "lblSingerName";
			this.lblSingerName.Size = new System.Drawing.Size(152, 26);
			this.lblSingerName.TabIndex = 96;
			this.lblSingerName.Text = "Singer Name:";
			// 
			// lblSingerList
			// 
			this.lblSingerList.AutoSize = true;
			this.lblSingerList.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSingerList.Location = new System.Drawing.Point(520, 49);
			this.lblSingerList.Name = "lblSingerList";
			this.lblSingerList.Size = new System.Drawing.Size(129, 26);
			this.lblSingerList.TabIndex = 95;
			this.lblSingerList.Text = "Singer List:";
			// 
			// txtArranger
			// 
			this.txtArranger.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtArranger.Location = new System.Drawing.Point(660, 332);
			this.txtArranger.Name = "txtArranger";
			this.txtArranger.Size = new System.Drawing.Size(208, 32);
			this.txtArranger.TabIndex = 10;
			// 
			// txtRecordCompany
			// 
			this.txtRecordCompany.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRecordCompany.Location = new System.Drawing.Point(233, 455);
			this.txtRecordCompany.Name = "txtRecordCompany";
			this.txtRecordCompany.Size = new System.Drawing.Size(208, 32);
			this.txtRecordCompany.TabIndex = 13;
			// 
			// txtProducer
			// 
			this.txtProducer.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProducer.Location = new System.Drawing.Point(233, 393);
			this.txtProducer.Name = "txtProducer";
			this.txtProducer.Size = new System.Drawing.Size(208, 32);
			this.txtProducer.TabIndex = 11;
			// 
			// txtComposer
			// 
			this.txtComposer.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComposer.Location = new System.Drawing.Point(233, 335);
			this.txtComposer.Name = "txtComposer";
			this.txtComposer.Size = new System.Drawing.Size(208, 32);
			this.txtComposer.TabIndex = 9;
			// 
			// lblSongName
			// 
			this.lblSongName.AutoSize = true;
			this.lblSongName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSongName.Location = new System.Drawing.Point(84, 49);
			this.lblSongName.Name = "lblSongName";
			this.lblSongName.Size = new System.Drawing.Size(137, 26);
			this.lblSongName.TabIndex = 104;
			this.lblSongName.Text = "Song Name:";
			// 
			// txtMinute
			// 
			this.txtMinute.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMinute.Location = new System.Drawing.Point(699, 275);
			this.txtMinute.Name = "txtMinute";
			this.txtMinute.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtMinute.Size = new System.Drawing.Size(42, 32);
			this.txtMinute.TabIndex = 7;
			// 
			// txtSecond
			// 
			this.txtSecond.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSecond.Location = new System.Drawing.Point(770, 274);
			this.txtSecond.Name = "txtSecond";
			this.txtSecond.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtSecond.Size = new System.Drawing.Size(42, 32);
			this.txtSecond.TabIndex = 8;
			// 
			// txtSingerName
			// 
			this.txtSingerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSingerName.Location = new System.Drawing.Point(660, 102);
			this.txtSingerName.Multiline = true;
			this.txtSingerName.Name = "txtSingerName";
			this.txtSingerName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtSingerName.Size = new System.Drawing.Size(221, 90);
			this.txtSingerName.TabIndex = 84;
			// 
			// txtLanguage
			// 
			this.txtLanguage.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLanguage.Location = new System.Drawing.Point(233, 160);
			this.txtLanguage.Name = "txtLanguage";
			this.txtLanguage.Size = new System.Drawing.Size(208, 32);
			this.txtLanguage.TabIndex = 3;
			// 
			// txtSongName
			// 
			this.txtSongName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSongName.Location = new System.Drawing.Point(231, 46);
			this.txtSongName.Name = "txtSongName";
			this.txtSongName.Size = new System.Drawing.Size(208, 32);
			this.txtSongName.TabIndex = 0;
			// 
			// EditSongForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1382, 533);
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
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnEnterSinger);
			this.Controls.Add(this.btnAddSinger);
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
			this.Controls.Add(this.lblSingerName);
			this.Controls.Add(this.lblSingerList);
			this.Controls.Add(this.txtArranger);
			this.Controls.Add(this.txtRecordCompany);
			this.Controls.Add(this.txtProducer);
			this.Controls.Add(this.txtComposer);
			this.Controls.Add(this.lblSongName);
			this.Controls.Add(this.txtMinute);
			this.Controls.Add(this.txtSecond);
			this.Controls.Add(this.txtSingerName);
			this.Controls.Add(this.txtLanguage);
			this.Controls.Add(this.txtSongName);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1400, 580);
			this.Name = "EditSongForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Song";
			this.Load += new System.EventHandler(this.EditSongForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label lblLyric;
		private System.Windows.Forms.TextBox txtLyric;
		private System.Windows.Forms.Label lblLyricist;
		private System.Windows.Forms.TextBox txtLyricist;
		private System.Windows.Forms.ComboBox cmbAlbumName;
		private System.Windows.Forms.ComboBox cmbGenreName;
		private System.Windows.Forms.ComboBox cmbGroupName;
		private System.Windows.Forms.ComboBox cmbSingerName;
		private System.Windows.Forms.DateTimePicker dtpReleased;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddAlbum;
		private System.Windows.Forms.Button btnAddGenre;
		private System.Windows.Forms.Button btnAddGroup;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnEnterSinger;
		private System.Windows.Forms.Button btnAddSinger;
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
		private System.Windows.Forms.Label lblSingerName;
		private System.Windows.Forms.Label lblSingerList;
		private System.Windows.Forms.TextBox txtArranger;
		private System.Windows.Forms.TextBox txtRecordCompany;
		private System.Windows.Forms.TextBox txtProducer;
		private System.Windows.Forms.TextBox txtComposer;
		private System.Windows.Forms.Label lblSongName;
		private System.Windows.Forms.TextBox txtMinute;
		private System.Windows.Forms.TextBox txtSecond;
		private System.Windows.Forms.TextBox txtSingerName;
		private System.Windows.Forms.TextBox txtLanguage;
		private System.Windows.Forms.TextBox txtSongName;
	}
}