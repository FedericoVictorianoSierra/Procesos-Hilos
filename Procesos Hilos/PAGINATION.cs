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
        private List<Thread> miHilo = new List<Thread>();
        private List<int> TamanioPagina = new List<int>();
        private List<Color> colorSlot = new List<Color>();
        private Queue<int> iteration = new Queue<int>();
        private void Simular()
        {
            TamanioPagina.Add(rand.Next(1, 4));
            colorSlot.Add(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
            miHilo.Add(new Thread(simulacionHilo));
            listBox1.Items.Add(TamanioPagina.ElementAt(TamanioPagina.Count-1));
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
            for (int i = 0; i < TamanioPagina.Count; i++)// buscar entre todos los espacios de cada proceso
            {
                int num = TamanioPagina.ElementAt(i);
                if (TamanioPagina.ElementAt(i) <= vacios)//el que sea menor o igual a los desocupados
                {
                    if (miHilo.ElementAt(i).ThreadState == ThreadState.Unstarted)
                    {
                        for (int j = 0; j < Marco.Length; j++)//ocupar segun el tamaño de las paginas que contenga el proceso
                        {
                            if (Marco[j].BackColor == Color.Transparent && num > 0)//verificar que el espacio este vacio
                            {
                                Marco[j].BackColor = colorSlot.ElementAt(i);//ocupar el espacio indicando con color
                                num--;
                            }
                        }

                        //iniciar proceso
                        listBox1.Items.RemoveAt(0);
                        iteration.Enqueue(i);
                        miHilo.ElementAt(i).Start();
                    }
                }
                else
                {
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
                    Thread.Sleep(rand.Next(4000, 8000));
                    miHilo.ElementAt(0).Abort();
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
                    if (Marco[i].BackColor == colorSlot.ElementAt(0))
                    {
                        Marco[i].BackColor = Color.Transparent;
                    }
                }

                colorSlot.RemoveAt(0);
                TamanioPagina.RemoveAt(0);
                miHilo.RemoveAt(0);
                iteration.Dequeue();
                if (miHilo.Count > 0)
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
    }
}
