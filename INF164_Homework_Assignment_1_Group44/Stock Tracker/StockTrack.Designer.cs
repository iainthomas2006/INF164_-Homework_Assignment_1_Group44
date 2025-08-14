namespace INF164_Homework_Assignment_1_Group44
{
    partial class frmStockTrack
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
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm2019 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm2020 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm2021 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm2022 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm2023 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm2024 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm2025 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStock = new System.Windows.Forms.Label();
            this.grbStock = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nud2025Stock = new System.Windows.Forms.NumericUpDown();
            this.nud2024Stock = new System.Windows.Forms.NumericUpDown();
            this.nud2023Stock = new System.Windows.Forms.NumericUpDown();
            this.nud2022Stock = new System.Windows.Forms.NumericUpDown();
            this.nud2021Stock = new System.Windows.Forms.NumericUpDown();
            this.nud2020Stock = new System.Windows.Forms.NumericUpDown();
            this.nud2019Stock = new System.Windows.Forms.NumericUpDown();
            this.lbl2025 = new System.Windows.Forms.Label();
            this.lbl2024 = new System.Windows.Forms.Label();
            this.lbl2023 = new System.Windows.Forms.Label();
            this.lbl2022 = new System.Windows.Forms.Label();
            this.lbl2021 = new System.Windows.Forms.Label();
            this.lbl2020 = new System.Windows.Forms.Label();
            this.lbl2019 = new System.Windows.Forms.Label();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.mnsStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.grbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2025Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2024Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2023Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2022Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2021Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2020Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2019Stock)).BeginInit();
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
            this.mnsStock.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnsStock.Size = new System.Drawing.Size(1407, 28);
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
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToResizeColumns = false;
            this.dgvStock.AllowUserToResizeRows = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clm2019,
            this.clm2020,
            this.clm2021,
            this.clm2022,
            this.clm2023,
            this.clm2024,
            this.clm2025});
            this.dgvStock.Location = new System.Drawing.Point(15, 31);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.Size = new System.Drawing.Size(1380, 193);
            this.dgvStock.TabIndex = 9;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.MinimumWidth = 6;
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 125;
            // 
            // clm2019
            // 
            this.clm2019.HeaderText = "2019";
            this.clm2019.MinimumWidth = 6;
            this.clm2019.Name = "clm2019";
            this.clm2019.ReadOnly = true;
            this.clm2019.Width = 125;
            // 
            // clm2020
            // 
            this.clm2020.HeaderText = "2020";
            this.clm2020.MinimumWidth = 6;
            this.clm2020.Name = "clm2020";
            this.clm2020.ReadOnly = true;
            this.clm2020.Width = 125;
            // 
            // clm2021
            // 
            this.clm2021.HeaderText = "2021";
            this.clm2021.MinimumWidth = 6;
            this.clm2021.Name = "clm2021";
            this.clm2021.ReadOnly = true;
            this.clm2021.Width = 125;
            // 
            // clm2022
            // 
            this.clm2022.HeaderText = "2022";
            this.clm2022.MinimumWidth = 6;
            this.clm2022.Name = "clm2022";
            this.clm2022.ReadOnly = true;
            this.clm2022.Width = 125;
            // 
            // clm2023
            // 
            this.clm2023.HeaderText = "2023";
            this.clm2023.MinimumWidth = 6;
            this.clm2023.Name = "clm2023";
            this.clm2023.ReadOnly = true;
            this.clm2023.Width = 125;
            // 
            // clm2024
            // 
            this.clm2024.HeaderText = "2024";
            this.clm2024.MinimumWidth = 6;
            this.clm2024.Name = "clm2024";
            this.clm2024.ReadOnly = true;
            this.clm2024.Width = 125;
            // 
            // clm2025
            // 
            this.clm2025.HeaderText = "2025";
            this.clm2025.MinimumWidth = 6;
            this.clm2025.Name = "clm2025";
            this.clm2025.ReadOnly = true;
            this.clm2025.Width = 125;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(20, 229);
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
            this.grbStock.Location = new System.Drawing.Point(15, 268);
            this.grbStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbStock.Name = "grbStock";
            this.grbStock.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbStock.Size = new System.Drawing.Size(387, 327);
            this.grbStock.TabIndex = 11;
            this.grbStock.TabStop = false;
            this.grbStock.Text = "Add/Update Stock(2019-2025)";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(265, 299);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add/Replace";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nud2025Stock
            // 
            this.nud2025Stock.Location = new System.Drawing.Point(85, 283);
            this.nud2025Stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud2025Stock.Name = "nud2025Stock";
            this.nud2025Stock.Size = new System.Drawing.Size(120, 22);
            this.nud2025Stock.TabIndex = 25;
            // 
            // nud2024Stock
            // 
            this.nud2024Stock.Location = new System.Drawing.Point(85, 254);
            this.nud2024Stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud2024Stock.Name = "nud2024Stock";
            this.nud2024Stock.Size = new System.Drawing.Size(120, 22);
            this.nud2024Stock.TabIndex = 24;
            // 
            // nud2023Stock
            // 
            this.nud2023Stock.Location = new System.Drawing.Point(85, 222);
            this.nud2023Stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud2023Stock.Name = "nud2023Stock";
            this.nud2023Stock.Size = new System.Drawing.Size(120, 22);
            this.nud2023Stock.TabIndex = 23;
            // 
            // nud2022Stock
            // 
            this.nud2022Stock.Location = new System.Drawing.Point(85, 182);
            this.nud2022Stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud2022Stock.Name = "nud2022Stock";
            this.nud2022Stock.Size = new System.Drawing.Size(120, 22);
            this.nud2022Stock.TabIndex = 22;
            // 
            // nud2021Stock
            // 
            this.nud2021Stock.Location = new System.Drawing.Point(85, 154);
            this.nud2021Stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud2021Stock.Name = "nud2021Stock";
            this.nud2021Stock.Size = new System.Drawing.Size(120, 22);
            this.nud2021Stock.TabIndex = 21;
            // 
            // nud2020Stock
            // 
            this.nud2020Stock.Location = new System.Drawing.Point(85, 122);
            this.nud2020Stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud2020Stock.Name = "nud2020Stock";
            this.nud2020Stock.Size = new System.Drawing.Size(120, 22);
            this.nud2020Stock.TabIndex = 20;
            // 
            // nud2019Stock
            // 
            this.nud2019Stock.Location = new System.Drawing.Point(85, 95);
            this.nud2019Stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud2019Stock.Name = "nud2019Stock";
            this.nud2019Stock.Size = new System.Drawing.Size(120, 22);
            this.nud2019Stock.TabIndex = 19;
            // 
            // lbl2025
            // 
            this.lbl2025.AutoSize = true;
            this.lbl2025.Location = new System.Drawing.Point(5, 287);
            this.lbl2025.Name = "lbl2025";
            this.lbl2025.Size = new System.Drawing.Size(35, 16);
            this.lbl2025.TabIndex = 18;
            this.lbl2025.Text = "2025";
            // 
            // lbl2024
            // 
            this.lbl2024.AutoSize = true;
            this.lbl2024.Location = new System.Drawing.Point(5, 254);
            this.lbl2024.Name = "lbl2024";
            this.lbl2024.Size = new System.Drawing.Size(35, 16);
            this.lbl2024.TabIndex = 17;
            this.lbl2024.Text = "2024";
            // 
            // lbl2023
            // 
            this.lbl2023.AutoSize = true;
            this.lbl2023.Location = new System.Drawing.Point(5, 222);
            this.lbl2023.Name = "lbl2023";
            this.lbl2023.Size = new System.Drawing.Size(35, 16);
            this.lbl2023.TabIndex = 16;
            this.lbl2023.Text = "2023";
            // 
            // lbl2022
            // 
            this.lbl2022.AutoSize = true;
            this.lbl2022.Location = new System.Drawing.Point(5, 193);
            this.lbl2022.Name = "lbl2022";
            this.lbl2022.Size = new System.Drawing.Size(35, 16);
            this.lbl2022.TabIndex = 15;
            this.lbl2022.Text = "2022";
            // 
            // lbl2021
            // 
            this.lbl2021.AutoSize = true;
            this.lbl2021.Location = new System.Drawing.Point(5, 161);
            this.lbl2021.Name = "lbl2021";
            this.lbl2021.Size = new System.Drawing.Size(35, 16);
            this.lbl2021.TabIndex = 14;
            this.lbl2021.Text = "2021";
            // 
            // lbl2020
            // 
            this.lbl2020.AutoSize = true;
            this.lbl2020.Location = new System.Drawing.Point(5, 129);
            this.lbl2020.Name = "lbl2020";
            this.lbl2020.Size = new System.Drawing.Size(35, 16);
            this.lbl2020.TabIndex = 13;
            this.lbl2020.Text = "2020";
            // 
            // lbl2019
            // 
            this.lbl2019.AutoSize = true;
            this.lbl2019.Location = new System.Drawing.Point(5, 95);
            this.lbl2019.Name = "lbl2019";
            this.lbl2019.Size = new System.Drawing.Size(35, 16);
            this.lbl2019.TabIndex = 12;
            this.lbl2019.Text = "2019";
            // 
            // txtStockName
            // 
            this.txtStockName.Location = new System.Drawing.Point(104, 44);
            this.txtStockName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(100, 22);
            this.txtStockName.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 16);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Stock Name:";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1059, 229);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(124, 31);
            this.btnExport.TabIndex = 26;
            this.btnExport.Text = "Export Snapshot";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(1222, 229);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(173, 31);
            this.btnAnalyze.TabIndex = 27;
            this.btnAnalyze.Text = "Analyze Selected";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(832, 229);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(179, 31);
            this.btnRemove.TabIndex = 28;
            this.btnRemove.Text = "Remove selected stock";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmStockTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 609);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.grbStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.mnsStock);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmStockTrack";
            this.Text = "StockTrack";
            this.Load += new System.EventHandler(this.frmStockTrack_Load);
            this.mnsStock.ResumeLayout(false);
            this.mnsStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.grbStock.ResumeLayout(false);
            this.grbStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2025Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2024Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2023Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2022Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2021Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2020Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2019Stock)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm2019;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm2020;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm2021;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm2022;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm2023;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm2024;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm2025;
    }
}