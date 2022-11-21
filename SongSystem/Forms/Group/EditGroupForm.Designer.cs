namespace SongSystem.Forms.Group
{
	partial class EditGroupForm
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
			this.dtpEstablished = new System.Windows.Forms.DateTimePicker();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lblEstablished = new System.Windows.Forms.Label();
			this.lblGroupName = new System.Windows.Forms.Label();
			this.txtGroupName = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// dtpEstablished
			// 
			this.dtpEstablished.CalendarFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dtpEstablished.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dtpEstablished.Location = new System.Drawing.Point(222, 89);
			this.dtpEstablished.Name = "dtpEstablished";
			this.dtpEstablished.Size = new System.Drawing.Size(191, 34);
			this.dtpEstablished.TabIndex = 38;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnUpdate.Location = new System.Drawing.Point(92, 144);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(102, 38);
			this.btnUpdate.TabIndex = 39;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnDelete.Location = new System.Drawing.Point(243, 144);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(102, 38);
			this.btnDelete.TabIndex = 40;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// lblEstablished
			// 
			this.lblEstablished.AutoSize = true;
			this.lblEstablished.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEstablished.Location = new System.Drawing.Point(17, 95);
			this.lblEstablished.Name = "lblEstablished";
			this.lblEstablished.Size = new System.Drawing.Size(189, 26);
			this.lblEstablished.TabIndex = 41;
			this.lblEstablished.Text = "Established Date:";
			// 
			// lblGroupName
			// 
			this.lblGroupName.AutoSize = true;
			this.lblGroupName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGroupName.Location = new System.Drawing.Point(58, 39);
			this.lblGroupName.Name = "lblGroupName";
			this.lblGroupName.Size = new System.Drawing.Size(148, 26);
			this.lblGroupName.TabIndex = 42;
			this.lblGroupName.Text = "Group Name:";
			// 
			// txtGroupName
			// 
			this.txtGroupName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGroupName.Location = new System.Drawing.Point(224, 36);
			this.txtGroupName.Name = "txtGroupName";
			this.txtGroupName.Size = new System.Drawing.Size(170, 32);
			this.txtGroupName.TabIndex = 37;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// EditGroupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 218);
			this.Controls.Add(this.dtpEstablished);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.lblEstablished);
			this.Controls.Add(this.lblGroupName);
			this.Controls.Add(this.txtGroupName);
			this.Name = "EditGroupForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Group";
			this.Load += new System.EventHandler(this.EditGroupForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpEstablished;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label lblEstablished;
		private System.Windows.Forms.Label lblGroupName;
		private System.Windows.Forms.TextBox txtGroupName;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}