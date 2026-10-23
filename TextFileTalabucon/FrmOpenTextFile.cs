using System;
using System.IO;
using System.Windows.Forms;

namespace TextFileTalabucon
{
    public partial class FrmOpenTextFile : Form
    {
        public FrmOpenTextFile()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object? sender, EventArgs e)
        {
            DisplayToList();
        }

        // Keeps the single column as wide as the ListView (minus the scroll bar).
        private void lvShowText_SizeChanged(object? sender, EventArgs e)
        {
            colText.Width = lvShowText.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;
        }

        private void DisplayToList()
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Title = "Browse Text Files";
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
                    throw new EmptyFileException($"The file '{Path.GetFileName(path)}' is empty or contains no text.");
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
                MessageBox.Show("An unexpected error occurred while opening the file.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
