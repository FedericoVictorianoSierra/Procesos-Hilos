using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Procesos_Hilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoHilo();
        }

        private Queue<Thread> miHilo = new Queue<Thread>();// cola de hilos de ejecución
        void NuevoHilo()
        {
            miHilo.Enqueue(new Thread(simulacionHilo));// se agrega un nuevo hilo de ejecución a la cola
            try
            {
                miHilo.Peek().Start(); // se inicia el primer hilo de la cola
            } catch (ThreadStateException e)// si un hilo ha finalizado, no se puede volver a utilizar
            {

            }
            Console.WriteLine(miHilo.Count + " procesos en espera");
        }

        void simulacionHilo()
        {
            procesoImg.Location = new Point(109, 121);// se ubica la imagen del proceso al inicio de la línea de procesamiento
            try
            {
                while (true)
                {
                    procesoImg.Location = new Point(procesoImg.Location.X + 1, procesoImg.Location.Y);
                    Thread.Sleep(1);
                    if (procesoImg.Location.X >= procesadorImg.Location.X)
                    {
                        miHilo.Dequeue().Abort();// se elimina el hilo actual de la cola y se aborta su ejecución
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
                    miHilo.Peek().Start();// si quedan hilos en la cola, se inicia el primero
                    Console.WriteLine(miHilo.Count + " procesos en espera");
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
