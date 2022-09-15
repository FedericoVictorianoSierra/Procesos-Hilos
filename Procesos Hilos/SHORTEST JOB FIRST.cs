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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
        private int numSelect = 0;
        PictureBox img = null;
        void NuevoHilo()
        {
            miHilo.Add(new Thread(simulacionHilo));//add
            miHilo.Add(new Thread(simulacionHilo));//add
            miHilo.Add(new Thread(simulacionHilo));//add
            miHilo.Add(new Thread(simulacionHilo));//add

            tiempo.Add(3);//0
            tiempo.Add(6);//1
            tiempo.Add(2);//2
            tiempo.Add(4);//3

            img0.Location = new Point(33, img0.Location.Y);
            img1.Location = new Point(33, img1.Location.Y);
            img2.Location = new Point(33, img2.Location.Y);
            img3.Location = new Point(33, img3.Location.Y);

            try
            {
                try
                {
                    miHilo.ElementAt(CalcularMenor()).Start();
                }
                catch (ArgumentOutOfRangeException ex)
                {

                }
            }
            catch (ThreadStateException e)//Un thread que ha finalizado no se puede volver a utilizar
            {

            }
        }

        int CalcularMenor()
        {
            for (int i = 0; i < tiempo.Count; i++)
            {
                if (tiempo.ElementAt(i) == tiempo.Min())
                {
                    numSelect = i;
                    Console.WriteLine("Menor: " + numSelect);
                    return i;
                }
            }
            Console.WriteLine("Error");
            return 0;
        }

         void simulacionHilo()
         {
             try
             {
                switch(numSelect)
                {
                    case 0: img = img0;
                        break;
                    case 1: img = img1;
                        break;
                    case 2: img = img2;
                        break;
                    case 3: img = img3;
                        break;
                }
                
                while (true)
                 {
                     img.Location = new Point(img.Location.X + 1, img.Location.Y);
                     Thread.Sleep(1);
                     if (img.Location.X >= procesadorImg.Location.X)
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
                 if (miHilo.Count > 0)
                 {
                    tiempo.RemoveAt(numSelect);
                    miHilo.RemoveAt(numSelect);
                    try
                    {
                        try {
                            miHilo.ElementAt(CalcularMenor()).Start();
                        }catch(ArgumentOutOfRangeException ex)
                        {

                        }
                    }
                    catch (ThreadStateException e)//Un thread que ha finalizado no se puede volver a utilizar
                    {

                    }
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
