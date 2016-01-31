using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ResourceCleaner
{
    public partial class ResourceCleaner : Form
    {
        private string GeneratedCleanResourceFilePath = string.Empty;
        public ResourceCleaner()
        {
            InitializeComponent();
        }

        private void browseProjectButton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            var result = dialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                var folder = dialog.SelectedPath;
                try
                {
                    projectFolderTextBox.Text = folder;
                }
                catch (IOException)
                {
                }
            }
        }

        private void browseResourceButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Resource files | *.resx";
            
            var result = dialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                var file = dialog.FileName;
                try
                {
                    resourcePathTextBox.Text = file;
                }
                catch (IOException)
                {
                }
            }

        }

        private void generateCleanResxButton_Click(object sender, EventArgs e)
        {
            var resourceFile = resourcePathTextBox.Text;
            var projectDirecoty = projectFolderTextBox.Text;
            var filter = filterTextBox.Text;
            if (!Directory.Exists(projectDirecoty))
            {
                MessageBox.Show("Please select existing project directory", "Invalid project directory",
                    MessageBoxButtons.OK);
                return;
            }

            if (!File.Exists(resourceFile))
            {
                MessageBox.Show("Please select existing resource file", "Invalid resource file",
                    MessageBoxButtons.OK);
                return;
            }

            if (Path.GetExtension(resourceFile).ToLower() != ".resx")
            {
                MessageBox.Show("Please select resource file with extension *.resx", "Invalid resource file",
                    MessageBoxButtons.OK);
                return;
            }
            
            var resourceFileHandler = new ResourceFileHandler(resourceFile);
            resourceFileHandler.OnUpdateStatus += (o, args) =>
            {
                outputRichTextBox.AppendText(args.Status);
                outputRichTextBox.SelectionStart = outputRichTextBox.TextLength;
                outputRichTextBox.ScrollToCaret();
            };
            outputRichTextBox.Text += "Please wait while searching unused items...";
            var unusedItems = resourceFileHandler.GetUnusedItems(projectDirecoty, filter);
            outputRichTextBox.Text = "--------------------------------------------------------------------------------------------\n";
            outputRichTextBox.Text += string.Format("--      FOUND {0} UNUSED RESOURCE FILE ITEMS       --\n", unusedItems.Length);
            outputRichTextBox.Text += "--------------------------------------------------------------------------------------------\n";
            foreach (var item in unusedItems)
            {
                outputRichTextBox.Text += string.Format("Key: {0}\n", item);
            }
            // Remove all unused items
            resourceFileHandler.RemoveKeys(unusedItems);
            // Create the path string for the new .RESX file
            var resourceFileDirectory = Path.GetDirectoryName(resourceFile);
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(resourceFile);
            var extension = Path.GetExtension(resourceFile);
            var newResourceFilePath = string.Format("{0}\\\\Clean-{1}{2}", resourceFileDirectory, fileNameWithoutExtension, extension);
            // Create new clean file
            resourceFileHandler.CreateResourceFile(newResourceFilePath);
            // enable open clean resurce button
            openCleanResource.Enabled = true;
            GeneratedCleanResourceFilePath = newResourceFilePath;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var sInfo = new ProcessStartInfo("https://dotjord.wordpress.com/2016/01/31/how-to-clean-your-unusedorphaned-resource-items-in-few-easy-steps/");
            Process.Start(sInfo);
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Do something maybe...
        }

        private void openCleanResource_Click(object sender, EventArgs e)
        {

            var dialog = new OpenFileDialog();
            dialog.Filter = "Resource files | *.resx";
            dialog.InitialDirectory = Path.GetDirectoryName(GeneratedCleanResourceFilePath);
            dialog.FileName = Path.GetFileName(GeneratedCleanResourceFilePath);
            var result = dialog.ShowDialog(); // Show the dialog.
        }
    }
}
