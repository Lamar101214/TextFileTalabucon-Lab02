using System;
using System.Windows.Forms;
namespace TextFileTalabucon
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void btnSimple_Click(object sender, EventArgs e)
        {
            FrmLab1 frmLab1 = new FrmLab1();
            frmLab1.ShowDialog();
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            FrmOpenTextFile frmOpenTextFile = new FrmOpenTextFile();
            frmOpenTextFile.ShowDialog();
        }
        private void btnChallenge_Click(object sender, EventArgs e)
        {
            Registration frmRegistration = new Registration();
            frmRegistration.ShowDialog();
        }
    }
}