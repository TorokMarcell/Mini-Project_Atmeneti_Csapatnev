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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEredmeny_Click(object sender, EventArgs e)
        {
            Eredmenyek eredmeny=new Eredmenyek();
            eredmeny.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Difficulty d = new Difficulty();
            d.ShowDialog();
        }
    }
}
