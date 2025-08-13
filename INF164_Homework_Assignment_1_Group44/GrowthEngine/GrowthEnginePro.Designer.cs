namespace INF164_Homework_Assignment_1_Group44
{
    partial class frmGrowthEnginePro
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
            this.mnsGrowth = new System.Windows.Forms.MenuStrip();
            this.moduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpInvestment = new System.Windows.Forms.GroupBox();
            this.nudMonths = new System.Windows.Forms.NumericUpDown();
            this.nudTarget = new System.Windows.Forms.NumericUpDown();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.nudBalance = new System.Windows.Forms.NumericUpDown();
            this.lblBalance = new System.Windows.Forms.Label();
            this.grpGrowth = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.radCompound = new System.Windows.Forms.RadioButton();
            this.radFlat = new System.Windows.Forms.RadioButton();
            this.rtxtInvestment = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.mnsGrowth.SuspendLayout();
            this.grpInvestment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).BeginInit();
            this.grpGrowth.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsGrowth
            // 
            this.mnsGrowth.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsGrowth.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduleToolStripMenuItem,
            this.sessionToolStripMenuItem});
            this.mnsGrowth.Location = new System.Drawing.Point(0, 0);
            this.mnsGrowth.Name = "mnsGrowth";
            this.mnsGrowth.Size = new System.Drawing.Size(1028, 28);
            this.mnsGrowth.TabIndex = 7;
            this.mnsGrowth.Text = "Module";
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
            // grpInvestment
            // 
            this.grpInvestment.Controls.Add(this.nudMonths);
            this.grpInvestment.Controls.Add(this.nudTarget);
            this.grpInvestment.Controls.Add(this.lblResult);
            this.grpInvestment.Controls.Add(this.lblMonth);
            this.grpInvestment.Controls.Add(this.lblTarget);
            this.grpInvestment.Controls.Add(this.nudBalance);
            this.grpInvestment.Controls.Add(this.lblBalance);
            this.grpInvestment.Location = new System.Drawing.Point(13, 32);
            this.grpInvestment.Name = "grpInvestment";
            this.grpInvestment.Size = new System.Drawing.Size(304, 303);
            this.grpInvestment.TabIndex = 8;
            this.grpInvestment.TabStop = false;
            this.grpInvestment.Text = "Investment Parameters";
            // 
            // nudMonths
            // 
            this.nudMonths.Location = new System.Drawing.Point(47, 197);
            this.nudMonths.Name = "nudMonths";
            this.nudMonths.Size = new System.Drawing.Size(120, 22);
            this.nudMonths.TabIndex = 6;
            // 
            // nudTarget
            // 
            this.nudTarget.Location = new System.Drawing.Point(47, 130);
            this.nudTarget.Name = "nudTarget";
            this.nudTarget.Size = new System.Drawing.Size(120, 22);
            this.nudTarget.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(139, 261);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(48, 16);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(44, 178);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(139, 16);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "Months to Reach Goal";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(44, 111);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(103, 16);
            this.lblTarget.TabIndex = 2;
            this.lblTarget.Text = "Target Balance:";
            // 
            // nudBalance
            // 
            this.nudBalance.Location = new System.Drawing.Point(47, 59);
            this.nudBalance.Name = "nudBalance";
            this.nudBalance.Size = new System.Drawing.Size(120, 22);
            this.nudBalance.TabIndex = 1;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(44, 39);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(105, 16);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Current Balance:";
            // 
            // grpGrowth
            // 
            this.grpGrowth.Controls.Add(this.btnCalculate);
            this.grpGrowth.Controls.Add(this.radCompound);
            this.grpGrowth.Controls.Add(this.radFlat);
            this.grpGrowth.Location = new System.Drawing.Point(13, 341);
            this.grpGrowth.Name = "grpGrowth";
            this.grpGrowth.Size = new System.Drawing.Size(304, 185);
            this.grpGrowth.TabIndex = 9;
            this.grpGrowth.TabStop = false;
            this.grpGrowth.Text = "GrowthType";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(73, 139);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(133, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate Growth";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // radCompound
            // 
            this.radCompound.AutoSize = true;
            this.radCompound.Location = new System.Drawing.Point(47, 99);
            this.radCompound.Name = "radCompound";
            this.radCompound.Size = new System.Drawing.Size(159, 20);
            this.radCompound.TabIndex = 1;
            this.radCompound.TabStop = true;
            this.radCompound.Text = "Compound Balance%";
            this.radCompound.UseVisualStyleBackColor = true;
            // 
            // radFlat
            // 
            this.radFlat.AutoSize = true;
            this.radFlat.Location = new System.Drawing.Point(47, 52);
            this.radFlat.Name = "radFlat";
            this.radFlat.Size = new System.Drawing.Size(106, 20);
            this.radFlat.TabIndex = 0;
            this.radFlat.TabStop = true;
            this.radFlat.Text = "Flat Growth%";
            this.radFlat.UseVisualStyleBackColor = true;
            // 
            // rtxtInvestment
            // 
            this.rtxtInvestment.Location = new System.Drawing.Point(391, 41);
            this.rtxtInvestment.Name = "rtxtInvestment";
            this.rtxtInvestment.Size = new System.Drawing.Size(407, 485);
            this.rtxtInvestment.TabIndex = 10;
            this.rtxtInvestment.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(504, 554);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmGrowthEnginePro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 652);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtxtInvestment);
            this.Controls.Add(this.grpGrowth);
            this.Controls.Add(this.grpInvestment);
            this.Controls.Add(this.mnsGrowth);
            this.Name = "frmGrowthEnginePro";
            this.Text = "GrowthEnginePro";
            this.mnsGrowth.ResumeLayout(false);
            this.mnsGrowth.PerformLayout();
            this.grpInvestment.ResumeLayout(false);
            this.grpInvestment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).EndInit();
            this.grpGrowth.ResumeLayout(false);
            this.grpGrowth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsGrowth;
        private System.Windows.Forms.ToolStripMenuItem moduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpInvestment;
        private System.Windows.Forms.NumericUpDown nudMonths;
        private System.Windows.Forms.NumericUpDown nudTarget;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.NumericUpDown nudBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.GroupBox grpGrowth;
        private System.Windows.Forms.RichTextBox rtxtInvestment;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton radCompound;
        private System.Windows.Forms.RadioButton radFlat;
        private System.Windows.Forms.Button btnSave;
    }
}