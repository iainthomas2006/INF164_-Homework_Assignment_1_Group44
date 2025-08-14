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
    public partial class frmLogin : Form
    {
        public static frmLogin Instance;
        public string StudentEmail;
        public frmLogin()
        {
            InitializeComponent();
            StudentEmail = txtEmailLogin.Text;
            Instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain_Control_Hub main_Control_Hub = new frmMain_Control_Hub();
            main_Control_Hub.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StudentEmail += txtEmailLogin.Text;
        }
    }
}
