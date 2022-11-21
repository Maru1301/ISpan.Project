namespace SongSystem.Forms.Album
{
	partial class CreateAlbumForm
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
			this.dtpReleased = new System.Windows.Forms.DateTimePicker();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblReleased = new System.Windows.Forms.Label();
			this.lblAlbumName = new System.Windows.Forms.Label();
			this.txtAlbumName = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// dtpReleased
			// 
			this.dtpReleased.CalendarFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dtpReleased.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dtpReleased.Location = new System.Drawing.Point(216, 90);
			this.dtpReleased.Name = "dtpReleased";
			this.dtpReleased.Size = new System.Drawing.Size(191, 34);
			this.dtpReleased.TabIndex = 28;
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSave.Location = new System.Drawing.Point(286, 144);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(102, 38);
			this.btnSave.TabIndex = 29;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblReleased
			// 
			this.lblReleased.AutoSize = true;
			this.lblReleased.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReleased.Location = new System.Drawing.Point(35, 96);
			this.lblReleased.Name = "lblReleased";
			this.lblReleased.Size = new System.Drawing.Size(165, 26);
			this.lblReleased.TabIndex = 30;
			this.lblReleased.Text = "Released Date:";
			// 
			// lblAlbumName
			// 
			this.lblAlbumName.AutoSize = true;
			this.lblAlbumName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlbumName.Location = new System.Drawing.Point(50, 40);
			this.lblAlbumName.Name = "lblAlbumName";
			this.lblAlbumName.Size = new System.Drawing.Size(150, 26);
			this.lblAlbumName.TabIndex = 31;
			this.lblAlbumName.Text = "Album Name:";
			// 
			// txtAlbumName
			// 
			this.txtAlbumName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAlbumName.Location = new System.Drawing.Point(218, 37);
			this.txtAlbumName.Name = "txtAlbumName";
			this.txtAlbumName.Size = new System.Drawing.Size(170, 32);
			this.txtAlbumName.TabIndex = 27;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreateAlbumForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 212);
			this.Controls.Add(this.dtpReleased);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lblReleased);
			this.Controls.Add(this.lblAlbumName);
			this.Controls.Add(this.txtAlbumName);
			this.Name = "CreateAlbumForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Album";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpReleased;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblReleased;
		private System.Windows.Forms.Label lblAlbumName;
		private System.Windows.Forms.TextBox txtAlbumName;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}