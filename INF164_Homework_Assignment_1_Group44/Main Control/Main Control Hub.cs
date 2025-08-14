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

        private void stockTrackAndAnalyzerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockTrack stockTrack = new frmStockTrack();
            stockTrack.ShowDialog();
        }
    }
}
