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

        void Hilo()
        {
            new Thread(
                () =>
                {
                    while (true)
                    {
                        
                        procesoImg.Location = new Point(procesoImg.Location.X + 1, procesoImg.Location.Y);
                        Thread.Sleep(1);
                    }
                }
                )
            { IsBackground = true }.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
