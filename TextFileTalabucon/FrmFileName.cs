using System;
using System.IO;
using System.Windows.Forms;
namespace TextFileTalabucon
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName = "";
        public FrmFileName()
        {
            InitializeComponent();
        }
        private void btnOkay_Click(object sender, EventArgs e)
        {
            string fileNameInput = txtFileName.Text?.Trim();
   
            if (string.IsNullOrWhiteSpace(fileNameInput))
            {
                MessageBox.Show("File was not created. Please enter a valid file name.", "Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFileName.Focus();
                return;
            }
            SetFileName = fileNameInput + ".txt";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fullPath = Path.Combine(docPath, SetFileName);
            try
            {
               
                if (File.Exists(fullPath))
                {
                    throw new IOException($"File was not created. '{SetFileName}' already exists in your Documents folder.");
                }
                
                using (StreamWriter writer = new StreamWriter(fullPath))
                {
                    writer.WriteLine(FrmLab1.GetInputText);
                }
           
                MessageBox.Show($"File successfully created: {SetFileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (IOException ex) { 

   
                MessageBox.Show(ex.Message, "Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("File was not created. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
