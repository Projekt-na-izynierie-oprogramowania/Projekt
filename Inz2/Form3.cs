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
        }

        private void mycc()
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToString();
            string result = textBox1.Text.Substring(0, 10);
            textBox1.Text = result;
        }
        private void loadForToday()
        {
            
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
