using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ByTCPcWD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                TcpClient tcpClient = new TcpClient()

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
