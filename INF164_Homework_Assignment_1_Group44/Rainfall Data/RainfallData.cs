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
    public partial class frmRainfallData : Form
    {
        public frmRainfallData()
        {
            InitializeComponent();
        }

        private void htsmiMainControl_Click(object sender, EventArgs e)
        {
            frmMain_Control_Hub main_Control_Hub = new frmMain_Control_Hub();
            this.Close(); 
            main_Control_Hub.Show();
        }
    }
}
