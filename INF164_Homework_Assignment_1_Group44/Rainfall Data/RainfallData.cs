using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164_Homework_Assignment_1_Group44
{
    public partial class frmRainfallData : Form
    {
        public frmRainfallData()
        {
            InitializeComponent();
        }
        int AnomolyCount;
        double rainvalue;
        double[,] Rain = new double[10, 10];
        int AnomolySummary, anomolypercentage;
        int highcount, lowcount, inboundcount, generalcount;
        double HighAvg, LowAvg, InboundAvg, GeneralAvg, HighestValue, LowestValue;
        bool colorAnomolies;
        StreamWriter SummaryReport;
        string fileName;

        private void btnClose_Click(object sender, EventArgs e)
        {

            frmMain_Control_Hub main_Control_Hub = new frmMain_Control_Hub();
            main_Control_Hub.Show();
            this.Close();

        }//Closes this form and opens main control hub
        private void htsmiMainControl_Click(object sender, EventArgs e)
        {
            frmMain_Control_Hub main_Control_Hub = new frmMain_Control_Hub();
            this.Close(); 
            main_Control_Hub.Show();
        }//Navigation to Main Control Hub
        private void btnAnalyze_Click(object sender, EventArgs e)
        {

            colorAnomolies = true;
            ResetVariables();
            LoopingAnomoly();
            AnomolyText();

        }//Analyzes extreme values in the datagrid

        private void btnReset_Click(object sender, EventArgs e)
        {
            colorAnomolies = false;
            ResetVariables();
            SetDataGrid();
            generateColums();
            LoopingAnomoly();
            AnomolyText();
            for (int i = 0; i < Rain.GetLength(0); i++)
            {

                for (int j = 0; j < Rain.GetLength(1); j++)
                {
                    dgvRainfall.Rows[j].Cells[i].Style.BackColor = Color.White;
                }
            }
        }//Resets all the squares and reloads the datagrid

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            colorAnomolies = false;
            ResetVariables();
            SetDataGrid();
            generateColums();
            LoopingAnomoly();
            AnomolyText();
        }//Generates the Table and allocates array values
        private void SetDataGrid()
        {
            dgvRainfall.ColumnCount = 10;
            dgvRainfall.RowCount = 10;

        }//Sets the Size of the datagrid
        private void generateColums()
        {
            int k = 0;
            generateRainFall();
            for (int i = 0; i < Rain.GetLength(0); i++)
            {
                k++;
                dgvRainfall.Columns[i].HeaderCell.Value = "Zone " + k;
                for (int j = 0; j < Rain.GetLength(1); j++)
                {
                    dgvRainfall[i, j].Value = Rain[i, j];
                }
            }
        }//Set values of the array into the datagridthi
        public void generateRainFall()
        {

            Random rainamount = new Random();
            for (int i = 0; i < Rain.GetLength(0); i++)
            {
                for (int j = 0; j < Rain.GetLength(1); j++)
                {
                    rainvalue = Math.Round((rainamount.Next(1, 100) + rainamount.NextDouble()), 2);
                    Rain[i, j] = rainvalue;
                }
            }
        }//Generates the random values into the array of values between 1-100
        private void btnSummary_Click(object sender, EventArgs e)
        {

            rtxtSummary.Clear();
            try
            {
                rtxtSummary.AppendText("NeoFit Rainfall Summary - " + DateTime.Now.ToString("yyyy:MM:dd") + " "
                    + DateTime.Now.ToString("HH:mm:ss tt") + "\n"
                    + "Monitoring Scope : 10 Geographic Zones,10 readings per zone(range:1.00-100.00) \n" +
                    "Thresholds: Low < 20 mm,High > 80 mm \n\n Overall: \n");
                rtxtSummary.SelectionBullet = true;
                rtxtSummary.AppendText("Average :" + Convert.ToString(Math.Round(getAverageRain(generalcount, GeneralAvg), 2)) + "mm\n");
                rtxtSummary.AppendText("Minimum :" + Convert.ToString(Math.Round(LowestValue, 2)) + " mm ");
                rtxtSummary.AppendText("Maximum :" + Convert.ToString(Math.Round(HighestValue, 2)) + " mm\n");
                rtxtSummary.AppendText("Extremes (Low/High) :" + Convert.ToString(anomolypercentage) + "%");
                rtxtSummary.SelectionBullet = false;
                rtxtSummary.AppendText("\n\nBand Breakdown: \n");
                rtxtSummary.SelectionBullet = (true);
                rtxtSummary.AppendText("Low (<20 mm) : count = " + Convert.ToString(lowcount) + " | avg =  "
                    + Convert.ToString(Math.Round(getAverageRain(lowcount, LowAvg), 2)) + " mm \n");
                rtxtSummary.AppendText("Medium (20-80mm) : count = " + Convert.ToString(inboundcount) + " | avg =  " +
                    Convert.ToString(Math.Round(getAverageRain(inboundcount, InboundAvg), 2)) + " mm \n");
                rtxtSummary.AppendText("High (> 80mm) : count = " + Convert.ToString(highcount) + " | avg =  "
                    + Convert.ToString(Math.Round(getAverageRain(highcount, HighAvg), 2)) + " mm");
                rtxtSummary.SelectionBullet = false;
                rtxtSummary.AppendText("\n\nOperational Notes: \n");
                rtxtSummary.SelectionBullet = true;
                rtxtSummary.AppendText("Use normal-band averages to plan standard camp days. \nHigh-Band clusters indicate flood risk" +
                    ": pre-deploy drainage & shelter.\nLow-Band clusters indicate drought risk : adjust hydration/heat policies");
                rtxtSummary.SelectionBullet = false;

                fileName = "RainReport_" + getDate() + "_" + getTime() + ".txt";
                SummaryReport = new StreamWriter(fileName);
                SummaryReport.WriteLine(rtxtSummary.Text);
                MessageBox.Show("Rainfall Summary Saved: \n " + Path.GetFullPath(fileName), "Rainfall Saved"
                  , MessageBoxButtons.OK, MessageBoxIcon.Information);
                SummaryReport.Close();

            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Please first load data");
            }
        }//DIsplays summary to richtextbox and loads file to a textfile
        private void LoopingAnomoly()
        {
            for (int i = 0; i < dgvRainfall.ColumnCount; i++)
            {
                for (int j = 0; j < dgvRainfall.RowCount; j++)
                {
                    if ((Convert.ToDouble(dgvRainfall[i, j].Value) < LowestValue) && ((Convert.ToDouble(dgvRainfall[i, j].Value) > 0)))
                    {
                        LowestValue = Convert.ToDouble(dgvRainfall[i, j].Value);
                    }
                    if (Convert.ToDouble(dgvRainfall[i, j].Value) > HighestValue)
                    {
                        HighestValue = Convert.ToDouble(dgvRainfall[i, j].Value);
                    }
                    generalcount++;
                    GeneralAvg = GeneralAvg + Convert.ToDouble(dgvRainfall[i, j].Value);
                    CheckAnomolyLow(i, j);
                    CheckAnomolyHigh(i, j);
                    CheckInbound(i, j);
                }
            }
        }//Main looping method for the gatagrid to get various method assumptions
        private void CheckAnomolyHigh(int i, int j)
        {
            if (Convert.ToDouble(dgvRainfall[i, j].Value) > 80)
            {
                if (colorAnomolies == true)
                {
                    dgvRainfall.Rows[j].Cells[i].Style.BackColor = Color.Coral;
                }
                AnomolyCount++;
                highcount++;
                HighAvg = HighAvg + Convert.ToDouble(dgvRainfall[i, j].Value);
            }
        }//Check if anomalies  > 80
        private void CheckInbound(int i, int j)
        {
            if ((Convert.ToDouble(dgvRainfall[i, j].Value) >= 20) && ((Convert.ToDouble(dgvRainfall[i, j].Value) <= 80)))
            {
                InboundAvg = InboundAvg + Convert.ToDouble(dgvRainfall[i, j].Value);
                inboundcount++;
            }
        }//Checks if values are between and equal to 20 and 80
        private void CheckAnomolyLow(int i, int j)
        {
            if (Convert.ToDouble(dgvRainfall[i, j].Value) < 20)
            {
                if (colorAnomolies == true)
                {
                    dgvRainfall.Rows[j].Cells[i].Style.BackColor = Color.Blue;
                }
                AnomolyCount++;
                lowcount++;
                LowAvg = LowAvg + Convert.ToDouble(dgvRainfall[i, j].Value);
            }
        }//Checks if values are under 20
        private void ResetVariables()
        {
            anomolypercentage = AnomolySummary / 100;
            HighestValue = 0;
            LowestValue = 100;
            generalcount = 0;
            GeneralAvg = 0;
            lowcount = 0;
            highcount = 0;
            inboundcount = 0;
            HighAvg = 0;
            InboundAvg = 0;
            LowAvg = 0;
        }//Resets all counter variables
        private void AnomolyText()
        {
            anomolypercentage = AnomolyCount;
            AnomolySummary = AnomolyCount;
            lblAnomalies.Text = "Extremes Detetected: " + Convert.ToString(AnomolySummary);
            AnomolyCount = 0;
        }//Changes how many anomolies detected
        private string getDate()
        {
            DateTime date = DateTime.Now.Date;
            return date.ToString("yyyyMMdd");
        }  //gets date in specific format
        private string getTime()
        {
            return DateTime.Now.ToString("HHmmss");
        }//Gets time in sepcific format
        private double getAverageRain(int count, double TotalValue)
        {
            double average = TotalValue / count;
            return average;
        }//Main average calculation for every variable involved in average

    }
}
