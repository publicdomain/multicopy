// <copyright file="MainForm.cs" company="PublicDomainWeekly.com">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace MultiCopy
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:MultiCopy.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the new tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Clear lists
            this.sourceListBox.Items.Clear();
            this.targetListBox.Items.Clear();

            // Reset counters
            this.sourcesCountToolStripStatusLabel.Text = "0";
            this.targetsCountToolStripStatusLabel.Text = "0";
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            toolStripMenuItem.Checked = !toolStripMenuItem.Checked;

            // Set topmost by check box
            this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Ons the weekly releases public domain weeklycom tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnWeeklyReleasesPublicDomainWeeklycomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our public domain website
            Process.Start("https://publicdomainweekly.com");
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=51297.0");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/publicdomain/multicopy");
        }

        /// <summary>
        /// Handles the about tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the add file button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAddFileButtonClick(object sender, EventArgs e)
        {
            // Reset file name
            this.openFileDialog.FileName = string.Empty;

            // Show open file dialog
            if (this.openFileDialog.ShowDialog() == DialogResult.OK && this.openFileDialog.FileNames.Length > 0)
            {
                // Add to source list
                this.sourceListBox.Items.AddRange(this.openFileDialog.FileNames);

                // Update count
                this.sourcesCountToolStripStatusLabel.Text = this.sourceListBox.Items.Count.ToString();
            }
        }

        /// <summary>
        /// Handles the add directory button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAddDirectoryButtonClick(object sender, EventArgs e)
        {
            // Reset selected path
            this.folderBrowserDialog.SelectedPath = string.Empty;

            // Show folder browser dialog
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK && this.folderBrowserDialog.SelectedPath.Length > 0)
            {
                // Add selected path
                this.sourceListBox.Items.Add(this.folderBrowserDialog.SelectedPath);

                // Update count
                this.sourcesCountToolStripStatusLabel.Text = this.sourceListBox.Items.Count.ToString();
            }
        }

        /// <summary>
        /// Handles the add target directory button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAddTargetDirectoryButtonClick(object sender, EventArgs e)
        {
            // Reset selected path
            this.folderBrowserDialog.SelectedPath = string.Empty;

            // Show folder browser dialog
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK && this.folderBrowserDialog.SelectedPath.Length > 0)
            {
                // Add selected path
                this.targetListBox.Items.Add(this.folderBrowserDialog.SelectedPath);

                // Update count
                this.targetsCountToolStripStatusLabel.Text = this.targetListBox.Items.Count.ToString();
            }
        }

        /// <summary>
        /// Handles the processs button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnProcesssButtonClick(object sender, EventArgs e)
        {
            // Set button text
            this.processsButton.Text = "Processing...";

            // Disable controls
            this.EnableControls(false);

            // Set error count
            int errorCount = 0;

            // String builder for error lines
            var errorLineStringBuilder = new StringBuilder($"{Environment.NewLine}{Environment.NewLine}{new String('=', 10)}{Environment.NewLine}MultiCopy error log for {DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}:{Environment.NewLine}{Environment.NewLine}");

            // Process sources
            foreach (string sourceItem in this.sourceListBox.Items)
            {
                // Set file info
                FileInfo sourceItemFileFinfo = new FileInfo(sourceItem);

                // Ensure it exists
                if (sourceItemFileFinfo.Exists)
                {
                    // Process target directories
                    foreach (string targetDirectory in this.targetListBox.Items)
                    {
                        try
                        {
                            // Check for directory
                            if (sourceItemFileFinfo.Attributes.HasFlag(FileAttributes.Directory))
                            {
                                /* Process directory */

                                // Check if must move
                                if (this.moveCheckBox.Checked)
                                {
                                    // Move directory
                                    Directory.Move(sourceItem, targetDirectory);
                                }
                                else
                                {
                                    // Copy directory recursively
                                    this.CopyDirectoryRecursively(sourceItem, targetDirectory);
                                }
                            }
                            else
                            {
                                /* Process file */

                                // Set destination file
                                string targetFile = Path.Combine(targetDirectory, Path.GetFileName(sourceItem));

                                // Check if must move
                                if (this.moveCheckBox.Checked)
                                {
                                    // Move file
                                    File.Move(sourceItem, targetFile);
                                }
                                else
                                {
                                    // Copy file
                                    File.Copy(sourceItem, targetFile);
                                }
                            }
                        }
                        catch (Exception exception)
                        {
                            // Raise error cuont
                            errorCount++;

                            // Append to string builder
                            errorLineStringBuilder.AppendLine(new string('-', 5));
                            errorLineStringBuilder.AppendLine($"Source item: {sourceItem}");
                            errorLineStringBuilder.AppendLine($"Destination: {targetDirectory}");
                            errorLineStringBuilder.AppendLine($"Message: {exception.Message}\"");
                        }
                    }
                }
            }

            // Check for errors
            if (errorCount > 0)
            {
                // Write to disk
                File.WriteAllText("MultiCopy-ErrorLog.txt", errorLineStringBuilder.ToString());

                // Advise user
                MessageBox.Show($"There were {errorCount} errors when processing.{Environment.NewLine}Please see MultiCopy-ErrorLog.txt for details.", $"Processing error{(errorCount > 1 ? "s" : string.Empty)}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Advise user
                MessageBox.Show($"Processed {this.sourceListBox.Items.Count} source item{(this.sourceListBox.Items.Count > 1 ? "s" : string.Empty)}  successfully.{Environment.NewLine}Please see MultiCopy-ErrorLog.txt for details.", $"Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Reset button text
            this.processsButton.Text = "&Process";

            // Re-enable controls
            this.EnableControls(true);
        }

        /// <summary>
        /// Disables the enable controls.
        /// </summary>
        /// <param name="enabledFlag">If set to <c>true</c> enabled flag.</param>
        private void EnableControls(bool enabledFlag)
        {
            // Set according to passed argument
            this.processsButton.Enabled = enabledFlag;
            this.addFileButton.Enabled = enabledFlag;
            this.addDirectoryButton.Enabled = enabledFlag;
            this.addTargetDirectoryButton.Enabled = enabledFlag;
            this.sourceListBox.Enabled = enabledFlag;
            this.targetListBox.Enabled = enabledFlag;
            this.moveCheckBox.Enabled = enabledFlag;
        }

        /// <summary>
        /// Copies the directory recursively.
        /// </summary>
        /// <param name="sourceDirectory">Source directory.</param>
        /// <param name="destinationDirectory">Destination directory.</param>
        public void CopyDirectoryRecursively(string sourceDirectory, string destinationDirectory)
        {
            // Check for missing destination directory
            if (!Directory.Exists(destinationDirectory))
            {
                // Directory is not ṕresent, create it
                Directory.CreateDirectory(destinationDirectory);
            }

            // Iterate files
            foreach (var file in Directory.GetFiles(sourceDirectory))
            {
                // Copy file
                File.Copy(file, Path.Combine(destinationDirectory, Path.GetFileName(file)));
            }

            // Iterate directories
            foreach (var directory in Directory.GetDirectories(sourceDirectory))
            {
                // Call itself
                CopyDirectoryRecursively(directory, Path.Combine(destinationDirectory, Path.GetFileName(directory)));
            }
        }

        /// <summary>
        /// Handles the move check box checked changed event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMoveCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            // Make mold selectively
            this.moveCheckBox.ForeColor = this.moveCheckBox.Checked ? Color.Red : Color.Black;
        }

        /// <summary>
        /// Handles the exit tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program        
            this.Close();
        }
    }
}
