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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label5.Text = zmienne.level;
            mycc();
            fillToday();
            fillComboBoxes();

            buttonDodaj.Hide();
            comboBoxPrzedmiot.Hide();
            comboBoxGodzina.Hide();
            buttonDodaj2.Hide();
            labelAlert.Hide();


            if (zmienne.level == "3" || zmienne.level == "2")
            {
                buttonDodaj.Show();
            }
        }

        private void fillComboBoxes()
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
                comboBoxPrzedmiot.DisplayMember = "name";
                comboBoxPrzedmiot.ValueMember = "id";
                comboBoxPrzedmiot.DataSource = ds.Tables["users"];
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 404: " + ex.Message);//TO RZADKO DZIALA, OLEWAMY
            }


            comboBoxGodzina.Items.Add(new KeyValuePair<string, string>("07:00", "07:00"));
            comboBoxGodzina.Items.Add(new KeyValuePair<string, string>("07:55", "07:55"));
            comboBoxGodzina.Items.Add(new KeyValuePair<string, string>("08:50", "08:50"));
            comboBoxGodzina.Items.Add(new KeyValuePair<string, string>("09:45", "09:45"));
            comboBoxGodzina.Items.Add(new KeyValuePair<string, string>("10:40", "10:40"));
            comboBoxGodzina.Items.Add(new KeyValuePair<string, string>("11:35", "11:35"));
            comboBoxGodzina.Items.Add(new KeyValuePair<string, string>("12:45", "12:45"));
            comboBoxGodzina.Items.Add(new KeyValuePair<string, string>("13:40", "13:40"));
            comboBoxGodzina.Items.Add(new KeyValuePair<string, string>("14:35", "14:35"));
            comboBoxGodzina.Items.Add(new KeyValuePair<string, string>("15:30", "15:30"));

            comboBoxGodzina.SelectedIndex = 0;

            comboBoxGodzina.DisplayMember = "key";
            comboBoxGodzina.ValueMember = "value";
        }


        private void buttonDodaj2_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, string> kvp = (KeyValuePair<string, string>)comboBoxGodzina.SelectedItem;
            string value = kvp.Value.ToString();

            string query = $"SELECT * FROM `classes_schedule` WHERE date = STR_TO_DATE('{labelDay.Text}','%d.%m.%Y') AND time = \"{value}\"";

            string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    labelAlert.ForeColor = System.Drawing.Color.Red;
                    labelAlert.Text = "Godzina jest zajeta!";


                }
                else
                {
                    databaseConnection.Close();
                    query = $"INSERT INTO classes_schedule VALUES (NULL,\"{comboBoxPrzedmiot.SelectedValue}\", STR_TO_DATE('{labelDay.Text}','%d.%m.%Y'),\"{value}\")";

                    
                    using (MySqlCommand komenda = new MySqlCommand(query, databaseConnection))
                    {
                        databaseConnection.Open();
                        komenda.ExecuteNonQuery();
                        
                    }

                    fillToday();
                }

                databaseConnection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 404: " + ex.Message);//TO RZADKO DZIALA, OLEWAMY
            }
        }


        private void fillToday()
        {

            string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            try
            {
                databaseConnection.Open();
                string query = $"SELECT csh.time AS \"Godzina Rozpoczecia\", cl.name AS \"Przedmiot\" FROM classes_schedule csh INNER JOIN classes cl ON cl.id = csh.id_classes WHERE STR_TO_DATE('{labelDay.Text}','%d.%m.%Y') = csh.date ORDER BY csh.time";

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

        private void mycc()
        {
            labelDay.Text = monthCalendar1.SelectionStart.ToString();
            string result = labelDay.Text.Substring(0, 10);
            labelDay.Text = result;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            mycc();
            fillToday();
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

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (comboBoxPrzedmiot.Visible == false)
            {
                comboBoxPrzedmiot.Show();
                comboBoxGodzina.Show();
                buttonDodaj2.Show();
                labelAlert.Show();
            }
            else
            {
                comboBoxPrzedmiot.Hide();
                comboBoxGodzina.Hide();
                buttonDodaj2.Hide();
                labelAlert.Hide();
            }
        }

        
    }
}
