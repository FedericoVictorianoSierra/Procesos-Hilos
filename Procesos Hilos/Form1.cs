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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hilo();
        }
        Thread miHilo;
        void Hilo()
        {
            Thread miHilo = new Thread(simulacionHilo);
            miHilo.Start();
            Thread.Sleep(1000);
            // Abort newThread.
            /*Console.WriteLine("Main aborting new thread.");
            miHilo.Abort();
           
            // Wait for the thread to terminate.
            miHilo.Join();
            Console.WriteLine("New thread terminated - Main exiting.");*/
            /*new Thread(
                () =>
                {
                    while (true)
                    {
                        
                        procesoImg.Location = new Point(procesoImg.Location.X + 1, procesoImg.Location.Y);
                        //Thread.Sleep();
                        Console.WriteLine("EWjecutandose Hilo");
                    }
                }
                )
            { IsBackground = true }.Start();*/
        }

        void simulacionHilo()
        {
            try
            {
                while (true)
                {
                    procesoImg.Location = new Point(procesoImg.Location.X + 1, procesoImg.Location.Y);
                    Console.WriteLine("Ejecutandose Hilo");
                    Thread.Sleep(1);
                }
            }
            catch (ThreadAbortException abortException)
            {
                Console.WriteLine((string)abortException.ExceptionState);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
