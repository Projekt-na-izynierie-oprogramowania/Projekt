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
    public partial class FormDodajOcene : Form
    {
        public FormDodajOcene()
        {
            InitializeComponent();
        }

        private void FormDodajOcene_Load(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);


            try//FILLOWANIE UCZNIOW
            {
                databaseConnection.Open();
                string query = "SELECT CONCAT(`name`, ' ',`surname`) AS `whole_name`, `id` FROM `users` WHERE `accesslevel` = 1";

                MySqlDataAdapter da = new MySqlDataAdapter(query, databaseConnection);

                DataSet ds = new DataSet();
                da.Fill(ds, "users");
                comboBoxUczen.DisplayMember = "whole_name";
                comboBoxUczen.ValueMember = "id";
                comboBoxUczen.DataSource = ds.Tables["users"];
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 404: " + ex.Message);//TO RZADKO DZIALA, OLEWAMY
            }



            try//FILLOWANIE TESTOW
            {
                databaseConnection.Open();
                string query = "SELECT `name`, `id` FROM `assesments`";

                MySqlDataAdapter da = new MySqlDataAdapter(query, databaseConnection);

                DataSet ds = new DataSet();
                da.Fill(ds, "users");
                comboBoxTest.DisplayMember = "name";
                comboBoxTest.ValueMember = "id";
                comboBoxTest.DataSource = ds.Tables["users"];
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 404: " + ex.Message);//TO RZADKO DZIALA, OLEWAMY
            }


            comboBoxOcena.Items.Add(new KeyValuePair<string, string>("1", "1"));
            comboBoxOcena.Items.Add(new KeyValuePair<string, string>("2", "2"));
            comboBoxOcena.Items.Add(new KeyValuePair<string, string>("3", "3"));
            comboBoxOcena.Items.Add(new KeyValuePair<string, string>("4", "4"));
            comboBoxOcena.Items.Add(new KeyValuePair<string, string>("5", "5"));
            comboBoxOcena.Items.Add(new KeyValuePair<string, string>("6", "6"));

            comboBoxOcena.DisplayMember = "key";
            comboBoxOcena.ValueMember = "value";
        }

        private void buttonDodajSubmit_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, string> kvp = (KeyValuePair<string, string>)comboBoxOcena.SelectedItem;
            string value = kvp.Value.ToString();

            string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
            string query = $"INSERT INTO scores VALUES (NULL,\"{value}\",\"{comboBoxUczen.SelectedValue}\",\"{comboBoxTest.SelectedValue}\")";

            using (MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString))
            using (MySqlCommand komenda = new MySqlCommand(query, databaseConnection))
            {
                databaseConnection.Open();
                komenda.ExecuteNonQuery();
                databaseConnection.Close();
            }

            
            this.Close();
        }
    }
}
