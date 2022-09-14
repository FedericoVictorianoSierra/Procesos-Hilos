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
using System.Collections;
using System.Collections.Concurrent;

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
        private Queue<Thread> miHilo = new Queue<Thread>();
        void NuevoHilo()
        {
            miHilo.Enqueue(new Thread(simulacionHilo));//add

            
            //Thread miHilo = new Thread(simulacionHilo);
            foreach (var hilo in miHilo)
            {


                if (!hilo.IsBackground)
                {
                    try
                    {
                        procesoImg.Location = new Point(109, 143);
                        hilo.Start();
                    }
                    catch (System.Threading.ThreadStateException ex)
                    {

                    }
                }

                /*Thread.Sleep(10000);
                Console.WriteLine("Ejecutando...");
                hilo.Abort();
                hilo.Join();*/
            }

            

            //Console.WriteLine("Ejecutando...");
            Console.WriteLine(miHilo.Count);
        }

        void simulacionHilo()
        {
            try
            {
                while (true)
                {
                    procesoImg.Location = new Point(procesoImg.Location.X + 1, procesoImg.Location.Y);
                    //Console.WriteLine("Ejecutandose Hilo");
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
            new Point(procesoImg.Location.X + 1, procesoImg.Location.Y);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
