using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol_10_1
{
    public partial class Form1 : Form
    {
        private async Task CopyFileAsync(string sourcePath, string destinationPath, Label progressLabel)
        {
            using (FileStream sourceStream = File.Open(sourcePath, FileMode.Open))
            using (FileStream destinationStream = File.Create(destinationPath))
            {
                byte[] buffer = new byte[8192];
                int bytesRead;
                long totalBytesCopied = 0;
                long totalBytes = sourceStream.Length;

                while ((bytesRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    await destinationStream.WriteAsync(buffer, 0, bytesRead);
                    totalBytesCopied += bytesRead;

                    // Update the progress label
                    int progressPercentage = (int)((double)totalBytesCopied / totalBytes * 100);
                    progressLabel.Invoke(new Action(() => progressLabel.Text = $"Progress: {progressPercentage}%"));
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnCopy_Click(object sender, EventArgs e)
        {
            //Here I would normally put the path to the file, thats why I have placeholders here
            string sourceFilePath = "path_to_source_file";
            string destinationFilePath = "path_to_destination_file";

            try
            {
                // Start the file copy operation in a separate thread
                await CopyFileAsync(sourceFilePath, destinationFilePath, lblProgress);

                MessageBox.Show("File copied successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

    }
}