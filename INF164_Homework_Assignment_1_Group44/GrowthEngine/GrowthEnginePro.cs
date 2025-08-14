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
using System.Runtime.Serialization.Formatters;

namespace INF164_Homework_Assignment_1_Group44
{
    public partial class frmGrowthEnginePro : Form
    {
        public static frmGrowthEnginePro instance;
        public frmGrowthEnginePro()
        {
            InitializeComponent();
            instance = this;
        }
        string StudentEmail = frmLogin.Instance.StudentEmail;
        StreamReader BalanceInput;
        StreamWriter BalanceOutput;
        double TargetBalance, Balance, Months;
        string errorMessage;
        private void frmGrowthEnginePro_Load(object sender, EventArgs e)
        {
            try
            {
                BalanceInput = new StreamReader("Balance Current");
                Balance = Convert.ToDouble(BalanceInput.ReadToEnd());
                nudBalance.Value = Convert.ToInt16(Balance);
                nudBalance.Enabled = false;
            }
            catch (FileNotFoundException)
            {
                ErrorMessage("File Was not Found", "File Found Error");
                nudBalance.Enabled = true;
            }
            catch (FileLoadException)
            {
                ErrorMessage("File Could not be Loaded", "File Load Error");
            }   
        }
        private void ErrorMessage(string Message, string Title)
        {
            MessageBox.Show(Message,Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            FailureText(Message);
        }
        private void Validate(out bool Validation)
        {
            if ((Balance < TargetBalance)&&(Months > 0))
            {
                if ((radFlat.Checked == true) || (radCompound.Checked == true))
                {
                    Validation = true;
                }
                else
                { Validation = false; }
                
            }
            else
            {
                Validation = false;
            }
           
        }
        private void nudTarget_ValueChanged(object sender, EventArgs e)
        {
            TargetBalance = Convert.ToDouble(nudTarget.Value);
            MessageBox.Show(StudentEmail);
        }
        private void nudMonths_ValueChanged(object sender, EventArgs e)
        {
            Months = Convert.ToDouble(nudMonths.Value);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool Validation;
            Validate(out Validation);
            if (Validation == false)
            {
                ErrorMessage("Target balance must be above current," +" months should be greater than 0 and " +
                    "either compound or flat should be checked", "Validation Failed");
            }
            else
            {
                CheckCompoundFlat();
            }
        }
        private void CheckCompoundFlat ()
        {
            double Current = Convert.ToDouble(nudBalance.Value);
            if (radFlat.Checked == true)
            {
              BalanceFlat( ref Current);
                WriteText(Current,"Flat");
            }
            if (radCompound.Checked == true)
            {
                BalanceCompound( ref Current);
                WriteText(Current,"Compound");
            }
        }
        private void WriteText(double Display,string Growth)
        {
            rtxtInvestment.AppendText(DateTime.Now.ToString("yyyy,MM,dd - HH:mm:ss") +": Flat Growth Calculated = "
                + Convert.ToString(Math.Round(Display,2)) + "% per month \n");
            lblResult.Text = "Result : " + Convert.ToString(Math.Round(Display, 2)) + "% monthly growth required";
        }
        private void FailureText(string message)
        {
            File.AppendAllText("failure.txt", DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss ")
                + message + "\n");
        }
        private void BalanceFlat(ref double Currents)
        {
            Currents = ((TargetBalance - Currents)/Months)/Currents * 100;
            Math.Round(Currents,2);
        }
        private void BalanceCompound(ref double Currents)
        {
            Currents = (Math.Pow((TargetBalance / Currents), (1 / Months))-1)*100;
            Math.Round((Currents / Months),2);
        }
        private void nudBalance_ValueChanged(object sender, EventArgs e)
        {
            Balance = Convert.ToDouble(nudBalance.Value);
        }
    }
}
