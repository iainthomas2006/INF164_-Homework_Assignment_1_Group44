using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164_Homework_Assignment_1_Group44
{
    public partial class frmMain_Control_Hub : Form
    {
        public frmMain_Control_Hub()
        {
            InitializeComponent();

        }


        private void tsmiGrowthEngine_Click(object sender, EventArgs e)
        {
            frmGrowthEnginePro growthEnginePro = new frmGrowthEnginePro();
            this.Hide();
            growthEnginePro.Show();
        }

        private void tsmiRainfall_Click(object sender, EventArgs e)
        {
            frmRainfallData rainfallData = new frmRainfallData();
            this.Hide();
            rainfallData.Show();    
        }

        private void grbModuleAccess_Enter(object sender, EventArgs e)
        {

        }

        private void tsmiStockTracker_Click(object sender, EventArgs e)
        {
            frmStockTrack stockTrack = new frmStockTrack();
            this.Hide();
            stockTrack.Show();
        }

        private void mnsMainControl_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void moduleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiMediaRecovery_Click(object sender, EventArgs e)
        {
            MediaRecovery mediaRecovery = new MediaRecovery();
            this.Hide();
            mediaRecovery.Show();
        }
    }
}
