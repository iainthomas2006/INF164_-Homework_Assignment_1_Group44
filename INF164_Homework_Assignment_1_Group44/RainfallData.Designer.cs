namespace INF164_Homework_Assignment_1_Group44
{
    partial class RainfallData
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
            this.mnsRainfall = new System.Windows.Forms.MenuStrip();
            this.moduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.dgvRainfall = new System.Windows.Forms.DataGridView();
            this.lblAnomalies = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.rtxtSummary = new System.Windows.Forms.RichTextBox();
            this.btnSummary = new System.Windows.Forms.Button();
            this.mnsRainfall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRainfall)).BeginInit();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsRainfall
            // 
            this.mnsRainfall.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsRainfall.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduleToolStripMenuItem,
            this.sessionToolStripMenuItem});
            this.mnsRainfall.Location = new System.Drawing.Point(0, 0);
            this.mnsRainfall.Name = "mnsRainfall";
            this.mnsRainfall.Size = new System.Drawing.Size(1115, 28);
            this.mnsRainfall.TabIndex = 9;
            this.mnsRainfall.Text = "Module";
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
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(345, 53);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(225, 16);
            this.lblHeading.TabIndex = 10;
            this.lblHeading.Text = "Rainfall analysis(1-100 mm per zone)";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(37, 81);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(164, 23);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "Generate Rainfall Data";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(252, 81);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(164, 23);
            this.btnAnalyze.TabIndex = 12;
            this.btnAnalyze.Text = "Analyze Anomalies";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            // 
            // dgvRainfall
            // 
            this.dgvRainfall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRainfall.Location = new System.Drawing.Point(37, 134);
            this.dgvRainfall.Name = "dgvRainfall";
            this.dgvRainfall.RowHeadersWidth = 51;
            this.dgvRainfall.RowTemplate.Height = 24;
            this.dgvRainfall.Size = new System.Drawing.Size(533, 230);
            this.dgvRainfall.TabIndex = 13;
            // 
            // lblAnomalies
            // 
            this.lblAnomalies.AutoSize = true;
            this.lblAnomalies.Location = new System.Drawing.Point(34, 389);
            this.lblAnomalies.Name = "lblAnomalies";
            this.lblAnomalies.Size = new System.Drawing.Size(129, 16);
            this.lblAnomalies.TabIndex = 14;
            this.lblAnomalies.Text = "Anomolies Detected";
            this.lblAnomalies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(37, 445);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(126, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset Grid";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.rtxtSummary);
            this.grpSummary.Location = new System.Drawing.Point(623, 92);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(437, 393);
            this.grpSummary.TabIndex = 16;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Rainfall Summary";
            // 
            // rtxtSummary
            // 
            this.rtxtSummary.Location = new System.Drawing.Point(35, 42);
            this.rtxtSummary.Name = "rtxtSummary";
            this.rtxtSummary.Size = new System.Drawing.Size(372, 334);
            this.rtxtSummary.TabIndex = 0;
            this.rtxtSummary.Text = "";
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(763, 491);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(164, 53);
            this.btnSummary.TabIndex = 1;
            this.btnSummary.Text = "Generate Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            // 
            // RainfallData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 611);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblAnomalies);
            this.Controls.Add(this.dgvRainfall);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.mnsRainfall);
            this.Name = "RainfallData";
            this.Text = "RainfallData";
            this.mnsRainfall.ResumeLayout(false);
            this.mnsRainfall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRainfall)).EndInit();
            this.grpSummary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsRainfall;
        private System.Windows.Forms.ToolStripMenuItem moduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.DataGridView dgvRainfall;
        private System.Windows.Forms.Label lblAnomalies;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.RichTextBox rtxtSummary;
    }
}