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

namespace Procesos_Hilos
{
    public partial class Priority : Form
    {
        public Priority()
        {
            InitializeComponent();
        }

        private List<Thread> miHilo = new List<Thread>();
        private List<int> tiempo = new List<int>();
        private List<PictureBox> img = new List<PictureBox>();

        private int numSelect;
        void NuevoHilo()
        {
            Random rand = new Random();
            miHilo.Clear();
            tiempo.Clear();
            img.Clear();

            miHilo.Add(new Thread(simulacionHilo));
            miHilo.Add(new Thread(simulacionHilo));
            miHilo.Add(new Thread(simulacionHilo));
            miHilo.Add(new Thread(simulacionHilo));

            tiempo.Add(rand.Next(1, 5));//0
            label1.Text = tiempo.ElementAt(0).ToString();
            tiempo.Add(rand.Next(1, 5));//1
            label2.Text = tiempo.ElementAt(1).ToString();
            tiempo.Add(rand.Next(1, 5));//2
            label3.Text = tiempo.ElementAt(2).ToString();
            tiempo.Add(rand.Next(1, 5));//3
            label4.Text = tiempo.ElementAt(3).ToString();

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
                if (numSelect == miHilo.Count)
                {
                    numSelect = 0;
                }

                tiempo.RemoveAt(numSelect);
                miHilo.RemoveAt(numSelect);
                img.RemoveAt(numSelect);

                if (miHilo.Count > 0)
                {
                    numSelect = CalcularMayorPrioridad();
                    miHilo.ElementAt(numSelect).Start();
                }
            }
        }

        int CalcularMayorPrioridad()
        {
            if (tiempo.Count == 0)
            {
                return -1; // devolver un índice predeterminado cuando la lista está vacía
            }

            int mayorPrioridad = int.MinValue;
            int indexMayorPrioridad = 0;

            // Recorrer la lista de tiempos para encontrar el mayor
            for (int i = 0; i < tiempo.Count; i++)
            {
                if (tiempo.ElementAt(i) > mayorPrioridad)
                {
                    mayorPrioridad = tiempo.ElementAt(i);
                    indexMayorPrioridad = i;
                }
            }

            return indexMayorPrioridad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoHilo();
        }

        private void Priority_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void img3_Click(object sender, EventArgs e)
        {

        }

        private void img2_Click(object sender, EventArgs e)
        {

        }

        private void img1_Click(object sender, EventArgs e)
        {

        }

        private void img0_Click(object sender, EventArgs e)
        {

        }
    }
}
