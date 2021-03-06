﻿namespace PrimeCmd
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelStatusSubtitle = new System.Windows.Forms.Label();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.buttonReceive = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonCaptureScreen = new System.Windows.Forms.Button();
            this.openFilesDialogProgram = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogProgram = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorkerSend = new System.ComponentModel.BackgroundWorker();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToEmulatorKitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToCustomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFromClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelReceiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.captureScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandLineReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hPPrimeProtocolDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogProgram = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelStatusSubtitle);
            this.groupBox1.Controls.Add(this.pictureBoxStatus);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // labelStatusSubtitle
            // 
            this.labelStatusSubtitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelStatusSubtitle.Location = new System.Drawing.Point(80, 19);
            this.labelStatusSubtitle.Name = "labelStatusSubtitle";
            this.labelStatusSubtitle.Size = new System.Drawing.Size(194, 71);
            this.labelStatusSubtitle.TabIndex = 1;
            this.labelStatusSubtitle.Text = "Unknown";
            this.labelStatusSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxStatus.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStatus.Image")));
            this.pictureBoxStatus.Location = new System.Drawing.Point(3, 19);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(76, 71);
            this.pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxStatus.TabIndex = 0;
            this.pictureBoxStatus.TabStop = false;
            // 
            // buttonReceive
            // 
            this.buttonReceive.Location = new System.Drawing.Point(12, 135);
            this.buttonReceive.Name = "buttonReceive";
            this.buttonReceive.Size = new System.Drawing.Size(79, 23);
            this.buttonReceive.TabIndex = 1;
            this.buttonReceive.Text = "&Receive";
            this.buttonReceive.UseVisualStyleBackColor = true;
            this.buttonReceive.Click += new System.EventHandler(this.buttonReceive_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(97, 135);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(79, 23);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "&Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonCaptureScreen
            // 
            this.buttonCaptureScreen.Location = new System.Drawing.Point(182, 135);
            this.buttonCaptureScreen.Name = "buttonCaptureScreen";
            this.buttonCaptureScreen.Size = new System.Drawing.Size(107, 23);
            this.buttonCaptureScreen.TabIndex = 1;
            this.buttonCaptureScreen.Text = "&Capture screen";
            this.buttonCaptureScreen.UseVisualStyleBackColor = true;
            this.buttonCaptureScreen.Visible = false;
            this.buttonCaptureScreen.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // openFilesDialogProgram
            // 
            this.openFilesDialogProgram.Multiselect = true;
            this.openFilesDialogProgram.Title = "Select one or more files to send";
            // 
            // saveFileDialogProgram
            // 
            this.saveFileDialogProgram.Title = "Save file";
            // 
            // backgroundWorkerSend
            // 
            this.backgroundWorkerSend.WorkerReportsProgress = true;
            this.backgroundWorkerSend.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSend_DoWork);
            this.backgroundWorkerSend.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerSend_ProgressChanged);
            this.backgroundWorkerSend.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSend_RunWorkerCompleted);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.deviceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(301, 24);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToToolStripMenuItem,
            this.saveFromClipboardToolStripMenuItem,
            this.convertFileToolStripMenuItem,
            this.toolStripMenuItem5,
            this.preferencesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // sendToToolStripMenuItem
            // 
            this.sendToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToEmulatorKitToolStripMenuItem,
            this.sendToCustomToolStripMenuItem});
            this.sendToToolStripMenuItem.Name = "sendToToolStripMenuItem";
            this.sendToToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.sendToToolStripMenuItem.Text = "Send files to";
            // 
            // sendToEmulatorKitToolStripMenuItem
            // 
            this.sendToEmulatorKitToolStripMenuItem.Name = "sendToEmulatorKitToolStripMenuItem";
            this.sendToEmulatorKitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.sendToEmulatorKitToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.sendToEmulatorKitToolStripMenuItem.Text = "&Virtual HP Prime working folder...";
            this.sendToEmulatorKitToolStripMenuItem.Click += new System.EventHandler(this.sendToEmulatorKitToolStripMenuItem_Click);
            // 
            // sendToCustomToolStripMenuItem
            // 
            this.sendToCustomToolStripMenuItem.Name = "sendToCustomToolStripMenuItem";
            this.sendToCustomToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.sendToCustomToolStripMenuItem.Text = "&Browse...";
            this.sendToCustomToolStripMenuItem.Click += new System.EventHandler(this.sendToCustomToolStripMenuItem_Click_1);
            // 
            // saveFromClipboardToolStripMenuItem
            // 
            this.saveFromClipboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emulatorToolStripMenuItem,
            this.browseToolStripMenuItem});
            this.saveFromClipboardToolStripMenuItem.Name = "saveFromClipboardToolStripMenuItem";
            this.saveFromClipboardToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveFromClipboardToolStripMenuItem.Text = "Send clipboard to";
            // 
            // emulatorToolStripMenuItem
            // 
            this.emulatorToolStripMenuItem.Name = "emulatorToolStripMenuItem";
            this.emulatorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F10)));
            this.emulatorToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.emulatorToolStripMenuItem.Text = "&Virtual HP Prime working folder";
            this.emulatorToolStripMenuItem.Click += new System.EventHandler(this.emulatorToolStripMenuItem_Click);
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.browseToolStripMenuItem.Text = "&Browse...";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
            // 
            // convertFileToolStripMenuItem
            // 
            this.convertFileToolStripMenuItem.Name = "convertFileToolStripMenuItem";
            this.convertFileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.convertFileToolStripMenuItem.Text = "&Convert file...";
            this.convertFileToolStripMenuItem.Click += new System.EventHandler(this.convertFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(164, 6);
            this.toolStripMenuItem5.Visible = false;
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences...";
            this.preferencesToolStripMenuItem.Visible = false;
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(164, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receiveToolStripMenuItem,
            this.cancelReceiveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sendClipboardToolStripMenuItem,
            this.sendFilesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.captureScreenToolStripMenuItem});
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.deviceToolStripMenuItem.Text = "&Device";
            // 
            // receiveToolStripMenuItem
            // 
            this.receiveToolStripMenuItem.Name = "receiveToolStripMenuItem";
            this.receiveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.receiveToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.receiveToolStripMenuItem.Text = "&Receive file";
            this.receiveToolStripMenuItem.Click += new System.EventHandler(this.receiveToolStripMenuItem_Click);
            // 
            // cancelReceiveToolStripMenuItem
            // 
            this.cancelReceiveToolStripMenuItem.Name = "cancelReceiveToolStripMenuItem";
            this.cancelReceiveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F11)));
            this.cancelReceiveToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cancelReceiveToolStripMenuItem.Text = "&Cancel receive";
            this.cancelReceiveToolStripMenuItem.Click += new System.EventHandler(this.cancelReceiveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 6);
            // 
            // sendClipboardToolStripMenuItem
            // 
            this.sendClipboardToolStripMenuItem.Name = "sendClipboardToolStripMenuItem";
            this.sendClipboardToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.sendClipboardToolStripMenuItem.Text = "Send clipboard";
            this.sendClipboardToolStripMenuItem.Click += new System.EventHandler(this.sendClipboardToolStripMenuItem_Click);
            // 
            // sendFilesToolStripMenuItem
            // 
            this.sendFilesToolStripMenuItem.Name = "sendFilesToolStripMenuItem";
            this.sendFilesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.sendFilesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.sendFilesToolStripMenuItem.Text = "Send files...";
            this.sendFilesToolStripMenuItem.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(199, 6);
            this.toolStripMenuItem2.Visible = false;
            // 
            // captureScreenToolStripMenuItem
            // 
            this.captureScreenToolStripMenuItem.Name = "captureScreenToolStripMenuItem";
            this.captureScreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.captureScreenToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.captureScreenToolStripMenuItem.Text = "Capture screen";
            this.captureScreenToolStripMenuItem.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandLineReferenceToolStripMenuItem,
            this.hPPrimeProtocolDetailsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // commandLineReferenceToolStripMenuItem
            // 
            this.commandLineReferenceToolStripMenuItem.Name = "commandLineReferenceToolStripMenuItem";
            this.commandLineReferenceToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.commandLineReferenceToolStripMenuItem.Text = "&Command line reference";
            this.commandLineReferenceToolStripMenuItem.Visible = false;
            // 
            // hPPrimeProtocolDetailsToolStripMenuItem
            // 
            this.hPPrimeProtocolDetailsToolStripMenuItem.Name = "hPPrimeProtocolDetailsToolStripMenuItem";
            this.hPPrimeProtocolDetailsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.hPPrimeProtocolDetailsToolStripMenuItem.Text = "&HP Prime Protocol details";
            this.hPPrimeProtocolDetailsToolStripMenuItem.Visible = false;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(206, 6);
            this.toolStripMenuItem3.Visible = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 170);
            this.Controls.Add(this.buttonCaptureScreen);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonReceive);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
        private System.Windows.Forms.Label labelStatusSubtitle;
        private System.Windows.Forms.Button buttonReceive;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonCaptureScreen;
        private System.Windows.Forms.OpenFileDialog openFilesDialogProgram;
        private System.Windows.Forms.SaveFileDialog saveFileDialogProgram;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSend;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelReceiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sendFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem captureScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandLineReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hPPrimeProtocolDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.OpenFileDialog openFileDialogProgram;
        private System.Windows.Forms.ToolStripMenuItem sendToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToEmulatorKitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToCustomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFromClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emulatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendClipboardToolStripMenuItem;
    }
}

