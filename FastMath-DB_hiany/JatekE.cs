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
    public partial class Form2 : Form
    {

        Random rnd = new Random();
        string[] Maths = { "Add", "Subtract", "Multiply" };
        int total;
        public static int score;
        static int i = 1;

        public Form2()
        {
            InitializeComponent();
            SetUpGame();
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
            if (i == 10)
            {
                UserName u = new UserName();
                u.ShowDialog();
            }

            int userEntered = Convert.ToInt32(txtAnswer.Text);

                if (userEntered == total)
                {
                    lblAnswer.Text = "Helyes!";
                    lblAnswer.ForeColor = Color.Green;
                    score += 1;
                    lblScore.Text = "Score: " + score;
                    i++;
                    SetUpGame();
                }
                else
                {
                    lblAnswer.Text = "Helytelen!";
                    lblAnswer.ForeColor = Color.Red;
                    i++;
                    SetUpGame();
                }
            

        }

        private void SetUpGame()
        {
            int numA = rnd.Next(10, 20);
            int numB = rnd.Next(0, 9);
            int csere;

            txtAnswer.Text = null;

            switch (Maths[rnd.Next(0, Maths.Length)])
            {
                case "Add":
                    total = numA + numB;
                    lblSymbol.Text = "+";
                    lblSymbol.ForeColor = Color.DarkGreen;
                    break;

                case "Subtract":
                    if (numB > numA)
                    {
                        csere = numA;
                        numA = numB;
                        numB = csere;
                    }
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

            lblNumA.Text = numA.ToString();
            lblNumB.Text = numB.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}