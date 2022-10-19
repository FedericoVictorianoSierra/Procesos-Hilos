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
            Sent();
        }

        void Sent()
        {
            streamw.WriteLine(txtMensaje.Text);//escribe
            streamw.Flush();
            txtMensaje.Clear();
        }

        void Sent(Image image)
        {
            streamw.WriteLine(image);//escribe
            streamw.Flush();
            txtMensaje.Clear();
        }

        public static byte[] Convertir_Imagen_Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

        public static Image Convertir_Bytes_Imagen(byte[] bytes)
        {
            if (bytes == null) return null;

            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;
            try
            {
                bm = new Bitmap(ms);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return bm;
        }

        void Information(string data)
        {
            streamw.WriteLine(data);
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
                client.Connect(textBoxIp.Text, 8000);
                
                if (client.Connected)
                {
                    Thread t = new Thread(Listen);

                    stream = client.GetStream();
                    streamw = new StreamWriter(stream);
                    streamr = new StreamReader(stream);
                    streamw.WriteLine(nick);
                    Information("Me he Conectado");
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
                //Application.Exit();
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

        public static string getIPv4()
        {
           using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
           {
                socket.Connect("10.0.1.20", 1337); // no importa a qué se conecte
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                return endPoint.Address.ToString(); //ipv4
           }
            throw new Exception("error getIPv4!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Servidor.IpServer = textBoxServer.Text;
            miHilo = new Thread(simulacionHilo);
            miHilo.Start();
        }

        private void CHAT_Load(object sender, EventArgs e)
        {
            textBoxIp.Text = getIPv4().ToString();
            textBoxServer.Text = getIPv4().ToString();
        }

        private void CHAT_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void txtMensaje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                Sent();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cargarImagen();
        }

        void cargarImagen()
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);
                    
                    Sent(pictureBox1.Image);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void textBoxIp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
