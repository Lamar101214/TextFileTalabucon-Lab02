namespace TextFileTalabucon
{
    partial class FrmMain
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
            btnSimple = new Button();
            btnChallenge = new Button();
            btnOpenFile = new Button();
            SuspendLayout();
            // 
            // btnSimple
            // 
            btnSimple.Location = new Point(50, 48);
            btnSimple.Name = "btnSimple";
            btnSimple.Size = new Size(231, 68);
            btnSimple.TabIndex = 3;
            btnSimple.Text = "Simple";
            btnSimple.UseVisualStyleBackColor = true;
            btnSimple.Click += btnSimple_Click;
            // 
            // btnChallenge
            // 
            btnChallenge.Location = new Point(50, 150);
            btnChallenge.Name = "btnChallenge";
            btnChallenge.Size = new Size(231, 68);
            btnChallenge.TabIndex = 4;
            btnChallenge.Text = "Challenge";
            btnChallenge.UseVisualStyleBackColor = true;
            btnChallenge.Click += btnChallenge_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(50, 252);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(231, 68);
            btnOpenFile.TabIndex = 5;
            btnOpenFile.Text = "Open Text File";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 350);
            Controls.Add(btnOpenFile);
            Controls.Add(btnChallenge);
            Controls.Add(btnSimple);
            Name = "FrmMain";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSimple;
        private Button btnChallenge;
        private Button btnOpenFile;
    }
}