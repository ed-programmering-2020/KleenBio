using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KleenBio
{
    public partial class Form1 : Form
    {
        string ConnString = "SERVER=localhost;DATABASE=kinoprogramme;UID=olas;PASSWORD=ola123;";

        List<kunder> AllaKunder;
        kunder aktuellKund;

        public Form1()
        {
            InitializeComponent();
            AllaKunder = new List<kunder>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(ConnString);
            connection.Open();

            MySqlCommand cmd = kunder.getAll();
            MySqlDataAdapter datAdapt = new MySqlDataAdapter();
            datAdapt.SelectCommand = cmd;
            cmd.Connection = connection;
            DataTable dt = new DataTable();
            datAdapt.Fill(dt);

            foreach(DataRow row in dt.Rows)
            {
                AllaKunder.Add(new kunder(row));
            }
            listBox1.DataSource = AllaKunder;
            connection.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktuellKund = (kunder)listBox1.SelectedItem;
            
            
        }
    }
}
