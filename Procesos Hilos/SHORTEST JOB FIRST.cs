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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Procesos_Hilos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private List<Thread> miHilo = new List<Thread>();
        private List<float> tiempo = new List<float>();
        private List<PictureBox> img = new List<PictureBox>();

        private int numSelect;
        void NuevoHilo()
        {
            miHilo.Clear();
            tiempo.Clear();
            img.Clear();

            miHilo.Add(new Thread(simulacionHilo));
            miHilo.Add(new Thread(simulacionHilo));
            miHilo.Add(new Thread(simulacionHilo));
            miHilo.Add(new Thread(simulacionHilo));

            tiempo.Add(3);//0
            tiempo.Add(6);//1
            tiempo.Add(2);//2
            tiempo.Add(4);//3

            img.Add(img0);
            img.Add(img1);
            img.Add(img2);
            img.Add(img3);

            for (int i = 0; i < img.Count; i++)
            {
                img.ElementAt(i).Location = new Point(33, img.ElementAt(i).Location.Y);
            }       

            miHilo.ElementAt(CalcularMenor()).Start();
        }

        int CalcularMenor()
        {
            /*for (int i = 0; i < tiempo.Count; i++)
            {
                Console.WriteLine(tiempo.ElementAt(i));
            }*/
            for (int i = 0; i < tiempo.Count; i++)
            {
                if (tiempo.ElementAt(i) == tiempo.Min())
                {
                    //Console.WriteLine("Menor: " + i);
                    return (numSelect = i);
                }
            }
            return -1;
        }

         void simulacionHilo()
         {
             try
             {
                while (true)
                {
                    img.ElementAt(numSelect).Location = new Point(img.ElementAt(numSelect).Location.X + 1, img.ElementAt(numSelect).Location.Y);
                    Thread.Sleep(1);
                    if (img.ElementAt(numSelect).Location.X >= procesadorImg.Location.X)
                    {
                        miHilo.ElementAt(numSelect).Abort();
                    }
                }
             }
             catch (ThreadAbortException abortException)
             {
                 //Console.WriteLine((string)abortException.ExceptionState);
             }
             finally
             {
                tiempo.RemoveAt(numSelect);
                miHilo.RemoveAt(numSelect);
                img.RemoveAt(numSelect);
                if (miHilo.Count >= 1)
                {
                    miHilo.ElementAt(CalcularMenor()).Start();
                }
             }
         }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoHilo();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
