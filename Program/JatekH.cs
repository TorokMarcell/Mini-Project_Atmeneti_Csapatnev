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
    public partial class Form3 : Form
    {

        Random rnd3 = new Random();
        string[] Maths = { "Add", "Subtract", "Multiply" };
        int total;
        int score;

        public Form3()
        {
            InitializeComponent();
            SetUpGameH();
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
                SetUpGameH();             
            }
            else
            {
                lblAnswer.Text = "Helytelen!";
                lblAnswer.ForeColor = Color.Red;
            }

        }

        private void SetUpGameH()
        {
            int numA = rnd3.Next(50, 90);
            int numB = rnd3.Next(18, 36);

            txtAnswer.Text = null;

            switch (Maths[rnd3.Next(0, Maths.Length)])
            {
                case "Add":
                    total = numA + numB;
                    lblSymbol.Text = "+";
                    lblSymbol.ForeColor = Color.DarkGreen;
                    break;

                case "Subtract":
                    total = numA - numB;
                    lblSymbol.Text = "-";
                    lblSymbol.ForeColor = Color.Maroon;
                    break;

                case "Multiply":
                    total = numA * numB;
                    lblSymbol.Text = "x";
                    lblSymbol.ForeColor = Color.Purple;
                    break;
            }

            lblNumA2.Text = numA.ToString();
            lblNumB2.Text = numB.ToString();
        }
       
    }
}