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
    public partial class Form3:Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoHilo();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private List<Thread> miHilo = new List<Thread>();
        Random rand = new Random();
        void NuevoHilo()
        {
            miHilo.Clear();
            miHilo.Add(new Thread(simulacionHilo0));
            miHilo.Add(new Thread(simulacionHilo1));
            miHilo.Add(new Thread(simulacionHilo2));
            miHilo.Add(new Thread(simulacionHilo3));

            proceso1.Visible = true;
            proceso2.Visible = true;
            proceso3.Visible = true;
            proceso4.Visible = true;

            proceso1.Location = new Point(75, proceso1.Location.Y);
            proceso2.Location = new Point(75, proceso2.Location.Y);
            proceso3.Location = new Point(75, proceso3.Location.Y);
            proceso4.Location = new Point(75, proceso4.Location.Y);

            for (int i = 0; i < miHilo.Count; i++)
            {
                miHilo.ElementAt(i).Start();
            }
        }

        void simulacionHilo0()
        {
            while (true)
            {
                proceso1.Location = new Point(proceso1.Location.X + 1, proceso1.Location.Y);
                Thread.Sleep(15);
                if (proceso1.Location.X >= procesadorImg.Location.X)
                {
                    Thread.Sleep(rand.Next(1500, 4000));
                    proceso1.Visible = false;
                    miHilo.ElementAt(0).Abort();
                }
            }
        }

        void simulacionHilo1()
        {
            while (true)
            {
                proceso2.Location = new Point(proceso2.Location.X + 1, proceso2.Location.Y);
                Thread.Sleep(15);
                if (proceso2.Location.X >= procesadorImg.Location.X)
                {
                    Thread.Sleep(rand.Next(1500, 4000));
                    proceso2.Visible = false;
                    miHilo.ElementAt(1).Abort();
                }
            }
        }

        void simulacionHilo2()
        {
            while (true)
            {
                proceso3.Location = new Point(proceso3.Location.X + 1, proceso3.Location.Y);
                Thread.Sleep(15);
                if (proceso3.Location.X >= procesadorImg.Location.X)
                {
                    Thread.Sleep(rand.Next(1500, 4000));
                    proceso3.Visible = false;
                    miHilo.ElementAt(2).Abort();
                }
            }
        }

        void simulacionHilo3()
        {
            while (true)
            {
                proceso4.Location = new Point(proceso4.Location.X + 1, proceso4.Location.Y);
                Thread.Sleep(15);
                if (proceso4.Location.X >= procesadorImg.Location.X)
                {
                    Thread.Sleep(rand.Next(1500, 4000));
                    proceso4.Visible = false;
                    miHilo.ElementAt(3).Abort();
                }
            }
        }
    }
}
