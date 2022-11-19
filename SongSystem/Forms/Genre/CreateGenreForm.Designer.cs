namespace SongSystem.Forms.Genre
{
	partial class CreateGenreForm
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
			this.lblGenreName = new System.Windows.Forms.Label();
			this.txtGenreName = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblGenreName
			// 
			this.lblGenreName.AutoSize = true;
			this.lblGenreName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblGenreName.Location = new System.Drawing.Point(26, 38);
			this.lblGenreName.Name = "lblGenreName";
			this.lblGenreName.Size = new System.Drawing.Size(135, 25);
			this.lblGenreName.TabIndex = 6;
			this.lblGenreName.Text = "Genre Name:";
			// 
			// txtGenreName
			// 
			this.txtGenreName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtGenreName.Location = new System.Drawing.Point(167, 35);
			this.txtGenreName.Name = "txtGenreName";
			this.txtGenreName.Size = new System.Drawing.Size(163, 34);
			this.txtGenreName.TabIndex = 3;
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSave.Location = new System.Drawing.Point(236, 98);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(94, 35);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreateGenreForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 166);
			this.Controls.Add(this.lblGenreName);
			this.Controls.Add(this.txtGenreName);
			this.Controls.Add(this.btnSave);
			this.Name = "CreateGenreForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CreateGenreForm";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblGenreName;
		private System.Windows.Forms.TextBox txtGenreName;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}