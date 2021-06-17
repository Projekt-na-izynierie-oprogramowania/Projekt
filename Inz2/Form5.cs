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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            label5.Text = zmienne.level;
            if (zmienne.level == "3" || zmienne.level == "2")
            {
                jesliAdmin();
            }
            else
            {
                jesliUczen();
            }
        }

        private void jesliUczen()
        {
            buttonDodaj.Hide();
            buttonRefresh.Hide();
            fillData();

        }

        private void jesliAdmin()
        {
            fillData();
        }


        private void fillData()
        {
            string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            try
            {
                databaseConnection.Open();
                string query = "SELECT ass.Date AS \"Kiedy sie odbedzie\", ass.name AS \"Nazwa sprawdzianu\", cl.name AS \"Przedmiot\" FROM assesments ass INNER JOIN classes cl ON cl.id = ass.classes_id WHERE `Date` > SYSDATE();";

                MySqlDataAdapter da = new MySqlDataAdapter(query, databaseConnection);

                DataSet ds = new DataSet();
                da.Fill(ds, "oceny");

                dataGridView2.DataSource = ds.Tables["oceny"];
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 404: " + ex.Message);//TO RZADKO DZIALA, OLEWAMY
            }
        }


        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            FormDodajTest fd = new FormDodajTest();
            fd.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            fillData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zmienne.default_topic = $"Problem techniczny z panelem sprawdzianow. {DateTime.Now}";
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        
    }
}
