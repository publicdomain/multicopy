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
    using System.Reflection;
    using System.Text;
    using System.Windows.Forms;
    using PublicDomainWeekly;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MultiCopy.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Set icons */

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set public domain weekly tool strip menu item image
            this.weeklyReleasesPublicDomainWeeklycomToolStripMenuItem.Image = this.associatedIcon.ToBitmap();
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
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Libraries and icons have separate licenses.{Environment.NewLine}{Environment.NewLine}" +
                $"Archive drawer Icon by OpenClipart-Vectors - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/archive-drawer-file-cabinet-154686/{Environment.NewLine}{Environment.NewLine}" +
                $"Patreon icon used according to published brand guidelines{Environment.NewLine}" +
                $"https://www.patreon.com/brand{Environment.NewLine}{Environment.NewLine}" +
                $"GitHub mark icon used according to published logos and usage guidelines{Environment.NewLine}" +
                $"https://github.com/logos{Environment.NewLine}{Environment.NewLine}" +
                $"DonationCoder icon used with permission{Environment.NewLine}" +
                $"https://www.donationcoder.com/forum/index.php?topic=48718{Environment.NewLine}{Environment.NewLine}" +
                $"PublicDomain icon is based on the following source images:{Environment.NewLine}{Environment.NewLine}" +
                $"Bitcoin by GDJ - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/bitcoin-digital-currency-4130319/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter P by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/p-glamour-gold-lights-2790632/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter D by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/d-glamour-gold-lights-2790573/{Environment.NewLine}{Environment.NewLine}";

            // Prepend sponsors
            licenseText = $"RELEASE SPONSORS:{Environment.NewLine}{Environment.NewLine}* Jesse Reichler{Environment.NewLine}{Environment.NewLine}=========={Environment.NewLine}{Environment.NewLine}" + licenseText;

            // Set title
            string programTitle = typeof(MainForm).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

            // Set version for generating semantic version 
            Version version = typeof(MainForm).GetTypeInfo().Assembly.GetName().Version;

            // Set about form
            var aboutForm = new AboutForm(
                $"About {programTitle}",
                $"{programTitle} {version.Major}.{version.Minor}.{version.Build}",
                $"Made for: amaid{Environment.NewLine}DonationCoder.com{Environment.NewLine}Day #234, Week #33 @ August 22, 2021",
                licenseText,
                this.Icon.ToBitmap())
            {
                // Set about form icon
                Icon = this.associatedIcon,

                // Set always on top
                TopMost = this.TopMost
            };

            // Show about form
            aboutForm.ShowDialog();
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
