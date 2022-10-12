using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FastMath
{
    public partial class Eredmenyek : Form
    {
        public Eredmenyek()
        {
            InitializeComponent();
                
            //SqlCommand cmd = new SqlCommand(command, conn);
            //SqlDataReader rdr = cmd.ExecuteReader();
            //if (rdr.HasRows)
            //{

            //}
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                string command = "SELECT * FROM scoreboard;";
                connection.Open();
                MySqlCommand cmdSel = new MySqlCommand(command, connection);
                MySqlDataReader da = cmdSel.ExecuteReader();
                DataTable dt = new DataTable("gamewinners");
                //da.Fill(dt);
                //winnerData.ItemsSource = dt.DefaultView;
                //da.Update(dt);
                connection.Close();
                //winnerData.DataContext = dt;


            }
        }
        static string connString = "SERVER=localhost;" +
                                   "DATABASE=fastmathdb;" +
                                   "UID=root;" +
                                   "PASSWORD=;";
        private void InsertScoreDB()
        {
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                string command = "INSERT INTO scoreboard (scoreboard.Score, scoreboard.Date) values (@val1,CURRENT_TIMESTAMP);";
                connection.Open();
                MySqlCommand cmdSel = new MySqlCommand(command, connection);
                cmdSel.Parameters.AddWithValue("@val1",""); 
                MySqlDataReader da = cmdSel.ExecuteReader();
                DataTable dt = new DataTable("gamewinners");
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
