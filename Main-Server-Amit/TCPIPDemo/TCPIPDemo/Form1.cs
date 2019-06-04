using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace TCPIPDemo
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void Server_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13; // enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            status_txt.Invoke((MethodInvoker)delegate ()
            {
                status_txt.Text += e.MessageString;
                e.ReplyLine(string.Format("You said: {0},", e.MessageString));
            });
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            status_txt.Text += "Server is starting...";
            IPAddress ip = IPAddress.Parse(host_txt.Text);
            server.Start(ip, Convert.ToInt32(port_txt.Text));
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
        }
    }
}
