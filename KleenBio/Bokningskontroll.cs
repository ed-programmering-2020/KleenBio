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

namespace KleenBio
{
    public partial class Bokningskontroll : Form
    {
        int bookID;
        public Bokningskontroll(int item)
        {
            InitializeComponent();
            bookID = item;
        }

        private void btnBokaplats_Click(object sender, EventArgs e)
        {
            BokadePlatser plats = new BokadePlatser();
            plats.book_ID = bookID;
            plats.NamnKund = tbxNamn.Text;
            plats.Telefon = tbxTelefon.Text;
            plats.EpostAdress = tbxEpost.Text;

            MySqlConnection connection;

            string ConnString = "SERVER=localhost;DATABASE=kinoprogramme;UID=olas;PASSWORD=ola123;";

            connection = new MySqlConnection(ConnString);
            connection.Open();

            MySqlCommand commando = new MySqlCommand();

            commando.Connection = connection;
            commando.ExecuteReader();

            connection.Close();

            MessageBox.Show("Plats bokad.");
            this.Close();

        }
    }
}
