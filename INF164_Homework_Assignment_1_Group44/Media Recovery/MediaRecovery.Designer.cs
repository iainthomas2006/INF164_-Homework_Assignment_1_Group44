namespace INF164_Homework_Assignment_1_Group44
{
    partial class MediaRecovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaRecovery));
            this.mnsMedia = new System.Windows.Forms.MenuStrip();
            this.moduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpThreshold = new System.Windows.Forms.GroupBox();
            this.lblBriefing = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpMetaData = new System.Windows.Forms.GroupBox();
            this.lblIncident = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtRecorded = new System.Windows.Forms.TextBox();
            this.lblRecorded = new System.Windows.Forms.Label();
            this.cmbSeverity = new System.Windows.Forms.ComboBox();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.txtContext = new System.Windows.Forms.TextBox();
            this.lblContext = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpValidation = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radAutoPlay = new System.Windows.Forms.RadioButton();
            this.btnBriefings = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblPackage = new System.Windows.Forms.Label();
            this.grbMedia = new System.Windows.Forms.GroupBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lblVideo = new System.Windows.Forms.Label();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.mnsMedia.SuspendLayout();
            this.grpThreshold.SuspendLayout();
            this.grpMetaData.SuspendLayout();
            this.grpValidation.SuspendLayout();
            this.grbMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsMedia
            // 
            this.mnsMedia.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMedia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduleToolStripMenuItem,
            this.sessionToolStripMenuItem});
            this.mnsMedia.Location = new System.Drawing.Point(0, 0);
            this.mnsMedia.Name = "mnsMedia";
            this.mnsMedia.Size = new System.Drawing.Size(1113, 28);
            this.mnsMedia.TabIndex = 10;
            this.mnsMedia.Text = "Module";
            // 
            // moduleToolStripMenuItem
            // 
            this.moduleToolStripMenuItem.Name = "moduleToolStripMenuItem";
            this.moduleToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.moduleToolStripMenuItem.Text = "Module";
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.sessionToolStripMenuItem.Text = "Session";
            // 
            // grpThreshold
            // 
            this.grpThreshold.Controls.Add(this.lblBriefing);
            this.grpThreshold.Controls.Add(this.btnScan);
            this.grpThreshold.Controls.Add(this.lblStatus);
            this.grpThreshold.Location = new System.Drawing.Point(13, 32);
            this.grpThreshold.Name = "grpThreshold";
            this.grpThreshold.Size = new System.Drawing.Size(402, 165);
            this.grpThreshold.TabIndex = 11;
            this.grpThreshold.TabStop = false;
            this.grpThreshold.Text = "Threshold Check:";
            // 
            // lblBriefing
            // 
            this.lblBriefing.AutoSize = true;
            this.lblBriefing.Location = new System.Drawing.Point(6, 109);
            this.lblBriefing.Name = "lblBriefing";
            this.lblBriefing.Size = new System.Drawing.Size(295, 16);
            this.lblBriefing.TabIndex = 2;
            this.lblBriefing.Text = "A Briefing is required if any of the following is true:";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(43, 68);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(114, 23);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan Now";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 18);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(199, 16);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Current Status: Not Scanned Yet ";
            // 
            // grpMetaData
            // 
            this.grpMetaData.Controls.Add(this.lblIncident);
            this.grpMetaData.Controls.Add(this.btnGenerate);
            this.grpMetaData.Controls.Add(this.txtNotes);
            this.grpMetaData.Controls.Add(this.lblNote);
            this.grpMetaData.Controls.Add(this.txtRecorded);
            this.grpMetaData.Controls.Add(this.lblRecorded);
            this.grpMetaData.Controls.Add(this.cmbSeverity);
            this.grpMetaData.Controls.Add(this.lblSeverity);
            this.grpMetaData.Controls.Add(this.cmbModule);
            this.grpMetaData.Controls.Add(this.lblModule);
            this.grpMetaData.Controls.Add(this.txtContext);
            this.grpMetaData.Controls.Add(this.lblContext);
            this.grpMetaData.Controls.Add(this.txtTitle);
            this.grpMetaData.Controls.Add(this.lblTitle);
            this.grpMetaData.Location = new System.Drawing.Point(13, 212);
            this.grpMetaData.Name = "grpMetaData";
            this.grpMetaData.Size = new System.Drawing.Size(402, 257);
            this.grpMetaData.TabIndex = 12;
            this.grpMetaData.TabStop = false;
            this.grpMetaData.Text = "Incident MetaData(TXT)";
            // 
            // lblIncident
            // 
            this.lblIncident.AutoSize = true;
            this.lblIncident.Location = new System.Drawing.Point(71, 209);
            this.lblIncident.Name = "lblIncident";
            this.lblIncident.Size = new System.Drawing.Size(230, 16);
            this.lblIncident.TabIndex = 16;
            this.lblIncident.Text = "Duration is auto-inserted after preview\r\n";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(89, 228);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(198, 23);
            this.btnGenerate.TabIndex = 15;
            this.btnGenerate.Text = "Generate incident_meta.txt";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(186, 167);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(168, 22);
            this.txtNotes.TabIndex = 14;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(183, 147);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(104, 16);
            this.lblNote.TabIndex = 13;
            this.lblNote.Text = "Notes(One Line)";
            // 
            // txtRecorded
            // 
            this.txtRecorded.Location = new System.Drawing.Point(9, 167);
            this.txtRecorded.Name = "txtRecorded";
            this.txtRecorded.Size = new System.Drawing.Size(157, 22);
            this.txtRecorded.TabIndex = 12;
            // 
            // lblRecorded
            // 
            this.lblRecorded.AutoSize = true;
            this.lblRecorded.Location = new System.Drawing.Point(6, 147);
            this.lblRecorded.Name = "lblRecorded";
            this.lblRecorded.Size = new System.Drawing.Size(160, 16);
            this.lblRecorded.TabIndex = 11;
            this.lblRecorded.Text = "Recorded by (u########)";
            // 
            // cmbSeverity
            // 
            this.cmbSeverity.FormattingEnabled = true;
            this.cmbSeverity.Location = new System.Drawing.Point(186, 105);
            this.cmbSeverity.Name = "cmbSeverity";
            this.cmbSeverity.Size = new System.Drawing.Size(168, 24);
            this.cmbSeverity.TabIndex = 10;
            // 
            // lblSeverity
            // 
            this.lblSeverity.AutoSize = true;
            this.lblSeverity.Location = new System.Drawing.Point(183, 85);
            this.lblSeverity.Name = "lblSeverity";
            this.lblSeverity.Size = new System.Drawing.Size(56, 16);
            this.lblSeverity.TabIndex = 9;
            this.lblSeverity.Text = "Severity";
            // 
            // cmbModule
            // 
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Location = new System.Drawing.Point(9, 105);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(157, 24);
            this.cmbModule.TabIndex = 8;
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(6, 85);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(52, 16);
            this.lblModule.TabIndex = 7;
            this.lblModule.Text = "Module";
            // 
            // txtContext
            // 
            this.txtContext.Location = new System.Drawing.Point(186, 48);
            this.txtContext.Name = "txtContext";
            this.txtContext.Size = new System.Drawing.Size(168, 22);
            this.txtContext.TabIndex = 6;
            // 
            // lblContext
            // 
            this.lblContext.AutoSize = true;
            this.lblContext.Location = new System.Drawing.Point(183, 29);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(171, 16);
            this.lblContext.TabIndex = 5;
            this.lblContext.Text = "Context ID(Zone/Stock/N/A)";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(9, 49);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(157, 22);
            this.txtTitle.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 16);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            // 
            // grpValidation
            // 
            this.grpValidation.Controls.Add(this.radioButton2);
            this.grpValidation.Controls.Add(this.radAutoPlay);
            this.grpValidation.Controls.Add(this.btnBriefings);
            this.grpValidation.Controls.Add(this.btnValidate);
            this.grpValidation.Controls.Add(this.lblPackage);
            this.grpValidation.Location = new System.Drawing.Point(13, 493);
            this.grpValidation.Name = "grpValidation";
            this.grpValidation.Size = new System.Drawing.Size(402, 172);
            this.grpValidation.TabIndex = 13;
            this.grpValidation.TabStop = false;
            this.grpValidation.Text = "Package Validation";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 153);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(290, 20);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Disable Auto-Play if Safety Brief not required\r\n";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radAutoPlay
            // 
            this.radAutoPlay.AutoSize = true;
            this.radAutoPlay.Location = new System.Drawing.Point(21, 127);
            this.radAutoPlay.Name = "radAutoPlay";
            this.radAutoPlay.Size = new System.Drawing.Size(218, 20);
            this.radAutoPlay.TabIndex = 18;
            this.radAutoPlay.TabStop = true;
            this.radAutoPlay.Text = "Auto Play Safety Brief if required\r\n";
            this.radAutoPlay.UseVisualStyleBackColor = true;
            // 
            // btnBriefings
            // 
            this.btnBriefings.Location = new System.Drawing.Point(9, 93);
            this.btnBriefings.Name = "btnBriefings";
            this.btnBriefings.Size = new System.Drawing.Size(198, 28);
            this.btnBriefings.TabIndex = 17;
            this.btnBriefings.Text = "Open Briefing Folder";
            this.btnBriefings.UseVisualStyleBackColor = true;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(9, 59);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(198, 28);
            this.btnValidate.TabIndex = 16;
            this.btnValidate.Text = "Validate Package";
            this.btnValidate.UseVisualStyleBackColor = true;
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(6, 31);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(107, 16);
            this.lblPackage.TabIndex = 15;
            this.lblPackage.Text = "No Package yet.";
            // 
            // grbMedia
            // 
            this.grbMedia.Controls.Add(this.btnChoose);
            this.grbMedia.Controls.Add(this.lblVideo);
            this.grbMedia.Controls.Add(this.mediaPlayer);
            this.grbMedia.Location = new System.Drawing.Point(435, 32);
            this.grbMedia.Name = "grbMedia";
            this.grbMedia.Size = new System.Drawing.Size(616, 633);
            this.grbMedia.TabIndex = 14;
            this.grbMedia.TabStop = false;
            this.grbMedia.Text = "Media Preview";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(32, 525);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(114, 23);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "Choose Video..";
            this.btnChoose.UseVisualStyleBackColor = true;
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Location = new System.Drawing.Point(29, 471);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(121, 16);
            this.lblVideo.TabIndex = 20;
            this.lblVideo.Text = "No Video Selected";
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(32, 39);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(560, 398);
            this.mediaPlayer.TabIndex = 0;
            this.mediaPlayer.Enter += new System.EventHandler(this.mediaPlayer_Enter);
            // 
            // MediaRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 695);
            this.Controls.Add(this.grbMedia);
            this.Controls.Add(this.grpValidation);
            this.Controls.Add(this.grpMetaData);
            this.Controls.Add(this.grpThreshold);
            this.Controls.Add(this.mnsMedia);
            this.Name = "MediaRecovery";
            this.Text = "MediaRecovery";
            this.mnsMedia.ResumeLayout(false);
            this.mnsMedia.PerformLayout();
            this.grpThreshold.ResumeLayout(false);
            this.grpThreshold.PerformLayout();
            this.grpMetaData.ResumeLayout(false);
            this.grpMetaData.PerformLayout();
            this.grpValidation.ResumeLayout(false);
            this.grpValidation.PerformLayout();
            this.grbMedia.ResumeLayout(false);
            this.grbMedia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMedia;
        private System.Windows.Forms.ToolStripMenuItem moduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpThreshold;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblBriefing;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.GroupBox grpMetaData;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.TextBox txtContext;
        private System.Windows.Forms.Label lblContext;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtRecorded;
        private System.Windows.Forms.Label lblRecorded;
        private System.Windows.Forms.ComboBox cmbSeverity;
        private System.Windows.Forms.Label lblSeverity;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox grpValidation;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblIncident;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radAutoPlay;
        private System.Windows.Forms.Button btnBriefings;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.GroupBox grbMedia;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label lblVideo;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
    }
}