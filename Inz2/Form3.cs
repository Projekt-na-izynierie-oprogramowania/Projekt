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
    public partial class Obecności : Form
    {
        public Obecności()
        {
            InitializeComponent();
        }

        private void Obecności_Load(object sender, EventArgs e)
        {
            mycc();
            fillPrzedmioty();
        }


        private void comboBoxprzedmiot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (zmienne.level == "3" || zmienne.level == "2")//JESLI ADMIN
            {
                string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
                MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

                try
                {
                    databaseConnection.Open();
                    string query = $"SELECT us.name, us.surname, css.date, css.time, pr.if_present FROM presences pr INNER JOIN classes_schedule css ON pr.shedule_id = css.id INNER JOIN users us ON pr.user_id = us.id INNER JOIN classes cl ON css.id_classes = cl.id WHERE cl.id = \"{comboBoxprzedmiot.SelectedValue}\" ORDER BY css.date, css.time";

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
            else//JESLI UCZEN
            {
                string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
                MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

                try
                {
                    databaseConnection.Open();
                    string query = $"SELECT us.name, us.surname, css.date, css.time, pr.if_present FROM presences pr INNER JOIN classes_schedule css ON pr.shedule_id = css.id INNER JOIN users us ON pr.user_id = us.id INNER JOIN classes cl ON css.id_classes = cl.id WHERE cl.id = \"{comboBoxprzedmiot.SelectedValue}\" AND us.surname = \"{zmienne.kredki_nazwisko}\" ORDER BY css.date, css.time";

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

        

        private void mycc()
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToString();
            string result = textBox1.Text.Substring(0, 10);
            textBox1.Text = result;
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            mycc();
        }

        
    }
}
