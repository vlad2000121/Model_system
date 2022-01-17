using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;



namespace _1_лаб_модел
{
   
    public partial class Form1 : Form
    {
        //3 лаб
     


        int Ea_moment = 0;
        int Eb_moment = 0;
        Form2 form2; 
        int Ea_max;
        int Eb_max;
        int Er_max;
        int Ec_max=1000;
        int t1;
        int t2;
        int t3;
        int t4;
        int t5;
        int t6;
        int br = 0;
        DataGridView gridView;
        int i = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint_1(object sender, PaintEventArgs g)
        {
            //AB1
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), 5);
            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.RoundAnchor;
            g.Graphics.DrawLine(pen, 95, 147, 95, 97);


            //AB2
            Pen pen1 = new Pen(Color.FromArgb(255, 0, 0, 255), 5);
            pen1.StartCap = LineCap.ArrowAnchor;
            pen1.EndCap = LineCap.RoundAnchor;
            g.Graphics.DrawLine(pen1, 505, 147, 505, 97);


            //AB1
            Pen pen2 = new Pen(Color.FromArgb(255, 0, 0, 255), 5);
            pen2.StartCap = LineCap.ArrowAnchor;
            pen2.EndCap = LineCap.RoundAnchor;
            g.Graphics.DrawLine(pen2, 95, 275, 95, 225);


