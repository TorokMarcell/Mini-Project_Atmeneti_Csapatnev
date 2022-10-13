using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FastMath
{
    public partial class UserName : Form
    {

        ScoreEntities sce = new ScoreEntities();

        public UserName()
        {
            InitializeComponent();
        }

        private void UserName_Load(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<Form2>().Any())
            {
                lblCorrect.Text = Form2.score.ToString();
            }
            else if (Application.OpenForms.OfType<Form3>().Any())
            {
                lblCorrect.Text = Form3.score.ToString();
            }
            else if (Application.OpenForms.OfType<Form4>().Any())
            {
                lblCorrect.Text = Form4.score.ToString();
            }
            else if (Application.OpenForms.OfType<Form4>().Any())
            {
                lblCorrect.Text = Form4.score.ToString();

            }
            else if (Application.OpenForms.OfType<Form5>().Any())
            {
                lblCorrect.Text = Form5.score.ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Adj meg valami nevet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
                Eredmenyek er = new Eredmenyek();
                er.AddRow(tbName.Text,lblCorrect.Text);
                er.ShowDialog();
            }

        }
    }
}
