using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using MySql.Data.MySqlClient;

namespace KleenBio
{
    public partial class AdminPanel : Form
    {
        TcpClient clientTcp = new TcpClient();
        TcpListener listenerTcp;
        int port = 1035;
        public AdminPanel()
        {
            InitializeComponent();
            clientTcp.NoDelay = true;

            try
            {
                port = 1035;
                listenerTcp = new TcpListener(IPAddress.Any, port);
                listenerTcp.Start();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Fel port");
                return;
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }
    }


}
