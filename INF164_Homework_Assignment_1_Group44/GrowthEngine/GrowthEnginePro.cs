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
        StreamWriter BalanceOutput;
        double TargetBalance, Balance, Months;
        string[] lines;
        int endOfLine, Spaceindex;
        string balancetemp;
        private void frmGrowthEnginePro_Load(object sender, EventArgs e)
        {
            try
            {
                bool Found = false;
                lines = File.ReadAllLines("Balance.txt");
                int i = 0;
                while ((i < lines.Length) && (Found == false))
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
                if (Found == true)
                {
                    nudBalance.Enabled = false;
                    balancetemp = lines[i];
                    Spaceindex = balancetemp.IndexOf(" ");
                    balancetemp = balancetemp.Substring(Spaceindex + 1);
                    if (int.TryParse(balancetemp, out endOfLine))
                    {
                        Balance = endOfLine;
                        nudBalance.Value = endOfLine;
                    }
                    else
                    {
                        ErrorMessage("Balance was invalid set value to 0", "Balance Invalid");
                        Balance = 0;
                        nudBalance.Value = 0;
                    }

                }

            }
            catch (FileNotFoundException)
            {
                ErrorMessage("File Was not Found", "File Found Error");
                nudBalance.Enabled = false;
                BalanceOutput = new StreamWriter("Balance.txt");
                BalanceOutput.Write("Balance for different students");
                BalanceOutput.Close();
            }
            catch (FileLoadException)
            {
                ErrorMessage("File Could not be Loaded", "File Load Error");
            }   
        }//Loads balance/creates new file if doesn't exist
        private void ErrorMessage(string Message, string Title)
        {
            MessageBox.Show(Message,Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            FailureText(Message);
        }//Compiles an error message
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
        }//Changes Target Balance
        private void nudMonths_ValueChanged(object sender, EventArgs e)
        {
            Months = Convert.ToDouble(nudMonths.Value);
        }//Changes month
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
        }//Displays error message in failure.txt
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
        }//Vailidates informations
        private void SaveNewBalance()
        {
            bool Found = false;
            lines = File.ReadAllLines("Balance.txt");
            File.Delete("Balance.txt");
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
                File.AppendAllLines("Balance.txt",lines);
            }
            else
            {
                lines[i] = "";
                lines[i] = StudentEmail + " " + Convert.ToString(TargetBalance);
                File.AppendAllLines("Balance.txt", lines);
            }
            MessageBox.Show("Balance Saved Returning to Main hub");
            frmMain_Control_Hub main_Control_Hub = new frmMain_Control_Hub();
            this.Close();
            main_Control_Hub.Show();
        }//Saves new Balance of user
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
