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
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void buttonZaloguj_Click(object sender, EventArgs e)
        {
            zalogujQuery();
        }

        private void zalogujQuery()
        {
            
            string wpisanylogin = textBoxLogin.Text;
            string wpisanehaslo = textBoxHaslo.Text;
            string query = $"SELECT `name`, `surname`, `username`, `password`, `accesslevel` FROM `users` WHERE `username` = \"{wpisanylogin}\" AND `password` = \"{wpisanehaslo}\";";

            string MySQLConnectionString = "datasource = localhost; port = 3306; username = root; password =; database=dzienniczekv1";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if(myReader.HasRows)
                {
                    
                    //while(myReader.Read())
                    //{
                        myReader.Read();
                        Console.WriteLine(myReader.GetString(0) + " - " + myReader.GetString(1) + " - " + myReader.GetString(2) + " - " + myReader.GetString(3) + " - " + myReader.GetString(4));
                    //}

                    zmienne.kredki_imie = myReader.GetString(0);
                    zmienne.kredki_nazwisko = myReader.GetString(1);
                    zmienne.level = myReader.GetString(4);
                    this.Close();

                }
                else
                {
                    labelChecker.Text = "Podano błędne dane, spróbuj jeszcze raz!";
                }

            }
            catch(Exception e)
            {
                MessageBox.Show("Error 404: " + e.Message);//TO RZADKO DZIALA, OLEWAMY
            }
        }

        private void buttonWyjdz_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonAnuluj_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonadmin_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "KowalskiJ";
            textBoxHaslo.Text = "admin";
        }

        private void buttonlewa_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "LewandowskiR";
            textBoxHaslo.Text = "Kozaczek";
        }
    }
}
