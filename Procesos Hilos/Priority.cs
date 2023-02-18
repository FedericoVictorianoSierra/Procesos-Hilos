using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Procesos_Hilos
{
    public partial class Priority : Form
    {
        public Priority()
        {
            InitializeComponent();
        }

        private List<Thread> miHilo = new List<Thread>(); // Lista de hilos que se ejecutarán
        private List<int> prioridad = new List<int>(); // Lista de prioridades de los hilos
        private List<PictureBox> img = new List<PictureBox>(); // Lista de imágenes que representan a los hilos

        private const int numSelect = 0;
        void NuevoHilo()
        {
            miHilo.Clear();
            prioridad.Clear();
            img.Clear();

            // Se crean cuatro hilos con diferentes prioridades (1-4)
            miHilo.Add(new Thread(simulacionHilo));
            miHilo.Add(new Thread(simulacionHilo));
            miHilo.Add(new Thread(simulacionHilo));
            miHilo.Add(new Thread(simulacionHilo));

            // Se asignan las prioridades a cada hilo en orden descendente
            prioridad.Add(1);
            prioridad.Add(2);
            prioridad.Add(3);
            prioridad.Add(4);

            // Se agregan las imágenes correspondientes a cada hilo en orden descendente
            img.Add(img0);
            img.Add(img1);
            img.Add(img2);
            img.Add(img3);

            for (int i = 0; i < img.Count; i++)
            {
                img.ElementAt(i).Location = new Point(33, img.ElementAt(i).Location.Y);
            }

            // Se inicia el hilo con la prioridad más alta (el primero en la lista)
            miHilo.ElementAt(numSelect).Start();
        }

        // Método donde se ejecuta cada hilo
        void simulacionHilo()
        {
            try
            {
                while (true)
                {
                    // Se mueve la imagen correspondiente al hilo actual
                    img.ElementAt(numSelect).Location = new Point(img.ElementAt(numSelect).Location.X + 1, img.ElementAt(numSelect).Location.Y);
                    Thread.Sleep(1);
                    // Si la imagen llega al final, se aborta el hilo
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
                // Se elimina el hilo, su prioridad y su imagen de las listas correspondientes
                prioridad.RemoveAt(numSelect);
                miHilo.RemoveAt(numSelect);
                img.RemoveAt(numSelect);

                // Si aún quedan hilos en la lista, se inicia el siguiente hilo con la prioridad más alta
                if (miHilo.Count > 0)
                {
                    miHilo.ElementAt(numSelect).Start();
                }
            }
        }

        // Evento del botón "Iniciar"
        private void button1_Click(object sender, EventArgs e)
        {
            NuevoHilo();
        }

        private void Priority_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
