using System;
using System.IO;
using System.Windows.Forms;

namespace TextFileTalabucon
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        // Returns to the Registration form that opened this one.
        private void btnRegister_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void btnFind_Click(object? sender, EventArgs e)
        {
            DisplayToList();
        }

        private void btnUpload_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lvShowText.Items.Clear();
        }

        // Keeps the single column as wide as the ListView (minus the scroll bar).
        private void lvShowText_SizeChanged(object? sender, EventArgs e)
        {
            colText.Width = lvShowText.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;
        }

        private void DisplayToList()
        {
            // Student records are saved in Documents as <StudentNo>.txt by the Registration form.
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Title = "Find Student Record";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            // The user pressed Cancel: nothing to read.
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string path = openFileDialog1.FileName;

            try
            {
                lvShowText.Items.Clear();
                bool hasText = false;

                using (StreamReader streamReader = File.OpenText(path))
                {
                    string? _getText = "";
                    while ((_getText = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(_getText);
                        lvShowText.Items.Add(_getText);

                        if (!string.IsNullOrWhiteSpace(_getText))
                        {
                            hasText = true;
                        }
                    }
                }

                if (!hasText)
                {
                    throw new EmptyFileException($"The record '{Path.GetFileName(path)}' is empty or contains no student data.");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"The file '{path}' could not be found. It may have been moved or deleted.",
                    "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show($"The folder of '{path}' could not be found.",
                    "Folder Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EmptyFileException ex)
            {
                lvShowText.Items.Clear();
                MessageBox.Show(ex.Message, "Empty File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (IOException ex)
            {
                MessageBox.Show("The file could not be read. It may be in use by another program.\n\n" + ex.Message,
                    "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while reading the record.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
