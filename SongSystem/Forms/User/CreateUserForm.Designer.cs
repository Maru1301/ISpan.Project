namespace SongSystem.Forms.User
{
	partial class CreateUserForm
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
			this.btnSave = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtAccount = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblAccount = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.txtPermissions = new System.Windows.Forms.TextBox();
			this.lblPermissions = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSave.Location = new System.Drawing.Point(154, 242);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(105, 44);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtName.Location = new System.Drawing.Point(169, 136);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(157, 34);
			this.txtName.TabIndex = 10;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblName.Location = new System.Drawing.Point(89, 139);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(74, 25);
			this.lblName.TabIndex = 12;
			this.lblName.Text = "Name:";
			// 
			// txtAccount
			// 
			this.txtAccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtAccount.Location = new System.Drawing.Point(169, 29);
			this.txtAccount.Name = "txtAccount";
			this.txtAccount.Size = new System.Drawing.Size(157, 34);
			this.txtAccount.TabIndex = 8;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPassword.Location = new System.Drawing.Point(169, 83);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(157, 34);
			this.txtPassword.TabIndex = 9;
			// 
			// lblAccount
			// 
			this.lblAccount.AutoSize = true;
			this.lblAccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblAccount.Location = new System.Drawing.Point(68, 32);
			this.lblAccount.Name = "lblAccount";
			this.lblAccount.Size = new System.Drawing.Size(95, 25);
			this.lblAccount.TabIndex = 13;
			this.lblAccount.Text = "Account:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPassword.Location = new System.Drawing.Point(56, 86);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(107, 25);
			this.lblPassword.TabIndex = 14;
			this.lblPassword.Text = "Password:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// txtPermissions
			// 
			this.txtPermissions.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPermissions.Location = new System.Drawing.Point(169, 185);
			this.txtPermissions.Name = "txtPermissions";
			this.txtPermissions.Size = new System.Drawing.Size(157, 34);
			this.txtPermissions.TabIndex = 15;
			// 
			// lblPermissions
			// 
			this.lblPermissions.AutoSize = true;
			this.lblPermissions.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPermissions.Location = new System.Drawing.Point(35, 188);
			this.lblPermissions.Name = "lblPermissions";
			this.lblPermissions.Size = new System.Drawing.Size(128, 25);
			this.lblPermissions.TabIndex = 16;
			this.lblPermissions.Text = "Permissions:";
			// 
			// CreateUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 298);
			this.Controls.Add(this.txtPermissions);
			this.Controls.Add(this.lblPermissions);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtAccount);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblAccount);
			this.Controls.Add(this.lblPassword);
			this.Name = "CreateUserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add User";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtAccount;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblAccount;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox txtPermissions;
		private System.Windows.Forms.Label lblPermissions;
	}
}