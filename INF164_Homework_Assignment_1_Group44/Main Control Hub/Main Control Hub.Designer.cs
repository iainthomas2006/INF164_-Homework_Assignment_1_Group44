namespace INF164_Homework_Assignment_1_Group44
{
    partial class Main_Control_Hub
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
            this.grbModuleAccess.SuspendLayout();
            this.mnsMainControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtAccessManager
            // 
            this.rtxtAccessManager.Location = new System.Drawing.Point(71, 261);
            this.rtxtAccessManager.Name = "rtxtAccessManager";
            this.rtxtAccessManager.Size = new System.Drawing.Size(659, 209);
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
            this.grbModuleAccess.Location = new System.Drawing.Point(71, 48);
            this.grbModuleAccess.Name = "grbModuleAccess";
            this.grbModuleAccess.Size = new System.Drawing.Size(659, 207);
            this.grbModuleAccess.TabIndex = 3;
            this.grbModuleAccess.TabStop = false;
            this.grbModuleAccess.Text = "Module Access Manager";
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(166, 176);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(134, 16);
            this.lblSave.TabIndex = 4;
            this.lblSave.Text = "Save Session Status:";
            // 
            // lblRecovery
            // 
            this.lblRecovery.AutoSize = true;
            this.lblRecovery.Location = new System.Drawing.Point(166, 139);
            this.lblRecovery.Name = "lblRecovery";
            this.lblRecovery.Size = new System.Drawing.Size(136, 16);
            this.lblRecovery.TabIndex = 3;
            this.lblRecovery.Text = "Media Recovery Unit:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(166, 110);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(163, 16);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Stock Track and Analyzer:";
            // 
            // lblRainPredictor
            // 
            this.lblRainPredictor.AutoSize = true;
            this.lblRainPredictor.Location = new System.Drawing.Point(166, 75);
            this.lblRainPredictor.Name = "lblRainPredictor";
            this.lblRainPredictor.Size = new System.Drawing.Size(92, 16);
            this.lblRainPredictor.TabIndex = 1;
            this.lblRainPredictor.Text = "RainPredictor:";
            // 
            // lblGrowthEngine
            // 
            this.lblGrowthEngine.AutoSize = true;
            this.lblGrowthEngine.Location = new System.Drawing.Point(166, 43);
            this.lblGrowthEngine.Name = "lblGrowthEngine";
            this.lblGrowthEngine.Size = new System.Drawing.Size(96, 16);
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
            this.mnsMainControl.Size = new System.Drawing.Size(800, 28);
            this.mnsMainControl.TabIndex = 6;
            this.mnsMainControl.Text = "Module";
            // 
            // moduleToolStripMenuItem
            // 
            this.moduleToolStripMenuItem.Name = "moduleToolStripMenuItem";
            this.moduleToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.moduleToolStripMenuItem.Text = "Module";
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
            this.sessionToolStripMenuItem.Text = "Session";
            // 
            // Main_Control_Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.mnsMainControl);
            this.Controls.Add(this.rtxtAccessManager);
            this.Controls.Add(this.grbModuleAccess);
            this.Name = "Main_Control_Hub";
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
    }
}