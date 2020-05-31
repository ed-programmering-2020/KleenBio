using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KleenBio
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        MySqlDataReader dtRead;
        MySqlCommand cmd2;
        string ConnString = "SERVER=localhost;DATABASE=kinoprogramme;UID=olas;PASSWORD=ola123;";

        List<kunder> AllaKunder;
        kunder aktuellKund;
        string bookInfo;
        string sqlsats;
        int book_ID;


        public Form1()
        {
            InitializeComponent();
            AllaKunder = new List<kunder>();
            connection = new MySqlConnection(ConnString);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            int dagar = (DateTime.Now - aktuellKund.LastLog).Days;
            label1.Text = aktuellKund.Namn + "\t lastlog " + aktuellKund.LastLog.ToShortDateString() + " ( för " + dagar + " dagar sedan )";
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Book_Click(object sender, EventArgs e)
        {
            Bokningskontroll bokningskontroll = new Bokningskontroll(book_ID);
            bokningskontroll.ShowDialog();

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.ShowDialog();
        }
    }
    }

