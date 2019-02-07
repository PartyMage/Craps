using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Craps_Game
{
    public partial class PlayerProfile : Form
    {
        public string CurrentPlayer;
        public string conString = "Data Source=DESKTOP-BKIS8L8;Initial Catalog = Craps; Integrated Security = True";
        public PlayerProfile()
        {
            InitializeComponent();
            FillDropDownList();
        }

        public void FillDropDownList()
        {
            string query = "SELECT [Player Name] FROM [Craps Player Info]";
            SqlDataReader reader;
            SqlConnection conDB = new SqlConnection(conString);
            conDB.Open();

            SqlCommand cmdDB = new SqlCommand(query, conDB);
            reader = cmdDB.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
                CurrentPlayer = reader[0].ToString();
            }

            reader.Close();
            conDB.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conDB = new SqlConnection(conString))
            {
                conDB.Open();
                string saveStaff = "INSERT into [Craps Player Info] ([Player ID],[Player Name]) VALUES (@PlayerID,@PlayerName,)";

                using (SqlCommand cmdDB = new SqlCommand(saveStaff))
                {
                    cmdDB.Connection = conDB;
                    cmdDB.Parameters.Add("@PlayerID", SqlDbType.Int).Value = this.textBox2.Text;
                    cmdDB.Parameters.Add("@PlayerName", SqlDbType.VarChar, 30).Value = this.textBox1.Text;
                }
                conDB.Close();
            }
            comboBox1.Items.Add(textBox1.Text);
            CurrentPlayer = textBox1.Text;
            label_ID.Text = textBox2.Text;
            label_Name.Text = textBox1.Text;
            label_Wins.Text = "0";
            label_Losses.Text = "0";
            Label_Rolls.Text = "0";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = comboBox1.Text;
            CurrentPlayer = ID;
            label_Name.Text = ID;
            string query = "SELECT [Player ID], [Player Name], [Number of Wins], [Number of Losses], [number of total rolls] FROM [Craps Player Info] where [Player Name] = '"+ID+"'";
            SqlConnection conDB = new SqlConnection(conString);
            conDB.Open();
            using (SqlCommand cmdDB = new SqlCommand(query, conDB))
            {
                SqlDataReader reader = cmdDB.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        label_ID.Text = reader[0].ToString();
                        label_Name.Text = reader[1].ToString();
                        label_Wins.Text = reader[2].ToString();
                        label_Losses.Text = reader[3].ToString();
                        Label_Rolls.Text = reader[4].ToString();
                    }
                }
                
                reader.Close();
                conDB.Close();
            }
        }

        private void playCraps_Click(object sender, EventArgs e)
        {
            CrapsGame playCraps = new CrapsGame(CurrentPlayer);
            playCraps.Owner = this;
            playCraps.Show();
            this.Hide();
        }
    }
}
