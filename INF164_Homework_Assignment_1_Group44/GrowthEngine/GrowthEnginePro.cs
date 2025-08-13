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
    public partial class frmGrowthEnginePro : Form
    {
        public frmGrowthEnginePro()
        {
            InitializeComponent();
        }
        StreamReader BalanceInput;
        StreamWriter BalanceOutput;
        StreamWriter FailedValidation;
        decimal CurrentBalance, TargetBalance,PercentageChange;
        int Months;
        bool ValidationChecked;
        private void frmGrowthEnginePro_Load(object sender, EventArgs e)
        {
            try
            {
                BalanceInput = new StreamReader("Balance Current");
                string Balance;
                Balance = BalanceInput.ReadToEnd();
                nudBalance.Value = Convert.ToInt32(Balance);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File Not Found");
            }
            catch (FileLoadException)
            {
                MessageBox.Show("Could not load File");
            }
        }

        public void ValidationFailure ()
        {
            DateTime dateTime = DateTime.Now;
            FailedValidation = new StreamWriter("failure.txt");
            FailedValidation.WriteLine("Validation error logged on this date and time: "+dateTime );
            FailedValidation.Close();
        }
        private void nudTarget_ValueChanged(object sender, EventArgs e)
        {
            TargetBalance = nudTarget.Value;
        }

        private void nudMonths_ValueChanged(object sender, EventArgs e)
        {
            Months = Convert.ToInt16(nudMonths.Value);
        }

        private bool Validate(decimal Current, decimal Target , int Month)
        {
            bool Validated = false;
            if ((Current <= Target)||(Month > 0))
            {
                Validated = true;
            }
            else
            {
                MessageBox.Show("Please haave target Balance Greater Than Current and Months Greater than 0");
            }
            return Validated;
        }
        private void radFlat_CheckedChanged(object sender, EventArgs e)
        {
            ValidationChecked = Validate(CurrentBalance, TargetBalance, Months);
            if (ValidationChecked == true)
            {
                try
                {
                    PercentageChange = (((TargetBalance - CurrentBalance) / Months) / CurrentBalance * 100);
                    lblResult.Text = "Result:" + PercentageChange.ToString() + "% monthly growth required";
                }
                catch(DivideByZeroException)
                {
                    MessageBox.Show("Please Have a Current Balance Greater than 1");
                }
            }
        }
    }
}
