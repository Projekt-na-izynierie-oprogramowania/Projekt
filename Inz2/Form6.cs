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

namespace Inz2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            fillmessages();
        }

        private void getMessageContent()
        {
            int row = dataGridView1.CurrentRow.Index;
            string subject = dataGridView1.Rows[row].Cells[1].Value.ToString();
            string query = $"SELECT `content` FROM `messages` WHERE `subject` = \"{subject}\";";

            string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    myReader.Read();
                    richTextBox1.Text = myReader.GetString(0);
                }
                else
                {
                    MessageBox.Show("Nie moge znalezc takiej wiadomosci");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error 404: " + e.Message);//TO RZADKO DZIALA, OLEWAMY
            }
        }

        private string getUserID()
        {
            string query = $"SELECT `id` FROM `users` WHERE surname =\"{zmienne.kredki_nazwisko}\" ";


            string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {

                    myReader.Read();
                    string zwroconeid = myReader.GetString(0);
                    databaseConnection.Close();
                    return zwroconeid;

                }
                else
                {
                    databaseConnection.Close();
                    return "nie dzialam";
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Error 404: " + e.Message);//TO RZADKO DZIALA, OLEWAMY
                return "nie dzialam";
            }
        }

        private void fillmessages()
        {
            string user_id = getUserID();
            string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            try
            {
                databaseConnection.Open();
                string query = $"SELECT CONCAT(us.name, ' ', us.surname) AS \"Od kogo\", msg.subject AS \"Temat\", msg.date AS \"Data\" FROM messages msg INNER JOIN users us ON msg.from_user_id = us.id WHERE msg.to_user_id = \"{user_id}\"";

                MySqlDataAdapter da = new MySqlDataAdapter(query, databaseConnection);

                DataSet ds = new DataSet();
                da.Fill(ds, "oceny");
                dataGridView1.DataSource = ds.Tables["oceny"];
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 404: " + ex.Message);//TO RZADKO DZIALA, OLEWAMY
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zmienne.default_topic = $"Problem techniczny ze skrzynka wiadomosci. {DateTime.Now}";
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getMessageContent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zmienne.default_topic = "";
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }
    }
}
