namespace SongSystem.Forms.User
{
	partial class EditUserForm
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
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.txtPermissions = new System.Windows.Forms.TextBox();
			this.lblPermissions = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtAccount = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblAccount = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnDelete.Location = new System.Drawing.Point(199, 247);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(121, 44);
			this.btnDelete.TabIndex = 18;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnUpdate.Location = new System.Drawing.Point(36, 247);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(121, 44);
			this.btnUpdate.TabIndex = 17;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// txtPermissions
			// 
			this.txtPermissions.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPermissions.Location = new System.Drawing.Point(172, 185);
			this.txtPermissions.Name = "txtPermissions";
			this.txtPermissions.Size = new System.Drawing.Size(157, 34);
			this.txtPermissions.TabIndex = 25;
			// 
			// lblPermissions
			// 
			this.lblPermissions.AutoSize = true;
			this.lblPermissions.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPermissions.Location = new System.Drawing.Point(38, 188);
			this.lblPermissions.Name = "lblPermissions";
			this.lblPermissions.Size = new System.Drawing.Size(128, 25);
			this.lblPermissions.TabIndex = 26;
			this.lblPermissions.Text = "Permissions:";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtName.Location = new System.Drawing.Point(172, 136);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(157, 34);
			this.txtName.TabIndex = 21;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblName.Location = new System.Drawing.Point(92, 139);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(74, 25);
			this.lblName.TabIndex = 22;
			this.lblName.Text = "Name:";
			// 
			// txtAccount
			// 
			this.txtAccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtAccount.Location = new System.Drawing.Point(172, 29);
			this.txtAccount.Name = "txtAccount";
			this.txtAccount.Size = new System.Drawing.Size(157, 34);
			this.txtAccount.TabIndex = 19;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPassword.Location = new System.Drawing.Point(172, 83);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(157, 34);
			this.txtPassword.TabIndex = 20;
			// 
			// lblAccount
			// 
			this.lblAccount.AutoSize = true;
			this.lblAccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblAccount.Location = new System.Drawing.Point(71, 32);
			this.lblAccount.Name = "lblAccount";
			this.lblAccount.Size = new System.Drawing.Size(95, 25);
			this.lblAccount.TabIndex = 23;
			this.lblAccount.Text = "Account:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPassword.Location = new System.Drawing.Point(59, 86);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(107, 25);
			this.lblPassword.TabIndex = 24;
			this.lblPassword.Text = "Password:";
			// 
			// EditUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 318);
			this.Controls.Add(this.txtPermissions);
			this.Controls.Add(this.lblPermissions);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtAccount);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblAccount);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Name = "EditUserForm";
			this.Text = "EditUserForm";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox txtPermissions;
		private System.Windows.Forms.Label lblPermissions;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtAccount;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblAccount;
		private System.Windows.Forms.Label lblPassword;
	}
}