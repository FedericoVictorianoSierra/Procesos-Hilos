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
        private List<int> espacio = new List<int>();
        private void Simular()
        {
            miHilo.Clear();
            espacio.Clear();

            miHilo.Add(new Thread(simulacionHilo0));
            miHilo.Add(new Thread(simulacionHilo1));
            miHilo.Add(new Thread(simulacionHilo2));
            miHilo.Add(new Thread(simulacionHilo3));
            miHilo.Add(new Thread(simulacionHilo4));

            espacio.Add(1);
            espacio.Add(2);
            espacio.Add(3);
            espacio.Add(4);
            espacio.Add(5);

            label1.Text = espacio.ElementAt(0).ToString();
            label2.Text = espacio.ElementAt(1).ToString();
            label3.Text = espacio.ElementAt(2).ToString();
            label4.Text = espacio.ElementAt(3).ToString();
            label5.Text = espacio.ElementAt(4).ToString();

            image0.Visible = true;
            image1.Visible = true;
            image2.Visible = true;
            image3.Visible = true;
            image4.Visible = true;

            image0.Location = new Point(29, image0.Location.Y);
            image1.Location = new Point(29, image1.Location.Y);
            image2.Location = new Point(29, image2.Location.Y);
            image3.Location = new Point(29, image3.Location.Y);
            image4.Location = new Point(29, image4.Location.Y);

            for (int i = 0; i < miHilo.Count; i++)
            {
                miHilo.ElementAt(i).Start();//iniciamos todos los hilos
            }
        }

        int EspacioLibre()
        {
            int libre = 0;
            for (int i = 0; i < Marco.Length; i++){
                if (Marco[i].BackColor == Color.Transparent){
                    libre++;
                }
            }
            return libre;
        }

        int TamanoOcupado(PictureBox image)
        {
            int tam = 0;
            for (int i = 0; i < Marco.Length; i++)
            {
                if (Marco[i].BackColor == image.BackColor)
                {
                    tam++;
                }
            }
            return tam;
        }

        void Proceso(PictureBox image, int proceso)
        {
            int coloreo = 0;
            try
            {
                while (true)
                {
                    Thread.Sleep(TimeSleep());
                    if (image.Location.X >= imgProcesador.Location.X)
                    {
                        if (EspacioLibre() >= espacio.ElementAt(proceso))
                        {
                            for (int i = 0; i < Marco.Length; i++)
                            {
                                if (Marco[i].BackColor == Color.Transparent)
                                {
                                    if(TamanoOcupado(image) < espacio.ElementAt(proceso))
                                    {
                                        Marco[i].BackColor = image.BackColor;
                                        coloreo++;
                                    }
                                }
                            }
                        }
                        if(image.Location.X >= ram.Location.X)
                        {
                            image.Visible = false;
                            miHilo.ElementAt(proceso).Abort();
                        }
                        else if(TamanoOcupado(image) == espacio.ElementAt(proceso))
                        {
                            image.Location = new Point(image.Location.X + 1, image.Location.Y);//avanzar
                        }
                        else
                        {
                            for (int i = 0; i < Marco.Length; i++)
                            {
                                if (Marco[i].BackColor == image.BackColor)
                                {
                                    Marco[i].BackColor = Color.Transparent;
                                }
                            }
                        }
                    }
                    else
                    {
                        image.Location = new Point(image.Location.X + 1, image.Location.Y);//avanzar
                    }
                }
            }
            catch (ThreadAbortException abortException)
            {
                Console.WriteLine((string)abortException.ExceptionState);
            }
            finally
            {
                for (int i = 0; i < Marco.Length; i++)
                {
                    if (Marco[i].BackColor == image.BackColor)
                    {
                        Marco[i].BackColor = Color.Transparent;
                    }
                }
            }
        }

        void simulacionHilo0()
        {
            Proceso(image0, 0);
        }

        void simulacionHilo1()
        {
            Proceso(image1, 1);
        }

        void simulacionHilo2()
        {
            Proceso(image2, 2);
        }

        void simulacionHilo3()
        {
            Proceso(image3, 3);
        }

        void simulacionHilo4()
        {
            Proceso(image4, 4);
        }

        int TimeSleep()
        {
            return 12;
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
