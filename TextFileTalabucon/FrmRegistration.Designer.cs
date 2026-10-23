namespace TextFileTalabucon
{
    partial class Registration
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblStudentNo = new Label();
            txtStudentNo = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblMI = new Label();
            txtMI = new TextBox();
            lblProgram = new Label();
            cbPrograms = new ComboBox();
            lblGender = new Label();
            cbGender = new ComboBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblBirthday = new Label();
            dtpPicker = new DateTimePicker();
            lblContactNo = new Label();
            txtContactNo = new TextBox();
            btnRegister = new Button();
            btnRecords = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(18, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(127, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registration";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(22, 66);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(70, 15);
            lblStudentNo.TabIndex = 1;
            lblStudentNo.Text = "Student No.";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(96, 63);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(132, 23);
            txtStudentNo.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(22, 103);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(96, 100);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(132, 23);
            txtLastName.TabIndex = 6;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(241, 103);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(306, 100);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(106, 23);
            txtFirstName.TabIndex = 8;
            // 
            // lblMI
            // 
            lblMI.AutoSize = true;
            lblMI.Location = new Point(420, 103);
            lblMI.Name = "lblMI";
            lblMI.Size = new Size(27, 15);
            lblMI.TabIndex = 9;
            lblMI.Text = "M.I.";
            // 
            // txtMI
            // 
            txtMI.Location = new Point(446, 100);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(36, 23);
            txtMI.TabIndex = 10;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(245, 66);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(53, 15);
            lblProgram.TabIndex = 3;
            lblProgram.Text = "Program";
            // 
            // cbPrograms
            // 
            cbPrograms.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Items.AddRange(new object[] { "BS Information Technology", "BS Computer Science", "BS Information Systems" });
            cbPrograms.Location = new Point(306, 63);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(176, 23);
            cbPrograms.TabIndex = 4;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(245, 141);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 13;
            lblGender.Text = "Gender";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female", "Male" });
            cbGender.Location = new Point(306, 138);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(106, 23);
            cbGender.TabIndex = 14;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(22, 141);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 11;
            lblAge.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(96, 138);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(88, 23);
            txtAge.TabIndex = 12;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(22, 178);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(51, 15);
            lblBirthday.TabIndex = 15;
            lblBirthday.Text = "Birthday";
            // 
            // dtpPicker
            // 
            dtpPicker.Format = DateTimePickerFormat.Short;
            dtpPicker.Location = new Point(96, 175);
            dtpPicker.Name = "dtpPicker";
            dtpPicker.Size = new Size(132, 23);
            dtpPicker.TabIndex = 16;
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Location = new Point(236, 178);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(71, 15);
            lblContactNo.TabIndex = 17;
            lblContactNo.Text = "Contact No.";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(306, 175);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(176, 23);
            txtContactNo.TabIndex = 18;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(206, 216);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(96, 30);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnRecords
            // 
            btnRecords.Location = new Point(386, 216);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(96, 30);
            btnRecords.TabIndex = 20;
            btnRecords.Text = "Records";
            btnRecords.UseVisualStyleBackColor = true;
            btnRecords.Click += btnRecords_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 262);
            Controls.Add(btnRecords);
            Controls.Add(btnRegister);
            Controls.Add(txtContactNo);
            Controls.Add(lblContactNo);
            Controls.Add(dtpPicker);
            Controls.Add(lblBirthday);
            Controls.Add(cbGender);
            Controls.Add(lblGender);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtMI);
            Controls.Add(lblMI);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(cbPrograms);
            Controls.Add(lblProgram);
            Controls.Add(txtStudentNo);
            Controls.Add(lblStudentNo);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.ComboBox cbPrograms;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMI;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.DateTimePicker dtpPicker;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRecords;
    }
}