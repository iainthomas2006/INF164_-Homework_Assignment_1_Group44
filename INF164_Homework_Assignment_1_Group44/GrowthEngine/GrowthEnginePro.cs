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
                BalanceInput = new StreamReader("Balance.txt");
               // Balance = Convert.ToDouble(BalanceInput.ReadToEnd());
                nudBalance.Value = Convert.ToInt16(Balance);
                nudBalance.Enabled = false;
            }
            catch (FileNotFoundException)
            {
                ErrorMessage("File Was not Found", "File Found Error");
                nudBalance.Enabled = true;
                File.Create("Balance.txt");
               
            }
            catch (FileLoadException)
            {
                ErrorMessage("File Could not be Loaded", "File Load Error");
            }   
            if (nudBalance.Value == 0)
            {
              nudBalance.Enabled = true;
            }
        }
        private void ErrorMessage(string Message, string Title)
        {
            MessageBox.Show(Message,Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            FailureText(Message);
        }
        private void Validate(out bool Validation)//Validates values of numericupdowns
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
        }
        private void nudMonths_ValueChanged(object sender, EventArgs e)
        {
            Months = Convert.ToDouble(nudMonths.Value);
        }
        private void btnCalculate_Click(object sender, EventArgs e)//Calculates growth rate if validation true
        {
            Months = Math.Round(Months,0);
            bool Validation;
            Validate(out Validation);
            if (Validation == false)
            {
                ErrorMessage("Target balance must be above current," +" months should be greater than 0 and " +
                    "either compound or flat should be checked", "Validation Failed");
            }
            else
            {
                if (Balance == 0)
                {
                    Balance = TargetBalance;
                    nudBalance.Value = Convert.ToInt32(TargetBalance);
                    nudTarget.Value = 0;
                    ErrorMessage("Balance was 0 target set as new balance", "Please try Again");
                    TargetBalance = 0;
                }
                else
                {
                    CheckCompoundFlat();
                }
            }
        }
        private void CheckCompoundFlat ()//checks wheter compound or flat growth rate selected
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
        private void WriteText(double Display,string Growth)//Writes text into richtextbox
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
        private void BalanceFlat(ref double Currents)//calculates flat rate
        {
            Currents = ((TargetBalance - Currents)/Months)/Currents * 100;
            Math.Round(Currents,2);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool validation = false;
            Validate(out validation);
            if (validation == false)
            {
                ErrorMessage("Target balance must be above current," + " months should be greater than 0 and " +
                    "either compound or flat should be checked", "Validation Failed");
            }
            else
            {
                SaveNewBalance();
            }
        }
        private void SaveNewBalance()
        {
            bool Found = false;
            string[] lines = File.ReadAllLines("Balance.txt");
            int i = 0;
            while ((i < lines.Length)&& (Found == false))
            {
              if (lines[i].Contains(StudentEmail))
                {
                    Found = true; 
                }
              else
                {
                    i++;
                }
            }
            if (Found == false)
            {
                Array.Resize(ref lines, lines.Length+1);
                lines[lines.Length-1] = StudentEmail + " " + Convert.ToString(Balance);
                File.WriteAllLines("Balance.txt",lines);
            }
            else
            {
                lines[i] = "";
                lines[i] = StudentEmail + " " + Convert.ToString(TargetBalance);
                File.WriteAllLines("Balance.txt", lines);
            }
        }
        private void BalanceCompound(ref double Currents)
        {
            Currents = (Math.Pow((TargetBalance / Currents), (1 / Months))-1)*100;
            Math.Round((Currents / Months),2);
        }//calculates comput rate
        private void nudBalance_ValueChanged(object sender, EventArgs e)
        {
            Balance = Convert.ToDouble(nudBalance.Value);
        }
    }
}
