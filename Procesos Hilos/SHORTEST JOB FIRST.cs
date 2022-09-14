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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private List<Thread> miHilo = new List<Thread>();
        private float[] tiempo = new float[4];
        void NuevoHilo()
        {
            miHilo.Add(new Thread(simulacionHilo));//add
            miHilo.Add(new Thread(simulacionHilo));//add

            tiempo[0] = 3f;
            tiempo[1] = 5f;


            int posicionMenor = 0;
            for (int i = 0; i < tiempo.Length; i++)
            {
                if (tiempo[i] < tiempo[i] + 1)
                {
                    posicionMenor = i;
                }
                else {
                    posicionMenor = i+1;
                }
            }

            miHilo.ElementAt(posicionMenor).Start();

            try
            {
                tiempo.f
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
                    img1.Location = new Point(img1.Location.X + 1, procesadorImg.Location.Y);
                    Thread.Sleep(1);
                    if (img1.Location.X >= procesadorImg.Location.X)
                    {
                        miHilo.ElementAt(0).Abort();
                        miHilo.RemoveAt(0);
                    }
                }
            }
            catch (ThreadAbortException abortException)
            {
                Console.WriteLine((string)abortException.ExceptionState);
            }
            finally
            {
                if (miHilo.Count > 0)
                {
                    miHilo.Peek().Start();
                    Console.WriteLine(miHilo.Count + " procesos en espera");
                }
            }
        }


    }
}
