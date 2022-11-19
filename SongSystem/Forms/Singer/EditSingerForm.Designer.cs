namespace SongSystem.Forms.Singer
{
	partial class EditSingerForm
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
			this.btnPlus = new System.Windows.Forms.Button();
			this.cmbGroupName = new System.Windows.Forms.ComboBox();
			this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lblGroupName = new System.Windows.Forms.Label();
			this.lblSingerCountry = new System.Windows.Forms.Label();
			this.lblSingerBirthday = new System.Windows.Forms.Label();
			this.lblSingerGender = new System.Windows.Forms.Label();
			this.lblSingerName = new System.Windows.Forms.Label();
			this.txtSingerCountry = new System.Windows.Forms.TextBox();
			this.txtSingerName = new System.Windows.Forms.TextBox();
			this.rdBtnFemale = new System.Windows.Forms.RadioButton();
			this.rdBtnMale = new System.Windows.Forms.RadioButton();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnPlus
			// 
			this.btnPlus.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlus.Location = new System.Drawing.Point(380, 225);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(36, 34);
			this.btnPlus.TabIndex = 40;
			this.btnPlus.Text = "+";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			// 
			// cmbGroupName
			// 
			this.cmbGroupName.DisplayMember = "GroupName";
			this.cmbGroupName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbGroupName.FormattingEnabled = true;
			this.cmbGroupName.Location = new System.Drawing.Point(198, 225);
			this.cmbGroupName.Name = "cmbGroupName";
			this.cmbGroupName.Size = new System.Drawing.Size(170, 34);
			this.cmbGroupName.TabIndex = 39;
			this.cmbGroupName.ValueMember = "Id";
			// 
			// dtpDateOfBirth
			// 
			this.dtpDateOfBirth.CalendarFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dtpDateOfBirth.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dtpDateOfBirth.Location = new System.Drawing.Point(198, 172);
			this.dtpDateOfBirth.Name = "dtpDateOfBirth";
			this.dtpDateOfBirth.Size = new System.Drawing.Size(191, 34);
			this.dtpDateOfBirth.TabIndex = 31;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnUpdate.Location = new System.Drawing.Point(80, 288);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(102, 38);
			this.btnUpdate.TabIndex = 32;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnDelete.Location = new System.Drawing.Point(266, 288);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(102, 38);
			this.btnDelete.TabIndex = 33;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// lblGroupName
			// 
			this.lblGroupName.AutoSize = true;
			this.lblGroupName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGroupName.Location = new System.Drawing.Point(34, 228);
			this.lblGroupName.Name = "lblGroupName";
			this.lblGroupName.Size = new System.Drawing.Size(148, 26);
			this.lblGroupName.TabIndex = 34;
			this.lblGroupName.Text = "Group Name:";
			// 
			// lblSingerCountry
			// 
			this.lblSingerCountry.AutoSize = true;
			this.lblSingerCountry.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSingerCountry.Location = new System.Drawing.Point(80, 123);
			this.lblSingerCountry.Name = "lblSingerCountry";
			this.lblSingerCountry.Size = new System.Drawing.Size(102, 26);
			this.lblSingerCountry.TabIndex = 35;
			this.lblSingerCountry.Text = "Country:";
			// 
			// lblSingerBirthday
			// 
			this.lblSingerBirthday.AutoSize = true;
			this.lblSingerBirthday.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSingerBirthday.Location = new System.Drawing.Point(33, 178);
			this.lblSingerBirthday.Name = "lblSingerBirthday";
			this.lblSingerBirthday.Size = new System.Drawing.Size(149, 26);
			this.lblSingerBirthday.TabIndex = 36;
			this.lblSingerBirthday.Text = "Date of birth:";
			// 
			// lblSingerGender
			// 
			this.lblSingerGender.AutoSize = true;
			this.lblSingerGender.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSingerGender.Location = new System.Drawing.Point(87, 75);
			this.lblSingerGender.Name = "lblSingerGender";
			this.lblSingerGender.Size = new System.Drawing.Size(95, 26);
			this.lblSingerGender.TabIndex = 37;
			this.lblSingerGender.Text = "Gender:";
			// 
			// lblSingerName
			// 
			this.lblSingerName.AutoSize = true;
			this.lblSingerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSingerName.Location = new System.Drawing.Point(30, 29);
			this.lblSingerName.Name = "lblSingerName";
			this.lblSingerName.Size = new System.Drawing.Size(152, 26);
			this.lblSingerName.TabIndex = 38;
			this.lblSingerName.Text = "Singer Name:";
			// 
			// txtSingerCountry
			// 
			this.txtSingerCountry.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSingerCountry.Location = new System.Drawing.Point(198, 123);
			this.txtSingerCountry.Name = "txtSingerCountry";
			this.txtSingerCountry.Size = new System.Drawing.Size(170, 32);
			this.txtSingerCountry.TabIndex = 30;
			// 
			// txtSingerName
			// 
			this.txtSingerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSingerName.Location = new System.Drawing.Point(198, 26);
			this.txtSingerName.Name = "txtSingerName";
			this.txtSingerName.Size = new System.Drawing.Size(170, 32);
			this.txtSingerName.TabIndex = 27;
			// 
			// rdBtnFemale
			// 
			this.rdBtnFemale.AutoSize = true;
			this.rdBtnFemale.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdBtnFemale.Location = new System.Drawing.Point(273, 73);
			this.rdBtnFemale.Name = "rdBtnFemale";
			this.rdBtnFemale.Size = new System.Drawing.Size(106, 30);
			this.rdBtnFemale.TabIndex = 42;
			this.rdBtnFemale.Text = "Female";
			this.rdBtnFemale.UseVisualStyleBackColor = true;
			// 
			// rdBtnMale
			// 
			this.rdBtnMale.AutoSize = true;
			this.rdBtnMale.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdBtnMale.Location = new System.Drawing.Point(198, 73);
			this.rdBtnMale.Name = "rdBtnMale";
			this.rdBtnMale.Size = new System.Drawing.Size(80, 30);
			this.rdBtnMale.TabIndex = 41;
			this.rdBtnMale.Text = "Male";
			this.rdBtnMale.UseVisualStyleBackColor = true;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// EditSingerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 359);
			this.Controls.Add(this.rdBtnFemale);
			this.Controls.Add(this.rdBtnMale);
			this.Controls.Add(this.btnPlus);
			this.Controls.Add(this.cmbGroupName);
			this.Controls.Add(this.dtpDateOfBirth);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.lblGroupName);
			this.Controls.Add(this.lblSingerCountry);
			this.Controls.Add(this.lblSingerBirthday);
			this.Controls.Add(this.lblSingerGender);
			this.Controls.Add(this.lblSingerName);
			this.Controls.Add(this.txtSingerCountry);
			this.Controls.Add(this.txtSingerName);
			this.Name = "EditSingerForm";
			this.Text = "EditSingerForm";
			this.Load += new System.EventHandler(this.EditSingerForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.ComboBox cmbGroupName;
		private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label lblGroupName;
		private System.Windows.Forms.Label lblSingerCountry;
		private System.Windows.Forms.Label lblSingerBirthday;
		private System.Windows.Forms.Label lblSingerGender;
		private System.Windows.Forms.Label lblSingerName;
		private System.Windows.Forms.TextBox txtSingerCountry;
		private System.Windows.Forms.TextBox txtSingerName;
		private System.Windows.Forms.RadioButton rdBtnFemale;
		private System.Windows.Forms.RadioButton rdBtnMale;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}