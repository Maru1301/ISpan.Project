namespace SongSystem.Forms.Singer
{
	partial class CreateSingerForm
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
			this.btnSave = new System.Windows.Forms.Button();
			this.lblGroupName = new System.Windows.Forms.Label();
			this.lblSingerCountry = new System.Windows.Forms.Label();
			this.lblSingerBirthday = new System.Windows.Forms.Label();
			this.lblSingerGender = new System.Windows.Forms.Label();
			this.lblSingerName = new System.Windows.Forms.Label();
			this.txtSingerCountry = new System.Windows.Forms.TextBox();
			this.txtSingerName = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.rdBtnFemale = new System.Windows.Forms.RadioButton();
			this.rdBtnMale = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnPlus
			// 
			this.btnPlus.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlus.Location = new System.Drawing.Point(377, 219);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(36, 34);
			this.btnPlus.TabIndex = 26;
			this.btnPlus.Text = "+";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			// 
			// cmbGroupName
			// 
			this.cmbGroupName.DisplayMember = "GroupName";
			this.cmbGroupName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbGroupName.FormattingEnabled = true;
			this.cmbGroupName.Location = new System.Drawing.Point(195, 219);
			this.cmbGroupName.Name = "cmbGroupName";
			this.cmbGroupName.Size = new System.Drawing.Size(170, 34);
			this.cmbGroupName.TabIndex = 25;
			this.cmbGroupName.ValueMember = "Id";
			// 
			// dtpDateOfBirth
			// 
			this.dtpDateOfBirth.CalendarFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dtpDateOfBirth.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dtpDateOfBirth.Location = new System.Drawing.Point(195, 166);
			this.dtpDateOfBirth.Name = "dtpDateOfBirth";
			this.dtpDateOfBirth.Size = new System.Drawing.Size(191, 34);
			this.dtpDateOfBirth.TabIndex = 18;
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSave.Location = new System.Drawing.Point(159, 278);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(102, 38);
			this.btnSave.TabIndex = 19;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblGroupName
			// 
			this.lblGroupName.AutoSize = true;
			this.lblGroupName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGroupName.Location = new System.Drawing.Point(31, 222);
			this.lblGroupName.Name = "lblGroupName";
			this.lblGroupName.Size = new System.Drawing.Size(148, 26);
			this.lblGroupName.TabIndex = 20;
			this.lblGroupName.Text = "Group Name:";
			// 
			// lblSingerCountry
			// 
			this.lblSingerCountry.AutoSize = true;
			this.lblSingerCountry.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSingerCountry.Location = new System.Drawing.Point(77, 117);
			this.lblSingerCountry.Name = "lblSingerCountry";
			this.lblSingerCountry.Size = new System.Drawing.Size(102, 26);
			this.lblSingerCountry.TabIndex = 21;
			this.lblSingerCountry.Text = "Country:";
			// 
			// lblSingerBirthday
			// 
			this.lblSingerBirthday.AutoSize = true;
			this.lblSingerBirthday.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSingerBirthday.Location = new System.Drawing.Point(30, 172);
			this.lblSingerBirthday.Name = "lblSingerBirthday";
			this.lblSingerBirthday.Size = new System.Drawing.Size(149, 26);
			this.lblSingerBirthday.TabIndex = 22;
			this.lblSingerBirthday.Text = "Date of birth:";
			// 
			// lblSingerGender
			// 
			this.lblSingerGender.AutoSize = true;
			this.lblSingerGender.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSingerGender.Location = new System.Drawing.Point(84, 69);
			this.lblSingerGender.Name = "lblSingerGender";
			this.lblSingerGender.Size = new System.Drawing.Size(95, 26);
			this.lblSingerGender.TabIndex = 23;
			this.lblSingerGender.Text = "Gender:";
			// 
			// lblSingerName
			// 
			this.lblSingerName.AutoSize = true;
			this.lblSingerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSingerName.Location = new System.Drawing.Point(27, 23);
			this.lblSingerName.Name = "lblSingerName";
			this.lblSingerName.Size = new System.Drawing.Size(152, 26);
			this.lblSingerName.TabIndex = 24;
			this.lblSingerName.Text = "Singer Name:";
			// 
			// txtSingerCountry
			// 
			this.txtSingerCountry.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSingerCountry.Location = new System.Drawing.Point(195, 117);
			this.txtSingerCountry.Name = "txtSingerCountry";
			this.txtSingerCountry.Size = new System.Drawing.Size(170, 32);
			this.txtSingerCountry.TabIndex = 17;
			// 
			// txtSingerName
			// 
			this.txtSingerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSingerName.Location = new System.Drawing.Point(195, 20);
			this.txtSingerName.Name = "txtSingerName";
			this.txtSingerName.Size = new System.Drawing.Size(170, 32);
			this.txtSingerName.TabIndex = 14;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// rdBtnFemale
			// 
			this.rdBtnFemale.AutoSize = true;
			this.rdBtnFemale.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdBtnFemale.Location = new System.Drawing.Point(270, 67);
			this.rdBtnFemale.Name = "rdBtnFemale";
			this.rdBtnFemale.Size = new System.Drawing.Size(106, 30);
			this.rdBtnFemale.TabIndex = 28;
			this.rdBtnFemale.Text = "Female";
			this.rdBtnFemale.UseVisualStyleBackColor = true;
			// 
			// rdBtnMale
			// 
			this.rdBtnMale.AutoSize = true;
			this.rdBtnMale.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdBtnMale.Location = new System.Drawing.Point(195, 67);
			this.rdBtnMale.Name = "rdBtnMale";
			this.rdBtnMale.Size = new System.Drawing.Size(80, 30);
			this.rdBtnMale.TabIndex = 27;
			this.rdBtnMale.Text = "Male";
			this.rdBtnMale.UseVisualStyleBackColor = true;
			// 
			// CreateSingerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 344);
			this.Controls.Add(this.rdBtnFemale);
			this.Controls.Add(this.rdBtnMale);
			this.Controls.Add(this.btnPlus);
			this.Controls.Add(this.cmbGroupName);
			this.Controls.Add(this.dtpDateOfBirth);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lblGroupName);
			this.Controls.Add(this.lblSingerCountry);
			this.Controls.Add(this.lblSingerBirthday);
			this.Controls.Add(this.lblSingerGender);
			this.Controls.Add(this.lblSingerName);
			this.Controls.Add(this.txtSingerCountry);
			this.Controls.Add(this.txtSingerName);
			this.Name = "CreateSingerForm";
			this.Text = "CreateSingerForm";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.ComboBox cmbGroupName;
		private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblGroupName;
		private System.Windows.Forms.Label lblSingerCountry;
		private System.Windows.Forms.Label lblSingerBirthday;
		private System.Windows.Forms.Label lblSingerGender;
		private System.Windows.Forms.Label lblSingerName;
		private System.Windows.Forms.TextBox txtSingerCountry;
		private System.Windows.Forms.TextBox txtSingerName;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.RadioButton rdBtnFemale;
		private System.Windows.Forms.RadioButton rdBtnMale;
	}
}