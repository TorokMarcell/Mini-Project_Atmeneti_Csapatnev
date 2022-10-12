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

        ScoreEntities sce = new ScoreEntities();


        public Eredmenyek()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Eredmenyek_Load(object sender, EventArgs e)
        {
            //var query = from Table in sce.Table
                        //select new { Table.Id, Table.Name, Table.Score };
            //dgvScore.DataSource = query;
        }
    }
}
