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
    public partial class Difficulty : Form
    {
        public Difficulty()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Form2 jatek = new Form2();
            jatek.ShowDialog();
        }
        private void btnMedium_CLick(object sender, EventArgs b)
        {            
            Form3 jatekN = new Form3();
            jatekN.ShowDialog();
        }
        private void btn_Hard(object sender, EventArgs c)
        {
            Form4 jatekH = new Form4();
            jatekH.ShowDialog();
        }
        private void btnAllKind_Clicker(object sender, EventArgs d)
        {            
            Form5 jatekV = new Form5();
            jatekV.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs f)
        {

            this.Close();
        }
    }
}