            //AB2
            Pen pen3 = new Pen(Color.FromArgb(255, 0, 0, 255), 5);
            pen3.StartCap = LineCap.ArrowAnchor;
            pen3.EndCap = LineCap.RoundAnchor;
            g.Graphics.DrawLine(pen3, 505, 275, 505, 225);
        }

        //public int add_A(/*int Eb_moment,*/ int t1)
        //{

        //    Ea_label.Text = Ea_textBox.Text;

        //    //label21.Text = Eb_moment.ToString();
        //    //  Thread.Sleep(500);
        //    if (Ea_moment >= 0 && Ea_moment <= Ea_max)
        //    {
        //        Thread.Sleep(t1 * 10);
        //        Ea_moment++;
        //        Ea_label.Text = Convert.ToString(Ea_moment);
        //        progressBar1.Value = Ea_moment;
        //    }
        //    return Ea_moment;

        //}

        //public void add_B(/*int Eb_moment,*/ int t1)
        //{

        //    Ea_label.Text = Ea_textBox.Text;

        //    //label21.Text = Eb_moment.ToString();
        //    //  Thread.Sleep(500);
        //    if (Ea_moment >= 0 && Eb_moment <= Eb_max && Eb_moment >= 0)
        //    {
        //        Thread.Sleep(t1 * 10);
        //        Ea_moment--;
        //        Eb_moment++;
        //        Eb_label.Text = Convert.ToString(Eb_moment);
        //        progressBar2.Value = Eb_moment;
        //        progressBar1.Value = Ea_moment;
        //    }
        //    //return Eb_moment;

        //}

        //int n = 0;

        //async void AB1(int t1)
        //{
           
        //    while (Ea_moment <= 0)
        //    {
        //        n++;
                
        //        Eb_label.Text= n.ToString();
        //        progressBar1.Value = Ea_moment;
        //        Ea_moment--;
        //        await Task.Delay(1);
        //    }
        //}



        ////Наполнение А
        //public void button1_Click(object sender, EventArgs e)
        //{
        //    Ea_max = Convert.ToInt32(Ea_textBox.Text);
        //    Eb_max = Convert.ToInt32(Eb_textBox.Text);
        //    progressBar1.Maximum = Ea_max;
        //    progressBar2.Maximum = Eb_max;

        //    t1 = Convert.ToInt32(t1_textBox.Text);// в мс тут можно изменить коэф для того что бы изменить скорость 

        //    AB1(t1);

        //    //while (i < 20)
        //    //{
        //    //    Ea_label.Text = Convert.ToString(Ea_moment);
        //    //    Eb_label.Text = Convert.ToString(Ea_moment);
        //    //    /*await Task.Run(() =>  */
        //    //    //add_A(/*Ea_max,*/ t1);
        //    //    int x = await Task.Run(() => add_A(t1));
        //    //    progressBar1.Value = Ea_moment;
        //    //    /*  await Task.Run(() => */
        //    //    //add_B(/*Ea_max,*/ t1);

        //    //    i++;
        //    //}


        //}
        

        private async void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            A();
            new Thread(() =>
            {
                BeginInvoke((MethodInvoker)(async () =>
                {
                    modeling();
                }));


            }).Start();

         //   await Task.Run(() => { modeling(); });

        }

       


        async void pathAB1(int time, int hoarderA, int hoarderB, int statAB1)
        {
            if (time % t2 == 0) {
                if (statAB1 == 1)
                {
                    statAB1 = 0;
                }
                if (hoarderA > 0)
                {
                     hoarderA--;
                     statAB1++;
                     hoarderB++;
                }
                
            }
        }

        async void pathAB2(int time, int hoarderA, int hoarderB, int statAB2)
        {
            
                if (statAB2 == 1)
                {
                    statAB2 = 0;
                }
                if (hoarderA > 0)
                {
                    hoarderA--;
                    statAB2++;
                    hoarderB++;
            }

            
        }

        //2 лаб
        public class Generator
        {
            private static readonly Random ExponentialRandom = new Random();

            private static readonly Random NormalRandom = new Random();

            public static double ExponentialDistributionFunction(double lambda)
                => -(1 / lambda) * Math.Log(ExponentialRandom.NextDouble());

            public static double NormalDistributionFunction(double sigma, double m)
                => (sigma * Math.Cos(2 * Math.PI * NormalRandom.NextDouble())
                    * Math.Sqrt(-2 * Math.Log(NormalRandom.NextDouble()))) + m;
        }



        async void modeling() {
            int timeA=0;
            //int statAB1 = 0;
            //int statAB2 = 0;
            int time=0;
            int count_bufferB = 0;
            int time_bufferB = 0;
            int queue_lengthA = 0;//длина очереди
            int queue_lengthB = 0;//длина очереди
            double probability = 0;
            double d1 = 0;
            double d2 = 0;
            double lamba = 0.1;
            double sigma = 3;
            double m1 = 20;
            double m2 = 25;
            double m3 = 15;

            t1 = Convert.ToInt32(t1_textBox.Text);
            t2 = Convert.ToInt32(t2_textBox.Text);
            t3 = Convert.ToInt32(t3_textBox.Text);
            t4 = Convert.ToInt32(t4_textBox.Text);
            t5 = Convert.ToInt32(t5_textBox.Text);
            t6 = Convert.ToInt32(t6_textBox.Text);
            double t1gaus = Math.Ceiling(Generator.ExponentialDistributionFunction(lamba));         //2 лаб
            double t2gaus = Math.Ceiling(Generator.NormalDistributionFunction(sigma, m1));
            double t3gaus = Math.Ceiling(Generator.NormalDistributionFunction(sigma, m1));
            double t4gaus = Math.Ceiling(Generator.NormalDistributionFunction(sigma, m2));
            double t5gaus = Math.Ceiling(Generator.NormalDistributionFunction(sigma, m2));
            double t6gaus = Math.Ceiling(Generator.NormalDistributionFunction(sigma, m3));
            //int hoarderA = 0;//накопитель А
            int hoarderB = 0;
            int hoarderC = 0;
            int hoarderA = 0;
            int bufferB = 0;

            int statAB1 = 0;
            int statAB2 = 0;
            int statBC1 = 0;
            int statBC2 = 0;


            while (hoarderC < 1000) {
                time++;
                if (hoarderA < Ea_max)
                {
                    if (time % t1gaus == 0)
                    {
                        hoarderA++;
                    }
                } else if (hoarderA >= Ea_max)
                {
                 //   MessageBox.Show("ошибка!");
                    
                }


                if (time % t2gaus/*t2*/ == 0 )   //AB1
                    {
                        //pathAB1(time, hoarderA, hoarderB, statAB1);
                        //if (time % t2 == 0)
                        //{
                            if (statAB1 == 1)
                            {
                                statAB1 = 0;
                            }
                            if (hoarderA > 0 /*&& hoarderB < Eb_max*/ /*&& bufferB>Er_max*/)
                            {
                                hoarderA--;
                                statAB1++;

                            if (hoarderB >= Eb_max)
                            {
                            //if (bufferB < Er_max) bufferB++;
                                if (bufferB < Er_max)
                                    {
                                      bufferB++;
                                      count_bufferB++;
                                timebuf_textbox.Text = Convert.ToString(count_bufferB);         // количество подключений буфера
                            }
                            }
                            if (hoarderB < Eb_max)
                            {
                                hoarderB++;
                            }

                    }

                    }
                    if (time % t3gaus /*t3*/ == 0 )         //AB2    
                    {
                        //pathAB2(time, hoarderA, hoarderB, statAB2);


                        if (statAB2 == 1)
                        {
                            statAB2 = 0;
                        }
                        if (hoarderA > 0/*&& hoarderB > Eb_max && bufferB > Er_max*/)
                          {
                                hoarderA--;
                             
                                statAB2++;

                             if (hoarderB >= Eb_max)
                               {
                                    if (bufferB < Er_max)
                                     {
                                        bufferB++;
                                        count_bufferB++;
                                timebuf_textbox.Text = Convert.ToString(count_bufferB);  // количество подключений буфера
                            }
                               }
                             if (hoarderB < Eb_max) { 
                                hoarderB++;
                                }

                        }
                    }

                      if (hoarderB > 0)  //buffer b изменение вп=ремени
                      {
                        //if (bufferB > Er_max)
                        //{
                        //time_bufferB++;
                        //timebufferB.Text = Convert.ToString(time_bufferB);
                        //}
                          if (bufferB > Er_max / 2)
                          {
                        //t4 = t6;
                        //t5 = t6;
                        t4gaus = t6gaus;
                        t5gaus = t6gaus;
                          }
                          else { 
                        //t4 = Convert.ToInt32(t4_textBox.Text);
                        //  t5 = Convert.ToInt32(t5_textBox.Text);
                        t4gaus= Math.Ceiling(Generator.NormalDistributionFunction(sigma, m2));
                        t5gaus= Math.Ceiling(Generator.NormalDistributionFunction(sigma, m2)); 
                    }



                    if (time % t4gaus == 0)         //BC1
                    {

                      if (statBC1 == 1)
                      {
                          statBC1 = 0;
                      }

                        if (bufferB > 0) 
                        { 
                            bufferB--;
                            statBC1++;
                            hoarderC++;
                        }
                        else if (hoarderB > 0 && hoarderB < Eb_max && bufferB == 0) 
                        { 
                            hoarderB--; 
                            statBC1++;
                            hoarderC++;
                        }
                    
                        
                    }

                    if (time % t5gaus == 0)               //BC2
                    {
                       


                        if (statBC2 == 1)
                        {
                            statBC2 = 0;
                        }

                        if (bufferB > 0)
                        {
                            bufferB--;
                            statBC2++;
                            hoarderC++;
                        }
                        else if (hoarderB > 0 && hoarderB < Eb_max && bufferB == 0)
                        {
                            hoarderB--;
                            statBC2++;
                            hoarderC++;
                        }

                    }
                }

                      //Время работы буффера
                if (bufferB > 0) 
                {
                    time_bufferB++;
                    timebuffer_textBox1.Text = Convert.ToString(time_bufferB);

                }



                //Длина очереди
                queue_lengthA += hoarderA;
                queue_lengthB += hoarderB;
                if (hoarderC > 990)
                {
                    //Длина очереди
                  
                    d1 = (double)queue_lengthA / time;
                    d2 = (double)queue_lengthB / time;
                    if (d1 == 0) d1 = 1;
                    if (d2 == 0) d2 = 1;
                    queue_lengthA_textBox.Text = Convert.ToString(Math.Ceiling(d1));
                    queue_lengthB_textBox1.Text = Convert.ToString(Math.Ceiling(d2));

                    //Вероятность подключения
                    
                    probability =(double) count_bufferB / hoarderC*100;
                    probability_textBox1.Text = Convert.ToString(Math.Ceiling(probability));

                }


                dataGridView1.Rows.Add(/*$"{time} сек."*/time, statAB1, statAB2, statBC1, statBC2,hoarderA,hoarderB,hoarderC,bufferB );
                
            }
        
        }

      

        void A()
        {
            Ea_max = Convert.ToInt32(Ea_textBox.Text);
            Eb_max = Convert.ToInt32(Eb_textBox.Text);
            Er_max = Convert.ToInt32(Er_textBox.Text);
            progressBar1.Maximum = Ea_max;
            progressBar2.Maximum = Eb_max;
            progressBar4.Maximum = Er_max;
            progressBar3.Maximum = Ec_max;
            Ea_label.Text = Ea_moment.ToString();

           

        }

        int InputA = 0;
        int a = 0; 
        async void inA()
        {
            t1= Convert.ToInt32(t1_textBox.Text);
            
            while (a < Ea_max) {
               
             
                a++;
                InputA++;
                Ea_label.Text = a.ToString();
                progressBar1.Value = a;
                await Task.Delay(10);//1100  t1
                Ea_inA.Text = Convert.ToString(InputA);
            }
        }

        
        bool flagAB1 = false;
        int packagesAB1 = 0; // количество пакетов которых передал пакет АВ1

        async void AB1()
        {
            if (a > 0 && br < Er_max)
            {
                t2 = Convert.ToInt32(t2_textBox.Text);

                flagAB1 = true;
                if (a > 0)
                {
                    a--;
                }
                else
                {
                    if (a < 0) a = 0;

                }
                Ea_label.Text = a.ToString();
               // if (a < 0) a = 0;

            //    Ea_label.Text = a.ToString();
                progressBar1.Value = a;
                packAB1.Text = "1";
                await Task.Delay(20);//2000  t2

                if (b < Eb_max)
                {
                    b++;
                    packagesAB1++; // количество пакетов которых передал пакет АВ1
                }
                else
                {
                    if (br < Eb_max) { reserveB(); }
                    packagesAB1++;

                }

                packAB1.Text = "0";
                flagAB1 = false;
                Eb_packagesAB1.Text = Convert.ToString(packagesAB1);

                Eb_label.Text = b.ToString();
                progressBar2.Value = b;

                //await Task.Run(() => { BC1(); });
                //Eb_label.Text = b.ToString();
                //progressBar2.Value = b;
                if (c <= Ec_max)
                {
                    new Thread(() =>
                {
                    BeginInvoke((MethodInvoker)(() =>
                    {

                        BC1();
                    }));
                }).Start();
                }
            }
        }


        bool flagAB2 = false;
        int packagesAB2 = 0; // количество пакетов которых передал пакет АВ1

        async void AB2()
        {
            if (a > 0 && br < Er_max)//b< Eb_max
            {
                t3 = Convert.ToInt32(t3_textBox.Text);

                flagAB2 = true;
                if (a > 0)
                {
                    a--;
                } else
                {
                    if (a < 0) a = 0;

                }
                Ea_label.Text = a.ToString();
               

              //  Ea_label.Text = a.ToString();
                progressBar1.Value = a;
                packAB2.Text = "1";

                // await Task.Delay(20);//2000   //t3
                //n++;
                //packagesAB2++;          // количество пакетов которых передал пакет АВ1
                //packAB2.Text = "0";
                //flagAB2 = false;




                if (b < Eb_max)
                {
                    b++;
                    packagesAB2++;  // количество пакетов которых передал пакет АВ2
                }
                else
                {              
                    if (br < Eb_max) { reserveB(); }
                    packagesAB2++;
                }
                packAB2.Text = "0";
                    flagAB2 = false;
                Eb_packagesAB2.Text = Convert.ToString(packagesAB2);


                //  await Task.Delay(1000);




                Eb_label.Text = b.ToString();
                progressBar2.Value = b;

               
               // await Task.Run(() => { BC2(); });

                if (c <= Ec_max)
                {
                    new Thread(() =>
                {
                    BeginInvoke((MethodInvoker)(() =>
                    {

                        BC2();
                    }));
                }).Start();
                }
            }
        }


        int recdAB1 = 0;  // принято пакетов по каналу АB1
        int recdAB2 = 0;  // принято пакетов по каналу АB2

        int b= 0;
      
        async void inB()
        {

            while (br < Er_max)
            {
                // n++;

                // AB1();
                //if (flagAB1 == true) { packAB1.Text = "1"; } else { packAB1.Text = "0"; }
                if (br < Er_max)
                {
                    new Thread(() =>
                    {
                        BeginInvoke((MethodInvoker)(() =>
                       {
                           AB1();

                       }));
                    }).Start();
                    new Thread(() =>
                    {
                        BeginInvoke((MethodInvoker)(() =>
                        {

                            AB2();
                        }));
                    }).Start();
                    //if (c <= Ec_max)
                    //{
                    //    new Thread(() =>
                    //{
                    //    BeginInvoke((MethodInvoker)(() =>
                    //    {

                    //        BC1();
                    //    }));
                    //}).Start();
                    //}
                    //if (c <= Ec_max)
                    //{
                    //    new Thread(() =>
                    //    {
                    //        BeginInvoke((MethodInvoker)(() =>
                    //        {

                    //            BC2();
                    //        }));
                    //    }).Start();
                    //}

                    //await Task.Run(() => { AB1(); });
                    //await Task.Run(() => { AB2(); });
                }
                //else
                //{
                //    reserveB();
                //}

                Eb_label.Text = b.ToString();
                progressBar2.Value = b;
              //  await Task.Delay(1000);
            }
           // await Task.Delay(50);
        }

      

         void reserveB() {
            CheckForIllegalCrossThreadCalls = false;
            try
            {
                if (b == Eb_max && br != Er_max)
                {
                    if (br != Er_max)
                    {
                        br++;
                        Br_label.Text = Convert.ToString(br);
                        progressBar4.Value = br;
                    }
                    else
                    {
                     
                        //    a--;
                        //    packagesAB2--;
                        //    packagesAB1--;
                    }
                }
            }
            catch
            { MessageBox.Show("Буфер переполнен!!!"); }
        }


        /// <summary>
        /// Когда буфер будет заполнен изменить т5 на т6 тут и посмотреть если будет на половину заполнен то поменять на т6
        /// </summary>


        int c = 0;
        int packagesBC1 = 0;
        async void BC1()
        {
            if (b > 0 && c < Ec_max)
            {
                t4 = Convert.ToInt32(t4_textBox.Text);
               t6= Convert.ToInt32(t6_textBox.Text);
                //flagAB1 = true;
                if (b > 0)
                {
                    b--;
                }
                else {
                    if (b < 0) b = 0;
                }
                Eb_label.Text = b.ToString();
               

                //    Ea_label.Text = a.ToString();
                progressBar2.Value = b;
                packBC1.Text = "1";

                if (br > Er_max / 2) { 
                    t4 = t6; }
                else {
                    t4 = t4;
                }
                await Task.Delay(2000);//2000     t4

                
                 if ( c < Ec_max)   c++;
                    packagesBC1++; // количество пакетов которых передал пакет АВ1
               

                packBC1.Text = "0";
                //flagAB1 = false;
                Ec_packagesBC1.Text = Convert.ToString(packagesBC1);

                Ec_label.Text = c.ToString();
                progressBar3.Value = c;
                //Eb_label.Text = n.ToString();
                //progressBar2.Value = n;
            }
        }


        int packagesBC2 = 0;
        async void BC2()
        {
            if (b > 0 && c < Ec_max)
            {
                t5 = Convert.ToInt32(t5_textBox.Text);
                t6 = Convert.ToInt32(t6_textBox.Text);
                //flagAB1 = true;
                if (b > 0)
                {
                    b--;
                }
                else
                {
                    if (b < 0) b = 0;
                }
                Eb_label.Text = b.ToString();
              //  if (b < 0) b = 0;

                //    Ea_label.Text = a.ToString();
                progressBar2.Value = b;
                packBC2.Text = "1";

                if (br > Er_max / 2)
                {
                    t5 = t6;
                }
                else
                {
                    t5 = t5;
                }
                await Task.Delay(2000);//2000    t5


                if (c < Ec_max) c++;
                packagesBC2++; // количество пакетов которых передал пакет АВ1


                packBC2.Text = "0";
                //flagAB1 = false;
                Ec_packagesBC2.Text = Convert.ToString(packagesBC2);

                Ec_label.Text = c.ToString();
                progressBar3.Value = c;
                //Eb_label.Text = n.ToString();
                //progressBar2.Value = n;
            }
        }





        int allpackages = 0;

        private async void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
           

            A();
            new Thread(() =>
            {
                BeginInvoke((MethodInvoker)(async () =>
                {
                    inA();            
                }));


            }).Start();

            //AB1();
            // AB2();

            
            await Task.Run(() => { inB(); });


            

            //inB();
            //  AB1();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            new Thread(() =>
            {
                BeginInvoke((MethodInvoker)(async () =>
                {
                    modeling();
                }));


            }).Start();
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Er_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            form2 = new Form2();
            form2.Show();
        }

        private void t4_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}


//using System;
//using System.Threading;
//using System.Threading.Tasks;
 
//namespace HelloApp
//{
//    class Program
//    {
//        static int Factorial(int n)
//        {
//            int result = 1;
//            for (int i = 1; i <= n; i++)
//            {
//                result *= i;
//            }
//            return result;
//        }
//        // определение асинхронного метода
//        static async void FactorialAsync(int n)
//        {
//            int x = await Task.Run(()=>Factorial(n));
//            Console.WriteLine($"Факториал равен {x}");
//        }
//        static void Main(string[] args)
//        {
//            FactorialAsync(5);
//            FactorialAsync(6);
//            Console.Read();
//        }
//    }
//}