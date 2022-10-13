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
    public partial class Eredmenyek : Form
    {
        public Eredmenyek()
        {
            InitializeComponent();

            dgvScore.ColumnCount = 2;
            dgvScore.Columns[0].Name = "Név";
            dgvScore.Columns[1].Name = "Elért pontszám";

            dgvScore.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvScore.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvScore.Update();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AddRow(string nev,string szam)
        {
            String[] row = { nev, szam };
            dgvScore.Rows.Add(row);
        }
    }
}
