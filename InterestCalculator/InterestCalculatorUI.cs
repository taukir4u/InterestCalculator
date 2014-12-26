using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class InterestCalculatorUI : Form
    {
        public InterestCalculatorUI()
        {
            InitializeComponent();
        }

        private string bankName;
        private double time;
        private double balance;
        private double interest;

        public void TakeInput()
        {
            bankName = bankComboBox.Text;
            time = Convert.ToDouble(timeTextBox.Text);
            balance = Convert.ToDouble(balanceTextBox.Text);
        }
        
        private void calculateInterestButton_Click(object sender, EventArgs e)
        {
            TakeInput();
            if (bankName == "BRAC")
            {
                interest = (balance*6*time)/100;
                interestShowlabel.Text = interest.ToString();
            }
            else if (bankName == "DBBL")
            {
                interest = (balance * 7 * time) / 100;
                interestShowlabel.Text = interest.ToString();
            }
            else if (bankName == "HSBC")
            
            {
                interest = (balance * 8 * time) / 100;
                interestShowlabel.Text = interest.ToString();
            }
            else
            {
                MessageBox.Show("please select a bank name");
            }

        }
    }
}
