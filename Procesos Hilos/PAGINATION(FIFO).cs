using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Procesos_Hilos
{
    public partial class PAGINATION_FIFO_ : Form
    {
        public PAGINATION_FIFO_()
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

        private Queue<Thread> miHilo = new Queue<Thread>();
        private Queue<PictureBox> procesoImg = new Queue<PictureBox>();
        private Queue<int> espacio = new Queue<int>();
        Random rand = new Random();
        void StartPagination()
        {
            miHilo.Enqueue(new Thread(simulacionHilo));//add
            miHilo.Enqueue(new Thread(simulacionHilo));//add
            miHilo.Enqueue(new Thread(simulacionHilo));//add
            miHilo.Enqueue(new Thread(simulacionHilo));//add
            miHilo.Enqueue(new Thread(simulacionHilo));//add

            procesoImg.Enqueue(image1);
            procesoImg.Enqueue(image2);
            procesoImg.Enqueue(image3);
            procesoImg.Enqueue(image4);
            procesoImg.Enqueue(image5);

            espacio.Enqueue(1);
            espacio.Enqueue(2);
            espacio.Enqueue(3);
            espacio.Enqueue(4);
            espacio.Enqueue(5);

            image1.Location = new Point(36, image1.Location.Y);
            image2.Location = new Point(36, image2.Location.Y);
            image3.Location = new Point(36, image3.Location.Y);
            image4.Location = new Point(36, image4.Location.Y);
            image5.Location = new Point(36, image5.Location.Y);

            try
            {
                miHilo.Peek().Start();//tomar el primero de la cola
            }
            catch (ThreadStateException e)//Un thread que ha finalizado no se puede volver a utilizar
            {

            }
            Console.WriteLine(miHilo.Count + " procesos en espera");
        }

        void simulacionHilo()
        {
            try
            {
                while (true)
                {
                    procesoImg.Peek().Location = new Point(procesoImg.Peek().Location.X + 1, procesoImg.Peek().Location.Y);
                    Thread.Sleep(1);
                    if (procesoImg.Peek().Location.X >= imgProcesador.Location.X)
                    {
                        Color color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                        for (int i = 0; i < espacio.Peek(); i++)
                        {
                            Marco[i].BackColor = color;
                        }
                         
                        Thread.Sleep(2000);
                        miHilo.Dequeue().Abort();
                    }
                }
            }
            catch (ThreadAbortException abortException)
            {
                Console.WriteLine((string)abortException.ExceptionState);
            }
            finally
            {
                procesoImg.Dequeue();
                espacio.Dequeue();
                for (int i = 0; i < Marco.Length; i++)
                {
                    Marco[i].BackColor = Color.Transparent;
                }
                if (miHilo.Count > 0)
                {
                    miHilo.Peek().Start();
                    Console.WriteLine(miHilo.Count + " procesos en espera");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartPagination();
        }

        private void PAGINATION_FIFO__Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
