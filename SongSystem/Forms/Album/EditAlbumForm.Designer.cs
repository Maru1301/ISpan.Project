namespace SongSystem.Forms.Album
{
	partial class EditAlbumForm
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
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
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
			this.dtpReleased.Location = new System.Drawing.Point(211, 86);
			this.dtpReleased.Name = "dtpReleased";
			this.dtpReleased.Size = new System.Drawing.Size(191, 34);
			this.dtpReleased.TabIndex = 33;
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnDelete.Location = new System.Drawing.Point(241, 140);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(116, 38);
			this.btnDelete.TabIndex = 34;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnUpdate.Location = new System.Drawing.Point(70, 140);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(125, 38);
			this.btnUpdate.TabIndex = 35;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblReleased
			// 
			this.lblReleased.AutoSize = true;
			this.lblReleased.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReleased.Location = new System.Drawing.Point(30, 92);
			this.lblReleased.Name = "lblReleased";
			this.lblReleased.Size = new System.Drawing.Size(165, 26);
			this.lblReleased.TabIndex = 36;
			this.lblReleased.Text = "Released Date:";
			// 
			// lblAlbumName
			// 
			this.lblAlbumName.AutoSize = true;
			this.lblAlbumName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlbumName.Location = new System.Drawing.Point(45, 36);
			this.lblAlbumName.Name = "lblAlbumName";
			this.lblAlbumName.Size = new System.Drawing.Size(150, 26);
			this.lblAlbumName.TabIndex = 37;
			this.lblAlbumName.Text = "Album Name:";
			// 
			// txtAlbumName
			// 
			this.txtAlbumName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAlbumName.Location = new System.Drawing.Point(213, 33);
			this.txtAlbumName.Name = "txtAlbumName";
			this.txtAlbumName.Size = new System.Drawing.Size(170, 32);
			this.txtAlbumName.TabIndex = 32;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// EditAlbumForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 216);
			this.Controls.Add(this.dtpReleased);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.lblReleased);
			this.Controls.Add(this.lblAlbumName);
			this.Controls.Add(this.txtAlbumName);
			this.Name = "EditAlbumForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Album";
			this.Load += new System.EventHandler(this.EditAlbumForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpReleased;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label lblReleased;
		private System.Windows.Forms.Label lblAlbumName;
		private System.Windows.Forms.TextBox txtAlbumName;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}