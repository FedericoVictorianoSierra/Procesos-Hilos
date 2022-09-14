﻿using System;
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

        private Queue<Thread> miHilo = new Queue<Thread>();
        void NuevoHilo()
        {
            miHilo.Enqueue(new Thread(simulacionHilo));//add
            try
            {
                miHilo.Peek().Start();
            } catch (ThreadStateException e)//Un thread que ha finalizado no se puede volver a utilizar
            {

            }
            //Console.WriteLine(miHilo.Count + " procesos en espera");
        }

        void simulacionHilo()
        {
            try
            {
                procesoImg.Location = new Point(109, 121);
                while (true)
                {
                    procesoImg.Location = new Point(procesoImg.Location.X + 1, procesoImg.Location.Y);
                    Thread.Sleep(1);
                    if (procesoImg.Location.X >= procesadorImg.Location.X)
                    {
                        miHilo.Dequeue().Abort();
                    }
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
