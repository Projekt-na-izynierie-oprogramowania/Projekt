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
            label5.Text = zmienne.level;
            fillPrzedmioty();
            if (zmienne.level == "1")//JESLI UCZEN
            {
                buttonO.Hide();
                buttonS.Hide();
                buttonNU.Hide();
                buttonNN.Hide();
            }

        }

        private void alterRow(string if_present)
        {
            string id_classes = getSelectedClassesId();
            string user_id = getSelectedUserId();

            string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
            string query  = $"UPDATE presences SET if_present = \"{if_present}\" WHERE user_id = \"{user_id}\" AND shedule_id = \"{id_classes}\"";

            using (MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString))
            using (MySqlCommand komenda = new MySqlCommand(query, databaseConnection))
            {
                databaseConnection.Open();
                komenda.ExecuteNonQuery();
                databaseConnection.Close();
            }
        }

        private string getSelectedUserId()
        {
            int row = dataGridView1.CurrentRow.Index;
            string nazwisko = dataGridView1.Rows[row].Cells[1].Value.ToString();

            string query = $"SELECT `id` FROM `users` WHERE surname =\"{nazwisko}\" ";


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
                    labelAlert.Text = "Nie moge wylapac id zajec";
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

        private string getSelectedClassesId()
        {
            int row = dataGridView1.CurrentRow.Index;
            string data = dataGridView1.Rows[row].Cells[2].Value.ToString().Substring(0, 10);
            string godzina = dataGridView1.Rows[row].Cells[3].Value.ToString();

            string query = $"SELECT `id` FROM `classes_schedule` WHERE date = STR_TO_DATE('{data}','%d.%m.%Y') AND time = \"{godzina}\"";


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
                    labelAlert.Text = "Nie moge wylapac id zajec";
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

        private void comboBoxprzedmiot_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshPresences();
        }

        private void refreshPresences()
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

        


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }


        private void buttonO_Click(object sender, EventArgs e)
        {
            alterRow("O");
            refreshPresences();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            alterRow("S");
            refreshPresences();
        }

        private void buttonNN_Click(object sender, EventArgs e)
        {
            alterRow("NN");
            refreshPresences();
        }

        private void buttonNU_Click(object sender, EventArgs e)
        {
            alterRow("NU");
            refreshPresences();
        }
    }
}
