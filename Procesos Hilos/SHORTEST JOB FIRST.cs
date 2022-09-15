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
        private List<Thread> miHilo1 = new List<Thread>();
        private int[] tiempo = new int[4];
        //private int posicionMenor = 0;
        void NuevoHilo()
        {
            miHilo.Add(new Thread(simulacionHilo));//add
            miHilo1.Add(new Thread(simulacionHilo1));//add


            
            tiempo[0] = 3;
            tiempo[1] = 5;
            tiempo[2] = 1;
            tiempo[3] = 6;
            
            
            Array.Sort(tiempo);
            
            int menor = tiempo[0];
            int mayor = tiempo[3];
            MessageBox.Show("Menor número");
            MessageBox.Show(menor.ToString());
            MessageBox.Show("Mayor número");
            MessageBox.Show(mayor.ToString());
            MessageBox.Show("Menor a Mayor");
            MessageBox.Show(tiempo.ToString());

            Array.Reverse(tiempo);
            MessageBox.Show("Mayor a Menor");
            MessageBox.Show(tiempo.ToString());



            miHilo.ElementAt(menor).Start();

                try
                {
                    miHilo.ElementAt(menor).Start();
                }
                catch (ThreadStateException e)//Un thread que ha finalizado no se puede volver a utilizar
                {

                }
                Console.WriteLine(miHilo.Count + " procesos en espera");

            


         }

         void simulacionHilo()
         {
             try
             {
                 
                 while (true)
                 {
                     img1.Location = new Point(img1.Location.X + 1, img1.Location.Y);
                     Thread.Sleep(1);
                     if (img1.Location.X >= procesadorImg.Location.X)
                     {
                         /*miHilo.ElementAt(0).Abort();
                         miHilo.RemoveAt(0);*/

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
                    miHilo.ElementAt(tiempo[4]).Start();
                     Console.WriteLine(miHilo.Count + " procesos en espera");
                 }
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoHilo();
        }
    }
}
