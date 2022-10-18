using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Net.Sockets;
using System.IO;
using Transitions;

using System.Net;

namespace Procesos_Hilos
{
    public partial class CHAT : Form
    {
        static private NetworkStream stream;
        static private StreamWriter streamw;
        static private StreamReader streamr;
        static private TcpClient client = new TcpClient();
        static private string nick = "unknown";

        private delegate void DaddItem(String s);

        private void AddItem(String s)
        {
            listBox1.Items.Add(s);
        }
        private Thread miHilo;
        public CHAT()
        {
            InitializeComponent();
        }

        private Servidor Chat;
        void simulacionHilo()
        {
            Chat = new Servidor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nick = txtUsuario.Text;
            Conectar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            streamw.WriteLine(txtMensaje.Text);
            streamw.Flush();
            txtMensaje.Clear();
        }

        void Listen()
        {
            while (client.Connected)
            {
                try
                {
                    this.Invoke(new DaddItem(AddItem), streamr.ReadLine());
                }
                catch
                {
                    MessageBox.Show("No se ha podido conectar al servidor");
                    Application.Exit();
                }
            }
        }

        void Conectar()
        {
            try
            {
                if(textBoxIp.Text == "")
                {
                    client.Connect("127.0.0.1", 8000);
                }
                else
                {
                    client.Connect(textBoxIp.Text, 8000);
                }
                
                if (client.Connected)
                {
                    Thread t = new Thread(Listen);

                    stream = client.GetStream();
                    streamw = new StreamWriter(stream);
                    streamr = new StreamReader(stream);

                    streamw.WriteLine(nick);
                    streamw.Flush();

                    t.Start();
                }
                else
                {
                    MessageBox.Show("Servidor no Disponible");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Servidor no Disponible");
                Application.Exit();
            }
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            miHilo = new Thread(simulacionHilo);
            miHilo.Start();
        }

        private void CHAT_Load(object sender, EventArgs e)
        {
            textBoxIp.Text = GetLocalIPAddress().ToString();
        }
    }
}
