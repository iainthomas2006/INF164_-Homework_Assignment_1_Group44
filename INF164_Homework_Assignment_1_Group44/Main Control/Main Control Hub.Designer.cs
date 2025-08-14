namespace INF164_Homework_Assignment_1_Group44
{
    partial class frmMain_Control_Hub
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
            this.rtxtAccessManager = new System.Windows.Forms.RichTextBox();
            this.grbModuleAccess = new System.Windows.Forms.GroupBox();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblRecovery = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblRainPredictor = new System.Windows.Forms.Label();
            this.lblGrowthEngine = new System.Windows.Forms.Label();
            this.mnsMainControl = new System.Windows.Forms.MenuStrip();
            this.moduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.growthEngineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rainPredictorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockTrackAndAnalyzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaAndRecoveryUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbModuleAccess.SuspendLayout();
            this.mnsMainControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtAccessManager
            // 
            this.rtxtAccessManager.Location = new System.Drawing.Point(53, 212);
            this.rtxtAccessManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxtAccessManager.Name = "rtxtAccessManager";
            this.rtxtAccessManager.Size = new System.Drawing.Size(495, 171);
            this.rtxtAccessManager.TabIndex = 4;
            this.rtxtAccessManager.Text = "";
            // 
            // grbModuleAccess
            // 
            this.grbModuleAccess.Controls.Add(this.lblSave);
            this.grbModuleAccess.Controls.Add(this.lblRecovery);
            this.grbModuleAccess.Controls.Add(this.lblStock);
            this.grbModuleAccess.Controls.Add(this.lblRainPredictor);
            this.grbModuleAccess.Controls.Add(this.lblGrowthEngine);
            this.grbModuleAccess.Location = new System.Drawing.Point(53, 39);
            this.grbModuleAccess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbModuleAccess.Name = "grbModuleAccess";
            this.grbModuleAccess.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbModuleAccess.Size = new System.Drawing.Size(494, 168);
            this.grbModuleAccess.TabIndex = 3;
            this.grbModuleAccess.TabStop = false;
            this.grbModuleAccess.Text = "Module Access Manager";
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(124, 143);
            this.lblSave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(108, 13);
            this.lblSave.TabIndex = 4;
            this.lblSave.Text = "Save Session Status:";
            // 
            // lblRecovery
            // 
            this.lblRecovery.AutoSize = true;
            this.lblRecovery.Location = new System.Drawing.Point(124, 113);
            this.lblRecovery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecovery.Name = "lblRecovery";
            this.lblRecovery.Size = new System.Drawing.Size(110, 13);
            this.lblRecovery.TabIndex = 3;
            this.lblRecovery.Text = "Media Recovery Unit:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(124, 89);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(133, 13);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Stock Track and Analyzer:";
            // 
            // lblRainPredictor
            // 
            this.lblRainPredictor.AutoSize = true;
            this.lblRainPredictor.Location = new System.Drawing.Point(124, 61);
            this.lblRainPredictor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRainPredictor.Name = "lblRainPredictor";
            this.lblRainPredictor.Size = new System.Drawing.Size(74, 13);
            this.lblRainPredictor.TabIndex = 1;
            this.lblRainPredictor.Text = "RainPredictor:";
            // 
            // lblGrowthEngine
            // 
            this.lblGrowthEngine.AutoSize = true;
            this.lblGrowthEngine.Location = new System.Drawing.Point(124, 35);
            this.lblGrowthEngine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrowthEngine.Name = "lblGrowthEngine";
            this.lblGrowthEngine.Size = new System.Drawing.Size(80, 13);
            this.lblGrowthEngine.TabIndex = 0;
            this.lblGrowthEngine.Text = "Growth Engine:";
            // 
            // mnsMainControl
            // 
            this.mnsMainControl.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMainControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduleToolStripMenuItem,
            this.sessionToolStripMenuItem});
            this.mnsMainControl.Location = new System.Drawing.Point(0, 0);
            this.mnsMainControl.Name = "mnsMainControl";
            this.mnsMainControl.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnsMainControl.Size = new System.Drawing.Size(600, 24);
            this.mnsMainControl.TabIndex = 6;
            this.mnsMainControl.Text = "Module";
            // 
            // moduleToolStripMenuItem
            // 
            this.moduleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.growthEngineToolStripMenuItem,
            this.rainPredictorToolStripMenuItem,
            this.stockTrackAndAnalyzerToolStripMenuItem,
            this.mediaAndRecoveryUnitToolStripMenuItem});
            this.moduleToolStripMenuItem.Name = "moduleToolStripMenuItem";
            this.moduleToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.moduleToolStripMenuItem.Text = "Module";
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sessionToolStripMenuItem.Text = "Session";
            // 
            // growthEngineToolStripMenuItem
            // 
            this.growthEngineToolStripMenuItem.Name = "growthEngineToolStripMenuItem";
            this.growthEngineToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.growthEngineToolStripMenuItem.Text = "Growth Engine";
            // 
            // rainPredictorToolStripMenuItem
            // 
            this.rainPredictorToolStripMenuItem.Name = "rainPredictorToolStripMenuItem";
            this.rainPredictorToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.rainPredictorToolStripMenuItem.Text = "Rain Predictor";
            // 
            // stockTrackAndAnalyzerToolStripMenuItem
            // 
            this.stockTrackAndAnalyzerToolStripMenuItem.Name = "stockTrackAndAnalyzerToolStripMenuItem";
            this.stockTrackAndAnalyzerToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.stockTrackAndAnalyzerToolStripMenuItem.Text = "Stock Track and Analyzer";
            this.stockTrackAndAnalyzerToolStripMenuItem.Click += new System.EventHandler(this.stockTrackAndAnalyzerToolStripMenuItem_Click);
            // 
            // mediaAndRecoveryUnitToolStripMenuItem
            // 
            this.mediaAndRecoveryUnitToolStripMenuItem.Name = "mediaAndRecoveryUnitToolStripMenuItem";
            this.mediaAndRecoveryUnitToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.mediaAndRecoveryUnitToolStripMenuItem.Text = "Media and Recovery Unit";
            // 
            // frmMain_Control_Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 463);
            this.Controls.Add(this.mnsMainControl);
            this.Controls.Add(this.rtxtAccessManager);
            this.Controls.Add(this.grbModuleAccess);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain_Control_Hub";
            this.Text = "Main_Control_Hub";
            this.grbModuleAccess.ResumeLayout(false);
            this.grbModuleAccess.PerformLayout();
            this.mnsMainControl.ResumeLayout(false);
            this.mnsMainControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtAccessManager;
        private System.Windows.Forms.GroupBox grbModuleAccess;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblRecovery;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblRainPredictor;
        private System.Windows.Forms.Label lblGrowthEngine;
        private System.Windows.Forms.MenuStrip mnsMainControl;
        private System.Windows.Forms.ToolStripMenuItem moduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem growthEngineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rainPredictorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockTrackAndAnalyzerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaAndRecoveryUnitToolStripMenuItem;
    }
}