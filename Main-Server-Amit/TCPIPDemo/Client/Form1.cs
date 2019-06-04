using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void host_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        SimpleTcpClient client;
        
        private void connect_btn_Click(object sender, EventArgs e)
        {
            connect_btn.Enabled = false;
            
            client.Connect(host_client_txt.Text, Convert.ToInt32(port_Client_txt.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataRecived;
        }

        private void Client_DataRecived(object sender, SimpleTCP.Message e)
        {
            status_txt.Invoke((MethodInvoker)delegate ()
           {
               status_txt.Text += e.MessageString;
               
           });
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(massage_txt.Text, TimeSpan.FromSeconds(3));
        }

        

        /*private void btnConnect_Click(object sender, EventArgs e)
        {
          connect_btn.Enabled = false;
          System.Net.IPAddress ip = System.Net.IPAddress.Parse(host_client_txt.Text);
          client.Connect(host_client_txt.Text, Convert.ToInt32(port_Client_txt.Text));
        }*/
        
    }
}
