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

namespace Procesos_Hilos
{
    public partial class PAGINATION : Form
    {
        public PAGINATION()
        {
            InitializeComponent();
            Start();
        }

        private Button[] Marco = new Button[7];//tamaño de pagina
        private void Start()
        {
            Marco[0] = slot0;
            Marco[1] = slot1;
            Marco[2] = slot2;
            Marco[3] = slot3;
            Marco[4] = slot4;
            Marco[5] = slot5;
            Marco[6] = slot6;
        }
        Random rand = new Random();
        private Queue<Thread> miHilo = new Queue<Thread>();
        private Queue<int> TamanioPagina = new Queue<int>();
        private Queue<Color> colorSlot = new Queue<Color>();
        private Queue<int> iteration = new Queue<int>();

        private Queue<Thread> HiloEnEspera = new Queue<Thread>();
        private Queue<int> TamanioPaginaEnEspera = new Queue<int>();
        private Queue<Color> colorSlotEnEspera = new Queue<Color>();

        private List<Thread> HiloEnEjecucion = new List<Thread>();
        private List<int> TamanioPaginaEnEjecucion = new List<int>();
        private List<Color> colorSlotEnEjecucion = new List<Color>();

        private int listEjecutandose = -1;
        private void Simular()
        {
            TamanioPagina.Enqueue(rand.Next(1, 4));
            colorSlot.Enqueue(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
            miHilo.Enqueue(new Thread(simulacionHilo));
            //listBox1.Items.Add(TamanioPagina.ElementAt(TamanioPagina.Count-1));
            //listBox1.Items.Add(colorSlot.ElementAt(colorSlot.Count - 1));
            StartThread();
        }

        public void StartThread()
        {
            int vacios = 0;
            for (int k = 0; k < Marco.Length; k++)
            {
                if (Marco[k].BackColor == Color.Transparent)
                {
                    vacios++;//contar cuantos marcos estan vacios
                }
            }
            if(TamanioPagina.Count <= 0)
            {
                miHilo.Enqueue(HiloEnEspera.Dequeue());
                TamanioPagina.Enqueue(TamanioPaginaEnEspera.Dequeue());
                colorSlot.Enqueue(colorSlotEnEspera.Dequeue());
            }
            for (int i = 0; i < TamanioPagina.Count; i++)// deseocolar
            {
                int num = TamanioPagina.Peek();
                if (TamanioPagina.Peek() <= vacios && HiloEnEspera.Count <= 0)//el que sea menor o igual a los desocupados y no hayan hilos en espera
                {
                    if (miHilo.Peek().ThreadState == ThreadState.Unstarted)
                    {
                        for (int j = 0; j < Marco.Length; j++)//ocupar segun el tamaño de las paginas que contenga el proceso
                        {
                            if (Marco[j].BackColor == Color.Transparent && num > 0)//verificar que el espacio este vacio
                            {
                                Marco[j].BackColor = colorSlot.Peek();//ocupar el espacio indicando con color
                                num--;
                            }
                        }

                        //iniciar proceso
                        //listBox1.Items.RemoveAt(0);
                        //iteration.Enqueue(i);
                        TamanioPaginaEnEjecucion.Add(TamanioPagina.Dequeue());
                        colorSlotEnEjecucion.Add(colorSlot.Dequeue());
                        HiloEnEjecucion.Add(miHilo.Dequeue());
                        listEjecutandose++;
                        HiloEnEjecucion.ElementAt(listEjecutandose).Start();
                    }
                }
                else
                {
                    HiloEnEspera.Enqueue(miHilo.Dequeue());
                    TamanioPaginaEnEspera.Enqueue(TamanioPagina.Dequeue());
                    colorSlotEnEspera.Enqueue(colorSlot.Dequeue());
                    //se va a espera
                    //break;
                }
            }
        }

        public void simulacionHilo()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(/*rand.Next(4000, 8000)*/ 4000);
                    HiloEnEjecucion.ElementAt(listEjecutandose).Abort();
                }
            }
            catch (ThreadAbortException abortException)
            {
                //Console.WriteLine((string)abortException.ExceptionState);
            }
            finally
            {
                for (int i = 0; i < Marco.Length; i++)
                {
                    if (Marco[i].BackColor == colorSlotEnEjecucion.ElementAt(listEjecutandose))
                    {
                        Marco[i].BackColor = Color.Transparent;
                    }
                }

                //colorSlotEnEjecucion.RemoveAt(0);
                //TamanioPaginaEnEjecucion.RemoveAt(0);
                //HiloEnEjecucion.RemoveAt(0);
                //iteration.Dequeue();
                if (miHilo.Count > 0 || HiloEnEspera.Count > 0)
                {
                    //dar paso al siguiente
                    StartThread();
                }
            }
        }

        private void PAGINATION_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simular();
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            /*Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                Font f = new Font("Arial", 12, FontStyle.Regular);
                Brush b = new SolidBrush(((Color)((ListBox)sender).Items[e.Index]));
                g.DrawString(TamanioPagina.ElementAt(iteration.Peek()).ToString(), f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 50, rect.Y + 5, rect.Width - 10, rect.Height - 5);
            }*/
        }
    }
}
