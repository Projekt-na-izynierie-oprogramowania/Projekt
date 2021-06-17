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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            textBox1.Text = zmienne.default_topic;
            fillPersons();
        }

        private void fillPersons()
        {
            string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);


            try
            {
                databaseConnection.Open();
                string query = "SELECT CONCAT(`name`, ' ',`surname`) AS `whole_name`, `id` FROM `users`";

                MySqlDataAdapter da = new MySqlDataAdapter(query, databaseConnection);

                DataSet ds = new DataSet();
                da.Fill(ds, "users");
                comboBox1.DisplayMember = "whole_name";
                comboBox1.ValueMember = "id";
                comboBox1.DataSource = ds.Tables["users"];
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 404: " + ex.Message);//TO RZADKO DZIALA, OLEWAMY
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dzisiejsza_data = DateTime.Now.ToString("dd.MM.yyyy");
            string user_id = getUserID();

            string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1"; 
            string query = $"INSERT INTO messages VALUES (NULL,\"{textBox1.Text}\",\"{richTextBox1.Text}\",\"{comboBox1.SelectedValue}\", STR_TO_DATE('{dzisiejsza_data}', '%d.%m.%Y'), \"{user_id}\")";

            using (MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString))
            using (MySqlCommand komenda = new MySqlCommand(query, databaseConnection))
            {
                databaseConnection.Open();
                komenda.ExecuteNonQuery();
                databaseConnection.Close();
            }

            MessageBox.Show("Wysłano wiadomość!");

            this.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zmienne.default_topic = $"Problem techniczny z wysylaniem wiadomosci. {DateTime.Now}";
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }
    }

    

        
}
