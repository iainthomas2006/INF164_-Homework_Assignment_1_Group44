using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace INF164_Homework_Assignment_1_Group44
{
    public partial class frmStockTrack : Form
    {
        public frmStockTrack()
        {
            InitializeComponent();
        }

        double[,] stockAmounts =
            { { 10.0, 15.00, 20.00 },
            { 12.00, 14.00, 18.00 },
            { 14.00, 16.00, 15.00 },
            { 17.00, 18.00, 16.00 },
            { 20.00, 19.00, 17.00 },
            { 22.00, 21.00, 19.00 },
            { 25.00, 24.00, 22.00 } };
        string[] stockTypes = { "NeoHealth", "BoVita", "CarePlus" };

        string nameOfStock;
        int foundIndex = 100;

        DataGridViewRow selectedRow;

        private void frmStockTrack_Load(object sender, EventArgs e)
        {
            dgvStock.Rows.Add(3);

            for (int i = 0; i < 3; i++)
            {
                dgvStock[0, i].Value = stockTypes[i];
            }

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dgvStock[i + 1, j].Value = stockAmounts[i, j];
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            nameOfStock = txtStockName.Text;

            bool found = CheckForStock(nameOfStock);

            double[] stockInUse = {
                (double)nud2019Stock.Value,
                (double) nud2020Stock.Value,
                (double) nud2021Stock.Value,
                (double) nud2022Stock.Value,
                (double) nud2023Stock.Value,
                (double) nud2024Stock.Value,
                (double) nud2025Stock.Value};

            if (found == true)
            {
                for (int i = 0; i < 7; i++)
                {
                    stockAmounts[i, foundIndex] = stockInUse[i];
                    UpdateTable(foundIndex);
                }

            }
            else
            {
                AddToTable(stockInUse);
            }
        }

        private bool CheckForStock(string nameOfStock)
        {
            bool inTable = false;

            for (int i = 0; i < 3; i++)
            {
                if (txtStockName.Text == stockTypes[i])
                {
                    inTable = true;
                    foundIndex = i;
                }
            }
            return inTable;
        }

        private void UpdateTable(int foundIndex)
        {
            for (int i = 0; i < 7; i++)
            {
                dgvStock[i + 1, foundIndex].Value = stockAmounts[i, foundIndex];
            }
        }

        private void AddToTable(double[] stockInUse)
        {
            dgvStock.Rows.Add();
            int rowNum = dgvStock.Rows.Count - 1;

            dgvStock[0, rowNum].Value = nameOfStock;

            for (int i = 0; i < 7; i++)
            {
                dgvStock[i + 1, rowNum].Value = stockInUse[i];
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            double[] selectedStock = new double[7];
            double value;
            if (dgvStock.SelectedRows.Count > 0)
            {
                selectedRow = dgvStock.SelectedRows[0];
                for (int i = 0; i < 7; i++)
                {
                    double.TryParse(selectedRow.Cells[i + 1].Value?.ToString(), out value);
                    selectedStock[i] = value;
                }

                double PercentChange = CalculatePercentChange(selectedStock);
                double CAGR = CalculateCAGR(selectedStock);

                string message = "CarePlus" + "\n" +
                    "Total Change (2019-20025): " + PercentChange + "%" + "\n" +
                    "CAGR (~annualized): " + CAGR + "%" + "\n" +
                    "\n" + "Tip: green cells = YoY up, red cells = YoY down";
                string title = "Trend Analysis";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                ChangeColours(selectedStock);

            }
            else
            {
                MessageBox.Show("Please select a row");
            }


        }

        private double CalculatePercentChange(double[] selectedStock)
        {
            double change;
            double start = selectedStock[0];
            double end = selectedStock[6];

            change = (end - start) / start * 100;

            return change;
        }

        private double CalculateCAGR(double[] selectedStock)
        {
            double cagr;
            double start = selectedStock[0];
            double end = selectedStock[6];

            cagr = Math.Round(((Math.Pow((end / start), 1.0 / 6) - 1) * 100), 2);

            return cagr;
        }

        private void ChangeColours(double[] selectedStock)
        {
            for (int i = 1; i < 7; i++)
            {
                if (selectedStock[i] > selectedStock[i - 1])
                {
                    dgvStock.Rows[selectedRow.Index].Cells[i + 1].Style.BackColor = Color.Green;
                }
                else
                {
                    dgvStock.Rows[selectedRow.Index].Cells[i + 1].Style.BackColor = Color.Red;
                }
            }
            dgvStock.Rows[selectedRow.Index].Selected = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("StockSnapShot.csv");

            for (int i = 0; i < dgvStock.Columns.Count; i++)
            {
                writer.Write(dgvStock.Columns[i].HeaderText);
                if (i < dgvStock.Columns.Count - 1)
                {
                    writer.Write(',');
                }
            }
            writer.WriteLine();

            for (int i = 0; i < dgvStock.Rows.Count; i++)
            {
                for (int j = 0; j < dgvStock.Columns.Count; j++)
                {
                    writer.Write(dgvStock[j, i].Value?.ToString());
                    if (j < dgvStock.Columns.Count - 1)
                    {
                        writer.Write(',');
                    }
                }
                writer.WriteLine();
            }

            writer.Close();
            MessageBox.Show("Exported to " + Path.GetFullPath("StockSnapShot.csv"));
            lblStock.Text = "Snapshot exported: " + Path.GetFullPath("StockSnapShot.csv");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count > 0)
            {
                selectedRow = dgvStock.SelectedRows[0];
                string message = "Remove '" + dgvStock[0,selectedRow.Index].Value + "'?";
                string title = "Confirm";
                DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dgvStock.Rows.RemoveAt(dgvStock.SelectedRows[0].Index);
                }
            } else
            {
                MessageBox.Show("No row selected");
            }
        }
    }
}
