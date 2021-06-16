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
    public partial class FormDodajTest : Form
    {
        public FormDodajTest()
        {
            InitializeComponent();
        }

        private void FormDodajTest_Load(object sender, EventArgs e)
        {
            fillPrzedmioty();
        }

        private void fillPrzedmioty()
        {
            string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);


            try
            {
                databaseConnection.Open();
                string query = "SELECT `name`, `id` FROM `classes`";

                MySqlDataAdapter da = new MySqlDataAdapter(query, databaseConnection);

                DataSet ds = new DataSet();
                da.Fill(ds, "users");
                comboBoxprzedmiot.DisplayMember = "name";
                comboBoxprzedmiot.ValueMember = "id";
                comboBoxprzedmiot.DataSource = ds.Tables["users"];
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 404: " + ex.Message);//TO RZADKO DZIALA, OLEWAMY
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        { 
            string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
            string query = $"INSERT INTO assesments VALUES (NULL,\"{textBoxNazwa.Text}\",\"{dateTimePicker1.Text}\",\"{comboBoxprzedmiot.SelectedValue}\")";

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
