using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
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
        private List<float> tiempo = new List<float>();
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

            // Se generan tiempos de ejecución aleatorios para cada hilo
            tiempo.Add(rand.Next(1, 9));//0
            label1.Text = tiempo.ElementAt(0).ToString();// Muestra el tiempo de ejecución en la etiqueta correspondiente
            tiempo.Add(rand.Next(1, 9));//1
            label2.Text = tiempo.ElementAt(1).ToString();
            tiempo.Add(rand.Next(1, 9));//2
            label3.Text = tiempo.ElementAt(2).ToString();
            tiempo.Add(rand.Next(1, 9));//3
            label4.Text = tiempo.ElementAt(3).ToString();

            img.Add(img0);
            img.Add(img1);
            img.Add(img2);
            img.Add(img3);

            for (int i = 0; i < img.Count; i++)
            {
                img.ElementAt(i).Location = new Point(33, img.ElementAt(i).Location.Y);
            }

            // Se inicia el hilo con el tiempo de ejecución más corto
            miHilo.ElementAt(CalcularMenor()).Start();
        }

        // Función que calcula el índice del hilo con el tiempo de ejecución más corto
        int CalcularMenor()
        {
            for (int i = 0; i < tiempo.Count; i++)
            {
                if (tiempo.ElementAt(i) == tiempo.Min())
                {
                    return (numSelect = i);
                }
            }
            return -1;
        }

        // Función que simula la ejecución del hilo
        void simulacionHilo()
         {
             try
             {
                while (true)
                {
                    // Se mueve la imagen del hilo seleccionado
                    img.ElementAt(numSelect).Location = new Point(img.ElementAt(numSelect).Location.X + 1, img.ElementAt(numSelect).Location.Y);
                    Thread.Sleep(1);
                    // Si la imagen llega al final, se aborta el hilo correspondiente
                    if (img.ElementAt(numSelect).Location.X >= procesadorImg.Location.X)
                    {
                        miHilo.ElementAt(numSelect).Abort();
                    }
                }
             }
             catch (ThreadAbortException abortException)
             {
                 Console.WriteLine((string)abortException.ExceptionState);
             }
             finally
             {
                // Se eliminan los datos correspondientes al hilo que acaba de finalizar
                tiempo.RemoveAt(numSelect);
                miHilo.RemoveAt(numSelect);
                img.RemoveAt(numSelect);
                if (miHilo.Count >= 1)
                {
                    // Si quedan procesos por ejecutar, se inicia el hilo del proceso con el menor tiempo de ejecución
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
    }
}
