using System;
using System.IO;
using System.Windows.Forms;
namespace TextFileTalabucon
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void btnRecords_Click(object sender, EventArgs e)
        {
            // Opens the records form on top of this one; its Register button closes it and returns here.
            using (FrmStudentRecord frmStudentRecord = new FrmStudentRecord())
            {
                frmStudentRecord.ShowDialog(this);
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentNo = txtStudentNo.Text.Trim();
           
            if (string.IsNullOrWhiteSpace(studentNo))
            {
                MessageBox.Show("Student number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentNo.Focus();
                return;
            }

            foreach (char c in Path.GetInvalidFileNameChars())
            {
                if (studentNo.Contains(c))
                {
                    MessageBox.Show("Student number contains invalid characters for a file name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStudentNo.Focus();
                    return;
                }
            }
          
            foreach (char ch in studentNo)
            {
                if (!char.IsDigit(ch))
                {
                    MessageBox.Show("Student number must contain digits only (no letters or symbols).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStudentNo.Focus();
                    return;
                }
            }

    
            string lastName = txtLastName.Text?.Trim();
            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Last name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }
  
            foreach (char ch in lastName)
            {
                if (!char.IsLetter(ch) && !char.IsWhiteSpace(ch) && ch != '-')
                {
                    MessageBox.Show("Last name must contain letters only (no digits or symbols).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLastName.Focus();
                    return;
                }
            }
           
            string firstName = txtFirstName.Text?.Trim();
            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("First name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }
           
            foreach (char ch in firstName)
            {
                if (!char.IsLetter(ch) && !char.IsWhiteSpace(ch) && ch != '-')
                {
                    MessageBox.Show("First name must contain letters only (no digits or symbols).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFirstName.Focus();
                    return;
                }
            }
          
            string middleInit = txtMI.Text?.Trim();
            if (!string.IsNullOrEmpty(middleInit))
            {
                if (middleInit.Length != 1 || !char.IsLetter(middleInit[0]))
                {
                    MessageBox.Show("Middle initial must be a single letter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMI.Focus();
                    return;
                }
            }

            string fileName = studentNo + ".txt";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fullPath = Path.Combine(docPath, fileName);
           
            string[] studentDetails = new string[]
            {
               "Student No.:" + studentNo,
               "Full Name:" + lastName + ", " + firstName + ", " + middleInit + ".",
               "Program: " + cbPrograms.Text,
               "Gender: " + cbGender.Text,
               "Age: " + txtAge.Text,
               "Birthday: " + dtpPicker.Value.ToString("yyyy-MM-dd"),
               "Contact No.:" + txtContactNo.Text
            };
            try
            {
             
                if (File.Exists(fullPath))
                {
                    throw new IOException($"A record for Student No. '{studentNo}' already exists.");
                }
              
                using (StreamWriter writer = new StreamWriter(fullPath))
                {
                    foreach (string line in studentDetails)
                    {
                        writer.WriteLine(line);
                    }
                }
                MessageBox.Show("Registration details saved to " + fileName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Duplicate Entry Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}