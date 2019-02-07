using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Craps_Game
{
    public partial class CrapsGame : Form
    {
        int die1 = 0;
        int die2 = 0;
        int rollSum = 0;
        int point = 0;
        int numOfWins = 0;
        int numOfLosses = 0;
        int numOfTotalRolls = 0;
        bool pointsMode = false;
        public string conString = "Data Source=DESKTOP-BKIS8L8;Initial Catalog = Craps; Integrated Security = True";
        //const int repeatGame = 1000;

        Random random = new Random();

        public CrapsGame(string CurrentPlayer)
        {
            InitializeComponent();
            thisPlayer.Text = CurrentPlayer;
            string query = "SELECT [Number of Wins], [number of Losses], [number of total rolls] FROM [Craps Player Info] where [Player Name] = '" + CurrentPlayer + "'";
            SqlConnection conDB = new SqlConnection(conString);
            conDB.Open();
            using (SqlCommand cmdDB = new SqlCommand(query, conDB))
            {
                SqlDataReader reader = cmdDB.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        label_Win.Text = reader[0].ToString();
                        label_Losses.Text = reader[1].ToString();
                        label_Rolls.Text = reader[2].ToString();
                    }
                }

                reader.Close();
                conDB.Close();
            }
            this.FormClosed +=
               new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            die1 = random.Next(1, 7);
            DieImageFiller(die1, true);
            die2 = random.Next(1, 7);
            DieImageFiller(die2, false);
            rollSum = die1 + die2;
            numOfTotalRolls = Int32.Parse(label_Rolls.Text);
            label_Rolls.Text = (numOfTotalRolls + 1).ToString();
            textBox1.Text = "You're score is " + rollSum;
            ScoreCraps();
        }

        public void DieImageFiller(int die, bool isDieOne)
        {
            switch (die)
            {
                case 1:
                    if (isDieOne == true)
                    {
                        pictureBox1.Image = Properties.Resources.dice_1_512;
                        break;
                    }
                    else
                    {
                        pictureBox2.Image = Properties.Resources.dice_1_512;
                        break;
                    }
                case 2:

                    if (isDieOne == true)
                    {
                        pictureBox1.Image = Properties.Resources.dice_2_512;
                        break;
                    }
                    else
                    {
                        pictureBox2.Image = Properties.Resources.dice_2_512;
                        break;
                    }
                case 3:

                    if (isDieOne == true)
                    {
                        pictureBox1.Image = Properties.Resources.dice_3_512;
                        break;
                    }
                    else
                    {
                        pictureBox2.Image = Properties.Resources.dice_3_512;
                        break;
                    }
                case 4:

                    if (isDieOne == true)
                    {
                        pictureBox1.Image = Properties.Resources.dice_4_512;
                        break;
                    }
                    else
                    {
                        pictureBox2.Image = Properties.Resources.dice_4_512;
                        break;
                    }
                case 5:

                    if (isDieOne == true)
                    {
                        pictureBox1.Image = Properties.Resources.dice_5_512;
                        break;
                    }
                    else
                    {
                        pictureBox2.Image = Properties.Resources.dice_5_512;
                        break;
                    }
                case 6:

                    if (isDieOne == true)
                    {
                        pictureBox1.Image = Properties.Resources.dice_6_512;
                        break;
                    }
                    else
                    {
                        pictureBox2.Image = Properties.Resources.dice_6_512;
                        break;
                    }
            }
        }
        
        public void ScoreCraps()
        {
            SqlConnection conDB = new SqlConnection(conString);
            SqlCommand cmdWin = new SqlCommand("INSERT INTO [Craps Player Info] ([Number of Wins]) VALUES (@numofWins)",conDB);
            SqlCommand cmdLoss = new SqlCommand("INSERT INTO [Craps Player Info] ([Number of Losses]) VALUES (@numofLosses)", conDB);
            SqlCommand cmdRoll = new SqlCommand("INSERT INTO [Craps Player Info] ([Sum of Rolls]) VALUES (@numofRolls)", conDB);

            int RowsAffected;

            cmdWin.Parameters.Add("@numofWins", System.Data.SqlDbType.Int);
            cmdLoss.Parameters.Add("@numofLosses", System.Data.SqlDbType.Int);
            cmdRoll.Parameters.Add("@numofRolls", System.Data.SqlDbType.Int);

            cmdRoll.Parameters["@numofRolls"].Value = Convert.ToInt32(rollSum);

            if (pointsMode == false)
            {
                if (rollSum == 7 || rollSum == 11)
                {
                    textBox1.Text = "You won!";
                    numOfWins = Int32.Parse(label_Win.Text);
                    cmdWin.Parameters["@numofWins"].Value = Convert.ToInt32(numOfWins);
                    conDB.Open();
                    RowsAffected = cmdWin.ExecuteNonQuery();
                    conDB.Close();
                    label_Win.Text = (numOfWins + 1).ToString();
                }
                else if (rollSum == 2 || rollSum == 3 || rollSum == 12)
                {
                    textBox1.Text = "CRAPS! You lost.";
                    numOfLosses = Int32.Parse(label_Losses.Text);
                    cmdLoss.Parameters["@numofLosses"].Value = Convert.ToInt32(numOfLosses);
                    label_Losses.Text = (numOfLosses + 1).ToString();
                    conDB.Open();
                    RowsAffected = cmdLoss.ExecuteNonQuery();
                    conDB.Close();
                }
                else
                {
                    textBox1.Text = "You have " + rollSum + " points, roll again!";
                    pointBox.Text = "Points: " + rollSum;
                    pointsMode = true;
                    point = rollSum;
                }
            }
            else
            {
                if (rollSum == point)
                {
                    textBox1.Text = "You hit your previous score of " + point + " You won!";
                    numOfWins = Int32.Parse(label_Win.Text);
                    cmdWin.Parameters["@numofWins"].Value = Convert.ToInt32(numOfWins);
                    label_Win.Text = (numOfWins + 1).ToString();
                    conDB.Open();
                    RowsAffected = cmdWin.ExecuteNonQuery();
                    conDB.Close();
                    pointsMode = false;
                }

                if (rollSum == 7)
                {
                    textBox1.Text = "You hit 7, You lost";
                    numOfLosses = Int32.Parse(label_Losses.Text);
                    cmdLoss.Parameters["@numofLosses"].Value = Convert.ToInt32(numOfLosses);
                    label_Losses.Text = (numOfLosses + 1).ToString();
                    conDB.Open();
                    RowsAffected = cmdLoss.ExecuteNonQuery();
                    conDB.Close();
                    pointsMode = false;
                }
            }
            conDB.Open();
            RowsAffected = cmdRoll.ExecuteNonQuery();
            conDB.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }
    }
}
