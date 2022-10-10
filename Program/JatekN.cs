using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace FastMath
{
    public partial class Form4 : Form
    {

        Random rnd2 = new Random();
        string[] Maths = { "Add", "Subtract", "Multiply" };
        int total;
        int score;

        public Form4()
        {
            InitializeComponent();
            SetUpGameN();
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAnswer.Text, "[^0-9]"))
            {
                MessageBox.Show("Csak számokat használj!");
                txtAnswer.Text = txtAnswer.Text.Remove(txtAnswer.Text.Length - 1);
            }
        }

        private void CheckButtonClickEvent(object sender, EventArgs e)
        {

            int userEntered = Convert.ToInt32(txtAnswer.Text);

            if (userEntered == total)
            {
                lblAnswer.Text = "Helyes!";
                lblAnswer.ForeColor = Color.Green;
                score += 1;
                lblScore.Text = "Score: " + score;
                SetUpGameN();                
            }
            else
            {
                lblAnswer.Text = "Helytelen!";
                lblAnswer.ForeColor = Color.Red;
            }

        }

        private void SetUpGameN()
        { 
            int numA2 = rnd2.Next(0, 0);
            int numB2 = rnd2.Next(9, 18);

            txtAnswer.Text = null;

            switch (Maths[rnd2.Next(0, Maths.Length)])
            {
                case "Add":
                    total = numA2 + numB2;
                    lblSymbol.Text = "+";
                    lblSymbol.ForeColor = Color.DarkGreen;
                    break;

                case "Subtract":
                    total = numA2 - numB2;
                    lblSymbol.Text = "-";
                    lblSymbol.ForeColor = Color.Maroon;
                    break;

                case "Multiply":
                    total = numA2 * numB2;
                    lblSymbol.Text = "x";
                    lblSymbol.ForeColor = Color.Purple;
                    break;
            }

            lblNumA3.Text = numA2.ToString();
            lblNumB3.Text = numB2.ToString();
        }     
    }
}