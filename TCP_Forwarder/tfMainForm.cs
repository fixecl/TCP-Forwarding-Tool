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
using System.Threading;
using System.Collections.Concurrent;

namespace TCP_Forwarding_Tool
{
    public partial class tfMainForm : Form
    {
        static Socket serverSocket;
        static Socket client1 = null;
        static Socket client2 = null;
        static bool isClient1Linked = false;
        static bool isClient2Linked = false;

        static ConcurrentQueue<byte[]> client1Data = new ConcurrentQueue<byte[]>();
        static ConcurrentQueue<byte[]> client2Data = new ConcurrentQueue<byte[]>();

        static String client1State="Client1：None";
        static String client2State="Client2：None";

        public tfMainForm()
        {
            InitializeComponent();
        }

        private void startNetBtn_Click(object sender, EventArgs e)
        {
            int port;
            try
            {
                bool isPortOK = Int32.TryParse(portTB.Text, out port);
                if (!isPortOK)
                {
                    MessageBox.Show("Port Error");
                    return;
                }

                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(IPAddress.Any, port));
                serverSocket.Listen(3);

                Thread listenThread = new Thread(listenPort);
                listenThread.IsBackground = true;
                listenThread.Start();
                
                displayTimer.Enabled = true;
                startNetBtn.Enabled = false;
                startNetBtn.Text = "已开始";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private static void listenPort()
        {
            while(true)
            {
                Socket client = serverSocket.Accept();
                if (isClient1Linked && isClient2Linked) 
                {
                    client.Close();
                    continue;
                }

                if(!isClient1Linked)
                {
                    client1 = client;
                    isClient1Linked = true;
                    client1State = "Client1：Connected";

                    Thread transmitTo2Thread = new Thread(transmitTo2Data);
                    transmitTo2Thread.IsBackground = true;
                    transmitTo2Thread.Start();
                }
                else if(!isClient2Linked)
                {
                    client2 = client;
                    isClient2Linked = true;
                    client2State = "Client2：Connected";

                    Thread transmitTo1Thread = new Thread(transmitTo1Data);
                    transmitTo1Thread.IsBackground = true;
                    transmitTo1Thread.Start();
                }

                /*
                if (isClient1Linked && isClient2Linked)
                {
                    client1.BeginReceive(to2Data, 0, to2Data.Length, SocketFlags.None, new AsyncCallback(transmitTo2Data), client1);
                    client2.BeginReceive(to1Data, 0, to1Data.Length, SocketFlags.None, new AsyncCallback(transmitTo1Data), client2);
                }
                 * */
            }
        }

        private static void transmitTo2Data()
        {
            
            while(true)
            {
                //Rev
                byte[] dat = new byte[4096];
                int length;

                try
                {
                    length = client1.Receive(dat);
                }
                catch(Exception ex)
                {
                    isClient1Linked = false;
                    client1 = null;
                    client1State = "Client1：None";
                    break;
                }
                if(length==0)
                {
                    isClient1Linked = false;
                    client1 = null;
                    client1State = "Client1：None";
                    break;
                }

                byte[] tmpd = new byte[length];
                for (int i = 0; i < length; i++)
                {
                    tmpd[i] = dat[i];
                }
                client1Data.Enqueue(tmpd);
                
                //Send
                try
                {
                    client2.Send(tmpd);
                }
                catch(Exception ex)
                {
                    isClient2Linked = false;
                    client2 = null;
                    client2State = "Client2：None";
                }
                Thread.Sleep(1);
            }
        }

        private static void transmitTo1Data()
        {
            while (true)
            {
                //Rev
                byte[] dat = new byte[4096];
                int length;
                if (!client2.Connected)
                {
                    break;
                }
                try
                {
                    length = client2.Receive(dat);
                }
                catch (Exception ex)
                {
                    isClient2Linked = false;
                    client2 = null;
                    client2State = "Client2：None";
                    break;
                }
                if(length==0)
                {
                    isClient2Linked = false;
                    client2 = null;
                    client2State = "Client2：None";
                    break;
                }
                byte[] tmpd = new byte[length];
                for (int i = 0; i < length; i++)
                {
                    tmpd[i] = dat[i];
                }
                client2Data.Enqueue(tmpd);
                
                
                //Send
                try
                {
                    client1.Send(tmpd);
                }
                catch (Exception ex)
                {
                    isClient1Linked = false;
                    client1 = null;
                    client1State = "Client1：None";
                }
                Thread.Sleep(1);

                
            }
        }

       

        private void displayTimer_Tick(object sender, EventArgs e)
        {
            client1GB.Text = client1State;
            client2GB.Text = client2State;
            
            while(client1Data.Count>0)
            {
                byte[] dat;
                client1Data.TryDequeue(out dat);
                revMsgTB1.AppendText(Encoding.ASCII.GetString(dat) + "\r\n");
                revHexTB1.AppendText(BytesToHex(dat, dat.Length) + "\r\n");
            }

            while (client2Data.Count > 0)
            {
                byte[] dat;
                client2Data.TryDequeue(out dat);
                revMsgTB2.AppendText(Encoding.ASCII.GetString(dat) + "\r\n");
                revHexTB2.AppendText(BytesToHex(dat, dat.Length) + "\r\n");
            }
        }

        public static string BytesToHex(byte[] b, int length)
        {
            string s = "";
            for (int i = 0; i < length; i++)
            {
                string cs = Convert.ToString(b[i], 16);
                if (cs.Length == 1)
                {
                    cs = "0" + cs;
                }
                s += (cs + " ");
            }
            return s;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            revMsgTB1.Clear();
            revMsgTB2.Clear();
            revHexTB1.Clear();
            revHexTB2.Clear();
        }
    }
}
