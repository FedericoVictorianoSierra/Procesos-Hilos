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
    public partial class SEGMENTATION : Form
    {
        public SEGMENTATION()
        {
            InitializeComponent();
            Awake();
        }

        private Button[] Marco = new Button[6];//tamaño de segmento
        private PictureBox[] proceso = new PictureBox[9];
        private Thread[] miHilo = new Thread[9];
        Random rand = new Random();
        public int[] posY= new int[9];

        void Awake()
        {
            proceso[0] = i0;
            proceso[1] = i1;
            proceso[2] = i2;
            proceso[3] = i3;
            proceso[4] = i4;
            proceso[5] = i5;
            proceso[6] = i6;
            proceso[7] = i7;
            proceso[8] = i8;

            for (int i = 0; i < posY.Length; i++)
            {
                posY[i] = proceso[i].Location.Y;
            }
        }

        private void Start()
        {
            Marco[0] = segmento0;
            Marco[1] = segmento1;
            Marco[2] = segmento2;
            Marco[3] = segmento3;
            Marco[4] = segmento4;
            Marco[5] = segmento5;

            miHilo[0] = new Thread(simulacionHilo0);
            miHilo[1] = new Thread(simulacionHilo1);
            miHilo[2] = new Thread(simulacionHilo2);
            miHilo[3] = new Thread(simulacionHilo3);
            miHilo[4] = new Thread(simulacionHilo4);
            miHilo[5] = new Thread(simulacionHilo5);
            miHilo[6] = new Thread(simulacionHilo6);
            miHilo[7] = new Thread(simulacionHilo7);
            miHilo[8] = new Thread(simulacionHilo8);
        }
        private void Simular()
        {
            Start();
            for (int i = 0; i < proceso.Length; i++)
            {
                proceso[i].Visible = true;
                proceso[i].Location = new Point(139, posY[i]);
            }

            for (int i = 0; i < miHilo.Length; i++)
            {
                miHilo[i].Start();//iniciamos todos los hilos
            }
        }

        void Proceso(PictureBox image, int hilo)
        {
            bool Active = false;
            int j = 0;
            try
            {
                while (true)
                {
                    Thread.Sleep(10);
                    if (image.Location.X >= imgProcesador.Location.X)
                    {
                        for (int i = 0; i < Marco.Length; i++)
                        {
                            if(image.Size.Height == Marco[i].Size.Height)
                            {
                                if (Marco[i].BackColor == Color.Transparent && !Active)
                                {
                                    Marco[i].BackColor = image.BackColor;
                                    j = i;
                                    Active = true;
                                }
                            }
                        }
                        if(Active)
                        {
                            if(Marco[j].BackColor != image.BackColor)
                            {
                                Active = false;
                            }
                            else
                            {
                                image.Location = new Point(image.Location.X + 1, Marco[j].Location.Y);//avanzar
                                if (image.Location.X >= ram.Location.X)
                                {
                                    image.Visible = false;
                                    miHilo[hilo].Abort();
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
            Proceso(i0, 0);
        }
        void simulacionHilo1()
        {
            Proceso(i1, 1);
        }
        void simulacionHilo2()
        {
            Proceso(i2, 2);
        }
        void simulacionHilo3()
        {
            Proceso(i3, 3);
        }
        void simulacionHilo4()
        {
            Proceso(i4, 4);
        }

        void simulacionHilo5()
        {
            Proceso(i5, 5);
        }

        void simulacionHilo6()
        {
            Proceso(i6, 6);
        }

        void simulacionHilo7()
        {
            Proceso(i7, 7);
        }

        void simulacionHilo8()
        {
            Proceso(i8, 8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Simular();
        }

        private void SEGMENTATION_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
