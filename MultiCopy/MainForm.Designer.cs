﻿// <copyright file="MainForm.Designer.cs" company="PublicDomainWeekly.com">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
// <auto-generated />

namespace MultiCopy
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.targetsTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.sourcesTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sourcesCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.targetsCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.addFileButton = new System.Windows.Forms.Button();
            this.sourceListBox = new System.Windows.Forms.ListBox();
            this.targetDirectoriesLabel = new System.Windows.Forms.Label();
            this.addTargetDirectoryButton = new System.Windows.Forms.Button();
            this.targetListBox = new System.Windows.Forms.ListBox();
            this.addDirectoryButton = new System.Windows.Forms.Button();
            this.moveCheckBox = new System.Windows.Forms.CheckBox();
            this.processsButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyReleasesPublicDomainWeeklycomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainStatusStrip.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetsTextToolStripStatusLabel
            // 
            this.targetsTextToolStripStatusLabel.Name = "targetsTextToolStripStatusLabel";
            this.targetsTextToolStripStatusLabel.Size = new System.Drawing.Size(49, 17);
            this.targetsTextToolStripStatusLabel.Text = "Targets:";
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.sourcesTextToolStripStatusLabel,
                                    this.sourcesCountToolStripStatusLabel,
                                    this.targetsTextToolStripStatusLabel,
                                    this.targetsCountToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 346);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(288, 22);
            this.mainStatusStrip.SizingGrip = false;
            this.mainStatusStrip.TabIndex = 35;
            // 
            // sourcesTextToolStripStatusLabel
            // 
            this.sourcesTextToolStripStatusLabel.Name = "sourcesTextToolStripStatusLabel";
            this.sourcesTextToolStripStatusLabel.Size = new System.Drawing.Size(51, 17);
            this.sourcesTextToolStripStatusLabel.Text = "Sources:";
            // 
            // sourcesCountToolStripStatusLabel
            // 
            this.sourcesCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sourcesCountToolStripStatusLabel.Name = "sourcesCountToolStripStatusLabel";
            this.sourcesCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.sourcesCountToolStripStatusLabel.Text = "0";
            // 
            // targetsCountToolStripStatusLabel
            // 
            this.targetsCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetsCountToolStripStatusLabel.Name = "targetsCountToolStripStatusLabel";
            this.targetsCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.targetsCountToolStripStatusLabel.Text = "0";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 4;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.Controls.Add(this.sourceLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.addFileButton, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.sourceListBox, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.targetDirectoriesLabel, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.addTargetDirectoryButton, 0, 4);
            this.mainTableLayoutPanel.Controls.Add(this.targetListBox, 0, 5);
            this.mainTableLayoutPanel.Controls.Add(this.addDirectoryButton, 2, 1);
            this.mainTableLayoutPanel.Controls.Add(this.moveCheckBox, 0, 6);
            this.mainTableLayoutPanel.Controls.Add(this.processsButton, 1, 6);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 7;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(288, 322);
            this.mainTableLayoutPanel.TabIndex = 37;
            // 
            // sourceLabel
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.sourceLabel, 4);
            this.sourceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceLabel.Location = new System.Drawing.Point(3, 0);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(282, 20);
            this.sourceLabel.TabIndex = 14;
            this.sourceLabel.Text = "&Source items:";
            this.sourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addFileButton
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.addFileButton, 2);
            this.addFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFileButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.addFileButton.Location = new System.Drawing.Point(3, 23);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(138, 39);
            this.addFileButton.TabIndex = 15;
            this.addFileButton.Text = "&Add file(s)";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.OnAddFileButtonClick);
            // 
            // sourceListBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.sourceListBox, 4);
            this.sourceListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceListBox.FormattingEnabled = true;
            this.sourceListBox.HorizontalScrollbar = true;
            this.sourceListBox.Location = new System.Drawing.Point(3, 65);
            this.sourceListBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.sourceListBox.Name = "sourceListBox";
            this.sourceListBox.Size = new System.Drawing.Size(282, 78);
            this.sourceListBox.TabIndex = 17;
            // 
            // targetDirectoriesLabel
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.targetDirectoriesLabel, 4);
            this.targetDirectoriesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetDirectoriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.targetDirectoriesLabel.Location = new System.Drawing.Point(3, 143);
            this.targetDirectoriesLabel.Name = "targetDirectoriesLabel";
            this.targetDirectoriesLabel.Size = new System.Drawing.Size(282, 20);
            this.targetDirectoriesLabel.TabIndex = 18;
            this.targetDirectoriesLabel.Text = "&Target directories:";
            this.targetDirectoriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addTargetDirectoryButton
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.addTargetDirectoryButton, 4);
            this.addTargetDirectoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTargetDirectoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.addTargetDirectoryButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.addTargetDirectoryButton.Location = new System.Drawing.Point(3, 166);
            this.addTargetDirectoryButton.Name = "addTargetDirectoryButton";
            this.addTargetDirectoryButton.Size = new System.Drawing.Size(282, 39);
            this.addTargetDirectoryButton.TabIndex = 19;
            this.addTargetDirectoryButton.Text = "&Add &target directory";
            this.addTargetDirectoryButton.UseVisualStyleBackColor = true;
            this.addTargetDirectoryButton.Click += new System.EventHandler(this.OnAddTargetDirectoryButtonClick);
            // 
            // targetListBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.targetListBox, 4);
            this.targetListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetListBox.FormattingEnabled = true;
            this.targetListBox.HorizontalScrollbar = true;
            this.targetListBox.Location = new System.Drawing.Point(3, 208);
            this.targetListBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.targetListBox.Name = "targetListBox";
            this.targetListBox.Size = new System.Drawing.Size(282, 78);
            this.targetListBox.TabIndex = 20;
            // 
            // addDirectoryButton
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.addDirectoryButton, 2);
            this.addDirectoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addDirectoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDirectoryButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.addDirectoryButton.Location = new System.Drawing.Point(147, 23);
            this.addDirectoryButton.Name = "addDirectoryButton";
            this.addDirectoryButton.Size = new System.Drawing.Size(138, 39);
            this.addDirectoryButton.TabIndex = 16;
            this.addDirectoryButton.Text = "Add &directory";
            this.addDirectoryButton.UseVisualStyleBackColor = true;
            this.addDirectoryButton.Click += new System.EventHandler(this.OnAddDirectoryButtonClick);
            // 
            // moveCheckBox
            // 
            this.moveCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveCheckBox.Location = new System.Drawing.Point(3, 289);
            this.moveCheckBox.Name = "moveCheckBox";
            this.moveCheckBox.Size = new System.Drawing.Size(66, 30);
            this.moveCheckBox.TabIndex = 21;
            this.moveCheckBox.Text = "&Move";
            this.moveCheckBox.UseVisualStyleBackColor = true;
            // 
            // processsButton
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.processsButton, 3);
            this.processsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processsButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.processsButton.Location = new System.Drawing.Point(75, 289);
            this.processsButton.Name = "processsButton";
            this.processsButton.Size = new System.Drawing.Size(210, 30);
            this.processsButton.TabIndex = 22;
            this.processsButton.Text = "&Process";
            this.processsButton.UseVisualStyleBackColor = true;
            this.processsButton.Click += new System.EventHandler(this.OnProcesssButtonClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "TXT Files|*.txt|All files (*.*)|*.*";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.alwaysOnTopToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.minimizeToolStripMenuItem.Visible = false;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.minimizeToolStripMenuItem,
                                    this.fileToolStripMenuItem,
                                    this.optionsToolStripMenuItem,
                                    this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(288, 24);
            this.mainMenuStrip.TabIndex = 36;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.newToolStripMenuItem,
                                    this.openToolStripMenuItem,
                                    this.toolStripSeparator,
                                    this.saveToolStripMenuItem,
                                    this.saveAsToolStripMenuItem,
                                    this.toolStripSeparator1,
                                    this.printToolStripMenuItem,
                                    this.printPreviewToolStripMenuItem,
                                    this.toolStripSeparator3,
                                    this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            this.toolStripSeparator.Visible = false;
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Visible = false;
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            this.toolStripSeparator1.Visible = false;
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Visible = false;
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            this.printPreviewToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.weeklyReleasesPublicDomainWeeklycomToolStripMenuItem,
                                    this.originalThreadDonationCodercomToolStripMenuItem,
                                    this.sourceCodeGithubcomToolStripMenuItem,
                                    this.toolStripSeparator2,
                                    this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // weeklyReleasesPublicDomainWeeklycomToolStripMenuItem
            // 
            this.weeklyReleasesPublicDomainWeeklycomToolStripMenuItem.Name = "weeklyReleasesPublicDomainWeeklycomToolStripMenuItem";
            this.weeklyReleasesPublicDomainWeeklycomToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.weeklyReleasesPublicDomainWeeklycomToolStripMenuItem.Text = "&Weekly releases @ PublicDomainWeekly.com";
            this.weeklyReleasesPublicDomainWeeklycomToolStripMenuItem.Click += new System.EventHandler(this.OnWeeklyReleasesPublicDomainWeeklycomToolStripMenuItemClick);
            // 
            // originalThreadDonationCodercomToolStripMenuItem
            // 
            this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
            this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
            this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
            this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
            // 
            // sourceCodeGithubcomToolStripMenuItem
            // 
            this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
            this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
            this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.sourceCodeGithubcomToolStripMenuItem.Text = "Source code @ Github.com";
            this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(310, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 368);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiCopy";
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Button processsButton;
        private System.Windows.Forms.CheckBox moveCheckBox;
        private System.Windows.Forms.ListBox targetListBox;
        private System.Windows.Forms.Button addTargetDirectoryButton;
        private System.Windows.Forms.Label targetDirectoriesLabel;
        private System.Windows.Forms.ListBox sourceListBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button addDirectoryButton;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyReleasesPublicDomainWeeklycomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.ToolStripStatusLabel targetsCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel sourcesCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel sourcesTextToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel targetsTextToolStripStatusLabel;
    }
}
