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
    public partial class Form5 : Form
    {

        Random rnd4 = new Random();
        string[] Maths = { "Add", "Subtract", "Multiply" };
        int total;
        int score;

        public Form5()
        {
            InitializeComponent();
            SetUpGameV();
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
                SetUpGameV();               
            }
            else
            {
                lblAnswer.Text = "Helytelen!";
                lblAnswer.ForeColor = Color.Red;
            }

        }

        private void SetUpGameV()
        {
            int numA = rnd4.Next(0, 90);
            int numB = rnd4.Next(0, 38);

            txtAnswer.Text = null;

            switch (Maths[rnd4.Next(0, Maths.Length)])
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

            lblNumA4.Text = numA.ToString();
            lblNumB4.Text = numB.ToString();
        }      
    }
}