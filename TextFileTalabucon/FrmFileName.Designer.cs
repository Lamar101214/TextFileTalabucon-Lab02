namespace TextFileTalabucon
{
    partial class FrmFileName
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
            lblEnterFileName = new Label();
            txtFileName = new TextBox();
            btnOkay = new Button();
            SuspendLayout();
            // 
            // lblEnterFileName
            // 
            lblEnterFileName.AutoSize = true;
            lblEnterFileName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnterFileName.Location = new Point(22, 19);
            lblEnterFileName.Name = "lblEnterFileName";
            lblEnterFileName.Size = new Size(120, 21);
            lblEnterFileName.TabIndex = 0;
            lblEnterFileName.Text = "Enter File Name";
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileName.Location = new Point(26, 56);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(254, 25);
            txtFileName.TabIndex = 1;
            // 
            // btnOkay
            // 
            btnOkay.Location = new Point(109, 98);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(88, 28);
            btnOkay.TabIndex = 2;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnOkay_Click;
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 145);
            Controls.Add(btnOkay);
            Controls.Add(txtFileName);
            Controls.Add(lblEnterFileName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFileName";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FileName";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label lblEnterFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOkay;
    }
}