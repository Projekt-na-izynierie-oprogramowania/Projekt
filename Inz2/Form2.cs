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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelAccesslvl.Text = zmienne.level;
            if(zmienne.level=="3" || zmienne.level == "2")
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
            comboBox1.Hide();
            buttonDodaj.Hide();
            buttonRefresh.Hide();

            string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            try
            {
                databaseConnection.Open();
                string query = $"SELECT us.name, us.surname, cl.name AS \"przedmiot\", ass.name AS \"z czego\", ass.Date, sc.Grade FROM scores sc INNER JOIN assesments ass ON ass.id = sc.assesment_id INNER JOIN classes cl ON ass.classes_id = cl.id INNER JOIN users us ON us.id = sc.user_id WHERE us.surname = \"{zmienne.kredki_nazwisko}\"";

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





        private void jesliAdmin()
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







        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            try
            {
                databaseConnection.Open();
                string query = $"SELECT us.name, us.surname, cl.name AS \"przedmiot\", ass.name AS \"z czego\", ass.Date, sc.Grade FROM scores sc INNER JOIN assesments ass ON ass.id = sc.assesment_id INNER JOIN classes cl ON ass.classes_id = cl.id INNER JOIN users us ON us.id = sc.user_id WHERE us.id = \"{comboBox1.SelectedValue}\"";

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







        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            try
            {
                databaseConnection.Open();
                string query = $"SELECT us.name, us.surname, cl.name AS \"przedmiot\", ass.name AS \"z czego\", ass.Date, sc.Grade FROM scores sc INNER JOIN assesments ass ON ass.id = sc.assesment_id INNER JOIN classes cl ON ass.classes_id = cl.id INNER JOIN users us ON us.id = sc.user_id WHERE us.id = \"{comboBox1.SelectedValue}\"";

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

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            FormDodajOcene fd = new FormDodajOcene();
            fd.ShowDialog();
        }
    }
}
