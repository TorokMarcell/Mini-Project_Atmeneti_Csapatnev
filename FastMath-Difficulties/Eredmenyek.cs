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
            SelectFromDB();
            
        }
        static string connString = "SERVER=localhost;" +
                                   "DATABASE=fastmathdb;" +
                                   "UID=root;" +
                                   "PASSWORD=;";

        //ennek a játék végén kell lefutnia
        private static void InsertScoreDB(string param)
        {
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                string command = "INSERT INTO scoreboard (scoreboard.Score, scoreboard.Date) values (@val1,CURRENT_TIMESTAMP);";
                connection.Open();
                MySqlCommand cmdSel = new MySqlCommand(command, connection);
                cmdSel.Parameters.AddWithValue("@val1",param);
                cmdSel.ExecuteNonQuery();
            }
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetScoreButton_Click(object sender, EventArgs e)
        {
            DeleteScoreDB();
            SelectFromDB();
        }

        private static void DeleteScoreDB()
        {
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                string command = "TRUNCATE scoreboard;";
                connection.Open();
                MySqlCommand cmdSel = new MySqlCommand(command, connection);
                cmdSel.ExecuteNonQuery();
            }
        }

        private void SelectFromDB()
        {
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                string command = "SELECT * FROM scoreboard;";
                connection.Open();
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(command, connection);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds, "scoreboard");
                dgvScore.DataSource = ds;
                dgvScore.DataMember = "scoreboard";
                connection.Close();
                InsertScoreDB("10");
            }
        }
    }
}
