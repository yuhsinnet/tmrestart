using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;


namespace ByTCPcWD
{
    public partial class Form1 : Form
    {
        int countdown = 30;
        const int countdownC = 30;



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
            timer1.Stop();
            try
            {
                TryConnect();

            }
            catch (SocketException Sockete)
            {
                textBox1.AppendText("Tcp Error" + Environment.NewLine);
                //throw;
            }

        }

        private void TryConnect()
        {
            textBox1.AppendText("Tcp try" + Environment.NewLine);
            //TcpClient tcpClient = new TcpClient("192.168.100.9", 4001);


            TcpClient tcpClient = new TcpClient();
            tcpClient.BeginConnect("192.168.100.4", 4001, new AsyncCallback(ConnectED), tcpClient);
        }

        private void ConnectED(IAsyncResult ar)
        {
            //throw new NotImplementedException();

            TcpClient Tcp_C = (TcpClient)ar.AsyncState;

            WriteTextSafe("Tcp Connected = " + Tcp_C.Connected + Environment.NewLine, textBox1);

            if (Tcp_C.Connected)
            {
                Tcp_C.Close();

                timer1.Start();
            }
            else
            {
                //timer2.Enabled = true;
                timer2.Interval = 1000;
                timer2.Enabled = true;
                //Rest();

                WriteTextSafe("Restart DVR By test !!!" + Environment.NewLine, textBox1);

            }


        }

        private delegate void SafeCallDelegate(string text, TextBox TB);
        private void WriteTextSafe(string text, TextBox TB)
        {
            if (textBox1.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                TB.Invoke(d, new object[] { text, TB });
            }
            else
            {
                TB.AppendText(text);
            }
        }
        void Rest()
        {


            TcpClient tcpcc = new TcpClient("192.168.90.101", 1500);

            do
            {

                System.Threading.Thread.Sleep(10);

            } while (!tcpcc.Connected);

            WriteToPLC("PC2=RESTART", tcpcc);
            tcpcc.Close();

            WriteTextSafe("Restart DVR" + Environment.NewLine, textBox1);

        }



        private void Timer2_Tick(object sender, EventArgs e)
        {

            textBox2.Text = countdown.ToString();
            if (countdown-- <= 1)
            {
                countdown = countdownC;

                TryConnect();
            }


        }

        public string WriteToPLC(string cmd, TcpClient tcpc) //TCP 讀寫核心
        {
            try
            {

                byte[] sendBuf = Encoding.ASCII.GetBytes((char)2 + cmd + (char)3);
                String Str = string.Empty;


                tcpc.GetStream().Write(sendBuf, 0, sendBuf.Length);
                System.Threading.Thread.Sleep(100);
                if (tcpc.GetStream().DataAvailable == true)
                {

                    Byte[] rec_buf = new byte[tcpc.Available];
                    tcpc.GetStream().Read(rec_buf, 0, rec_buf.Length);
                    Str = Encoding.ASCII.GetString(rec_buf);
                }

                return Str;
            }
            catch (SocketException Sockete)
            {
                return string.Empty;
            }





        }

        private void Button1_Click(object sender, EventArgs e)
        {

            button1.Text = timer2.Enabled.ToString();


            timer2.Enabled = true;
        }
    }
}
