namespace INF164_Homework_Assignment_1_Group44
{
    partial class StockTrack
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
            this.mnsStock = new System.Windows.Forms.MenuStrip();
            this.moduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.lblStock = new System.Windows.Forms.Label();
            this.grbStock = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.lbl2019 = new System.Windows.Forms.Label();
            this.lbl2020 = new System.Windows.Forms.Label();
            this.lbl2021 = new System.Windows.Forms.Label();
            this.lbl2022 = new System.Windows.Forms.Label();
            this.lbl2023 = new System.Windows.Forms.Label();
            this.lbl2024 = new System.Windows.Forms.Label();
            this.lbl2025 = new System.Windows.Forms.Label();
            this.nud2019Stock = new System.Windows.Forms.NumericUpDown();
            this.nud2020Stock = new System.Windows.Forms.NumericUpDown();
            this.nud2021Stock = new System.Windows.Forms.NumericUpDown();
            this.nud2022Stock = new System.Windows.Forms.NumericUpDown();
            this.nud2023Stock = new System.Windows.Forms.NumericUpDown();
            this.nud2024Stock = new System.Windows.Forms.NumericUpDown();
            this.nud2025Stock = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.mnsStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.grbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2019Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2020Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2021Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2022Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2023Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2024Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2025Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsStock
            // 
            this.mnsStock.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduleToolStripMenuItem,
            this.sessionToolStripMenuItem});
            this.mnsStock.Location = new System.Drawing.Point(0, 0);
            this.mnsStock.Name = "mnsStock";
            this.mnsStock.Size = new System.Drawing.Size(975, 28);
            this.mnsStock.TabIndex = 8;
            this.mnsStock.Text = "Module";
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
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(0, 31);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.Size = new System.Drawing.Size(971, 150);
            this.dgvStock.TabIndex = 9;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(13, 188);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(157, 16);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Loaded Baseline Stocks:";
            // 
            // grbStock
            // 
            this.grbStock.Controls.Add(this.btnAdd);
            this.grbStock.Controls.Add(this.nud2025Stock);
            this.grbStock.Controls.Add(this.nud2024Stock);
            this.grbStock.Controls.Add(this.nud2023Stock);
            this.grbStock.Controls.Add(this.nud2022Stock);
            this.grbStock.Controls.Add(this.nud2021Stock);
            this.grbStock.Controls.Add(this.nud2020Stock);
            this.grbStock.Controls.Add(this.nud2019Stock);
            this.grbStock.Controls.Add(this.lbl2025);
            this.grbStock.Controls.Add(this.lbl2024);
            this.grbStock.Controls.Add(this.lbl2023);
            this.grbStock.Controls.Add(this.lbl2022);
            this.grbStock.Controls.Add(this.lbl2021);
            this.grbStock.Controls.Add(this.lbl2020);
            this.grbStock.Controls.Add(this.lbl2019);
            this.grbStock.Controls.Add(this.txtStockName);
            this.grbStock.Controls.Add(this.lblName);
            this.grbStock.Location = new System.Drawing.Point(16, 220);
            this.grbStock.Name = "grbStock";
            this.grbStock.Size = new System.Drawing.Size(387, 328);
            this.grbStock.TabIndex = 11;
            this.grbStock.TabStop = false;
            this.grbStock.Text = "Add/Update Stock(2019-2025)";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 16);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Stock Name:";
            // 
            // txtStockName
            // 
            this.txtStockName.Location = new System.Drawing.Point(173, 44);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(100, 22);
            this.txtStockName.TabIndex = 12;
            // 
            // lbl2019
            // 
            this.lbl2019.AutoSize = true;
            this.lbl2019.Location = new System.Drawing.Point(6, 95);
            this.lbl2019.Name = "lbl2019";
            this.lbl2019.Size = new System.Drawing.Size(35, 16);
            this.lbl2019.TabIndex = 12;
            this.lbl2019.Text = "2019";
            // 
            // lbl2020
            // 
            this.lbl2020.AutoSize = true;
            this.lbl2020.Location = new System.Drawing.Point(6, 129);
            this.lbl2020.Name = "lbl2020";
            this.lbl2020.Size = new System.Drawing.Size(35, 16);
            this.lbl2020.TabIndex = 13;
            this.lbl2020.Text = "2020";
            // 
            // lbl2021
            // 
            this.lbl2021.AutoSize = true;
            this.lbl2021.Location = new System.Drawing.Point(6, 161);
            this.lbl2021.Name = "lbl2021";
            this.lbl2021.Size = new System.Drawing.Size(35, 16);
            this.lbl2021.TabIndex = 14;
            this.lbl2021.Text = "2021";
            // 
            // lbl2022
            // 
            this.lbl2022.AutoSize = true;
            this.lbl2022.Location = new System.Drawing.Point(6, 193);
            this.lbl2022.Name = "lbl2022";
            this.lbl2022.Size = new System.Drawing.Size(35, 16);
            this.lbl2022.TabIndex = 15;
            this.lbl2022.Text = "2022";
            // 
            // lbl2023
            // 
            this.lbl2023.AutoSize = true;
            this.lbl2023.Location = new System.Drawing.Point(6, 221);
            this.lbl2023.Name = "lbl2023";
            this.lbl2023.Size = new System.Drawing.Size(35, 16);
            this.lbl2023.TabIndex = 16;
            this.lbl2023.Text = "2023";
            // 
            // lbl2024
            // 
            this.lbl2024.AutoSize = true;
            this.lbl2024.Location = new System.Drawing.Point(6, 254);
            this.lbl2024.Name = "lbl2024";
            this.lbl2024.Size = new System.Drawing.Size(35, 16);
            this.lbl2024.TabIndex = 17;
            this.lbl2024.Text = "2024";
            // 
            // lbl2025
            // 
            this.lbl2025.AutoSize = true;
            this.lbl2025.Location = new System.Drawing.Point(6, 287);
            this.lbl2025.Name = "lbl2025";
            this.lbl2025.Size = new System.Drawing.Size(35, 16);
            this.lbl2025.TabIndex = 18;
            this.lbl2025.Text = "2025";
            // 
            // nud2019Stock
            // 
            this.nud2019Stock.Location = new System.Drawing.Point(86, 95);
            this.nud2019Stock.Name = "nud2019Stock";
            this.nud2019Stock.Size = new System.Drawing.Size(120, 22);
            this.nud2019Stock.TabIndex = 19;
            // 
            // nud2020Stock
            // 
            this.nud2020Stock.Location = new System.Drawing.Point(86, 122);
            this.nud2020Stock.Name = "nud2020Stock";
            this.nud2020Stock.Size = new System.Drawing.Size(120, 22);
            this.nud2020Stock.TabIndex = 20;
            // 
            // nud2021Stock
            // 
            this.nud2021Stock.Location = new System.Drawing.Point(86, 154);
            this.nud2021Stock.Name = "nud2021Stock";
            this.nud2021Stock.Size = new System.Drawing.Size(120, 22);
            this.nud2021Stock.TabIndex = 21;
            // 
            // nud2022Stock
            // 
            this.nud2022Stock.Location = new System.Drawing.Point(86, 182);
            this.nud2022Stock.Name = "nud2022Stock";
            this.nud2022Stock.Size = new System.Drawing.Size(120, 22);
            this.nud2022Stock.TabIndex = 22;
            // 
            // nud2023Stock
            // 
            this.nud2023Stock.Location = new System.Drawing.Point(86, 221);
            this.nud2023Stock.Name = "nud2023Stock";
            this.nud2023Stock.Size = new System.Drawing.Size(120, 22);
            this.nud2023Stock.TabIndex = 23;
            // 
            // nud2024Stock
            // 
            this.nud2024Stock.Location = new System.Drawing.Point(86, 254);
            this.nud2024Stock.Name = "nud2024Stock";
            this.nud2024Stock.Size = new System.Drawing.Size(120, 22);
            this.nud2024Stock.TabIndex = 24;
            // 
            // nud2025Stock
            // 
            this.nud2025Stock.Location = new System.Drawing.Point(86, 283);
            this.nud2025Stock.Name = "nud2025Stock";
            this.nud2025Stock.Size = new System.Drawing.Size(120, 22);
            this.nud2025Stock.TabIndex = 25;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(265, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add/Replace";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(631, 229);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(124, 23);
            this.btnExport.TabIndex = 26;
            this.btnExport.Text = "Export Snapshot";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(797, 229);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(174, 23);
            this.btnAnalyze.TabIndex = 27;
            this.btnAnalyze.Text = "Analyze Selected";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(409, 229);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(178, 23);
            this.btnRemove.TabIndex = 28;
            this.btnRemove.Text = "Remove selected stock";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // StockTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 560);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.grbStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.mnsStock);
            this.Name = "StockTrack";
            this.Text = "StockTrack";
            this.mnsStock.ResumeLayout(false);
            this.mnsStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.grbStock.ResumeLayout(false);
            this.grbStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2019Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2020Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2021Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2022Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2023Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2024Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2025Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsStock;
        private System.Windows.Forms.ToolStripMenuItem moduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.GroupBox grbStock;
        private System.Windows.Forms.NumericUpDown nud2025Stock;
        private System.Windows.Forms.NumericUpDown nud2024Stock;
        private System.Windows.Forms.NumericUpDown nud2023Stock;
        private System.Windows.Forms.NumericUpDown nud2022Stock;
        private System.Windows.Forms.NumericUpDown nud2021Stock;
        private System.Windows.Forms.NumericUpDown nud2020Stock;
        private System.Windows.Forms.NumericUpDown nud2019Stock;
        private System.Windows.Forms.Label lbl2025;
        private System.Windows.Forms.Label lbl2024;
        private System.Windows.Forms.Label lbl2023;
        private System.Windows.Forms.Label lbl2022;
        private System.Windows.Forms.Label lbl2021;
        private System.Windows.Forms.Label lbl2020;
        private System.Windows.Forms.Label lbl2019;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnRemove;
    }
}