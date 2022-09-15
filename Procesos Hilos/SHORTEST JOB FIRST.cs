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
        private float[] tiempo = { 3.4f, 5.2f, 1.3f, 6.8f};
        private int numSelect;
        void NuevoHilo()
        {
            miHilo.Add(new Thread(simulacionHilo));//add
            miHilo.Add(new Thread(simulacionHilo));//add
            miHilo.Add(new Thread(simulacionHilo));//add
            miHilo.Add(new Thread(simulacionHilo));//add

            miHilo.ElementAt(CalcularMenor()).Start();
        }

        int CalcularMenor()
        {
            for (int i = 0; i < tiempo.Length; i++)
            {
                if (tiempo[i] == tiempo.Min())
                {
                    numSelect = i;
                    return i;
                }
            }
            return 0;
        }

         void simulacionHilo()
         {
             try
             {
                PictureBox img = null;
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
                 Console.WriteLine((string)abortException.ExceptionState);
             }
             finally
             {
                 if (miHilo.Count > 0)
                 {
                    //tiempo = tiempo.Skip(numSelect).ToArray();
                    tiempo[numSelect] = 1000;
                    Console.WriteLine(numSelect);
                    //miHilo.RemoveAt(numSelect);
                    try { 
                        miHilo.ElementAt(CalcularMenor()).Start();
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
