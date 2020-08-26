using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace appsharp
{
    public partial class Form1 : Form
    {
         string t1, t2, t3, t4;
        float r1, r2, r3, r4;
        

        const int N =10000;
        Boolean flagemp = true;

        private float c, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10;
        double[] min = new double[10];
        double[] max = new double[10];

        public Form1()
        {
            callback.callbackeventHandler = new callback.callbackevent(this.buildgrapg);
            callback.get1 = "-5";
            callback.get1 = "10";
            callback.get1 = "-5";
            callback.get1 = "10";
            callback.flag = false;
            InitializeComponent();
        }

        public void Show_knopka_Click(object sender, EventArgs e)
        {
            arr();
            label35.Text = "Не определено";
            label33.Text = "Не определено";
            label34.Text = "Не определено";
            label32.Text = "Не определено";
            
            graph();
            flagemp = true;
        }

        public void graph()
        {
            cht1();
            cht2();


            func(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text,true);

        }

        public void arr()
        {
            for (int i = 0; i < 10; i++)
            {
                min[i] = 0.001d;
                max[i] = 0.001d;
            };

        }//обнуление массива

        private void prov(ref string u2, ref Boolean flag1, string a)// проверка на пустоту и замена ее на стринг
        {
            double p1 = 0;
            if ((u2 == string.Empty) || (!double.TryParse(u2, out p1)))
            {
                u2 = a;
                flag1 = false;
            };
        }
        private void prov(ref TextBox u1, ref string u2, ref Boolean flag1, string a)// проверка на пустоту и замена ее на стринг
         {
            double p1 = 13;
                if ((u2 == string.Empty) || (!double.TryParse(u2, out p1)))
                {
                   u1.Text=u2 = a;
                    flag1 = false;
                
            };
         }

        private void func(string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8, string s9, string s10,string s11,Boolean flag)
        {
            Boolean flag1 = true;

            prov(ref textBox1, ref s1, ref flag1, "1");
            prov(ref textBox2, ref s2, ref flag1, "1");
            prov(ref textBox3, ref s3, ref flag1, "1");
            prov(ref textBox4, ref s4, ref flag1, "1");
            prov(ref textBox5, ref s5, ref flag1, "1");
            prov(ref textBox6, ref s6, ref flag1, "1");
            prov(ref textBox7, ref s7, ref flag1, "1");
            prov(ref textBox8, ref s8, ref flag1, "1");
            prov(ref textBox9, ref s9, ref flag1, "1");
            prov(ref textBox10, ref s10, ref flag1, "1");
            prov(ref textBox11, ref s11, ref flag1, "1");
           
            prov(ref s1);
            prov(ref s2);
            prov(ref s3);
            prov(ref s4);
            prov(ref s5);
            prov(ref s6);
            prov(ref s7);
            prov(ref s8);
            prov(ref s9);
            prov(ref s10);
            prov(ref s11);

            Mess(flag1);

            x1 = float.Parse(s1);
            x2 = float.Parse(s2);
            x3 = float.Parse(s3);
            x4 = float.Parse(s4);
            x5 = float.Parse(s5);
            x6 = float.Parse(s6);
            x7 = float.Parse(s7);
            x8 = float.Parse(s8);
            x9 = float.Parse(s9);
            x10 = float.Parse(s10);
            c = float.Parse(s11);


            double x = -10;
            
            if (flag)
            {
                for (int i = 1; i < N; i++)
                {
                    double y = Func((float)x);
                    double y1 = proiz((float)x);
                    chart1.Series[0].Points.AddXY(x, y);
                    chart2.Series[0].Points.AddXY(x, y1);
                    x = x + 0.01;
                }
            }else
               {
                   chart1.Series[0].Points.AddXY(0, 0);
                    chart2.Series[0].Points.AddXY(0, 0);
            }
        }//отрисовка функции и производной

        private void Form1_Load(object sender, EventArgs e)// с запуска проги сраатывает
        {
            arr();
          
            this.Text = "Анализ функции";
            textBox1.Text = "1";
            textBox2.Text = "1";
            textBox3.Text = "1";
            textBox4.Text = "1";
            textBox5.Text = "1";
            textBox6.Text = "1";
            textBox7.Text = "1";
            textBox8.Text = "1";
            textBox9.Text = "1";
            textBox10.Text = "1";
            textBox11.Text = "0";
            label35.Text = "Не определено";
            label33.Text = "Не определено";
            label34.Text = "Не определено";
            label32.Text = "Не определено";

            this.BackColor = Color.Coral ;

            t1 = "-5"; //min x
            t2 = "10"; // max x
            t3 = "-5"; //min y
            t4 = "10"; //max y
            graph0();

            textBox13.Text = "0";
            textBox17.Text = "1";
            textBox18.Text = "0";
            textBox19.Text = "1";

        }

        private void obmen(ref float r1,ref float r2,ref Boolean flag2)
        {
            if (r1 > r2)
            {

                float c = r1;
                r1 = r2;
                r2 = c;
               
                flag2 = false;
            };
            
        }
        // меняет местами эдементы и изменяет флаг
        private void obmen(ref TextBox a1, ref TextBox a2, ref float r1, ref float r2, ref Boolean flag2)
        {
            if (r1 > r2)
            {

                float c = r1;
                r1 = r2;
                r2 = c;
                a1.Text = r1.ToString();
                a2.Text = r2.ToString();
                flag2 = false;
            };

        }

        private void messo(Boolean flag)// выдает ошибку границ чего-либо
        {
            if (!flag)
            {
                MessageBox.Show("Начало отрезка должно быть по значению меньше конца\n Параметры обменялись значениями");
            }
        }

        private void Mess(Boolean flag1)
        {
            if (!flag1)
            {
                MessageBox.Show("Произшла ошибка при вводе данных, значения будут взяты по умолчанию");
            };
        }//выдает окно с ошибкой пропущенного значения

        private void cht1()
        {
            Boolean flag = true, flag2 = true ;
            prov(ref t1);
            prov(ref t2);
            prov(ref t3);
            prov(ref t4);

            prov( ref t1, ref flag, "-5");
            prov( ref t2, ref flag, "10");
            prov( ref t3, ref flag, "-5");
            prov( ref t4, ref flag, "10");
            Mess(flag);

            callback.get1 = t1;
            callback.get2 = t2;
            callback.get3 = t3;
            callback.get4 = t4;
            if (callback.flag == true)
            {
                callback.calltext1();
                callback.calltext2();
                callback.calltext3();
                callback.calltext4();
            }
            r1 = float.Parse(t1);
            r2 = float.Parse(t2);
            r3 = float.Parse(t3);
            r4 = float.Parse(t4);
            obmen(ref r1,ref r2,ref flag2);
            obmen( ref r3, ref r4, ref flag2);

            messo(flag2);

            chart1.Series[0].Points.Clear();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[0].LegendText = "Полином";
            chart1.ChartAreas[0].AxisX.Minimum = r1;
            chart1.ChartAreas[0].AxisX.Maximum = r2;
            chart1.ChartAreas[0].AxisX.Interval = 1;

            chart1.ChartAreas[0].AxisY.Minimum = r3;
            chart1.ChartAreas[0].AxisY.Maximum = r4;
            chart1.ChartAreas[0].AxisY.Interval = 1;

            //оси
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.Crossing = 0;
            chart1.ChartAreas[0].AxisY.Crossing = 0;
        }

        private void cht2()
        {
            chart2.Series[0].Points.Clear();
            chart2.Series[0].LegendText = "График первой прозводной";
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart2.ChartAreas[0].AxisX.Minimum = float.Parse(t1); ;
            chart2.ChartAreas[0].AxisX.Maximum = float.Parse(t2); ;
            chart2.ChartAreas[0].AxisX.Interval = 1;

            chart2.ChartAreas[0].AxisY.Minimum = float.Parse(t3); ;
            chart2.ChartAreas[0].AxisY.Maximum = float.Parse(t4); ;
            chart2.ChartAreas[0].AxisY.Interval = 1;

            //оси
            chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisX.Crossing = 0;
            chart2.ChartAreas[0].AxisY.Crossing = 0;
        }

        private void prov(ref string c)
        {
            c = c.Replace(".", ",");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) //о программе
        {
            MessageBox.Show("Все права защищены, тыры-пыры","Лицензионное соглашение");
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // определнение минимума и максимума на отрезке
        {
            string st1, st2;
            st1 = textBox13.Text;
            st2 = textBox17.Text;
            prov(ref st1);
            prov(ref st2);
            Boolean flag1=true,flag2=true;

            prov(ref textBox13, ref st1, ref flag1,"0");
            prov(ref textBox17, ref st2, ref flag1,"1");
         
            Mess(flag1);

            float o1 = float.Parse(st1);
            float o2 = float.Parse(st2);
            obmen(ref textBox13, ref textBox17, ref o1, ref o2, ref flag2);
            
            messo(flag2);

            for (int i = 0; i < 10; i++)
            {
                if ((max[i] != 0.001d) && (min[i] != 0.001d))
                {
                    flagemp = false;
                    break;
                };
            };

            if (flagemp)
            {
                
                string s = minmax();
                flagemp = false;
            };


            double max1 = Func(o1);
            

            for (int i = 0; i < 10; i++)
            {
                if ((max[i]>=o1) && (max[i] <= o2) && (max[i]!=0.01))
                    {
                    if (Func(max[i]) >= max1)
                    {
                       
                        max1 = Math.Round(Func(max[i]), 1);
                    };
                };
            };
            if (Func(o2)>=max1)
            {
                max1 = Func(o2);
            };

            prov(ref label34,  max1);
            


            
            double min1 = Func(o1);
            for (int i = 0; i < 10; i++)
            {
                if ((min[i] >= o1) && (min[i] <= o2) && (min[i] != 0.01))
                {
                    if (Func(min[i]) <= min1)
                    {

                        min1 =Math.Round(Func(min[i]), 1);
                    };
                };
            };
            if (Func(o2) <= min1)
            {
                min1 = Func(o2);
            };

            prov(ref label33,  min1);
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        { }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "pipa";
        }

        private void button2_Click(object sender, EventArgs e) // подсчет интеграла на отрезке
        {
            
            string st1, st2;                // метод симпсона
            st1 = textBox18.Text;
            st2 = textBox19.Text;
            Boolean flag1 = true,flag2=true;

            prov(ref st1);
            prov(ref st2);
            
            prov(ref textBox18, ref st1, ref flag1, "0");
            
            prov(ref textBox19, ref st2, ref flag1, "1");
            
            Mess(flag1);
            
            //функция Func
            float a = float.Parse(st1);
            float b = float.Parse(st2);

            obmen(ref textBox18, ref textBox19, ref a, ref b, ref flag2);
            messo(flag2);
           
            int n = 500;
            double h = (b-a) / (2 * n);
            double O = 0;
            O = (h / 3) * (Func(a) + 4 * DvaNM(n, h, a) + 2 * DvaN(n, h, a)+Func(b) );
            prov(ref label32,  O);
            // вывод ответа
            

        }
        
        private void prov(ref Label label1,  double O)
        {
            if (O > 1000)
            {
                O = Math.Round(Math.Log10(O), 2);
                label1.Text = "10^" + O.ToString();
            }
            else
            {
                if (O < -1000)
                {
                    O = Math.Round(Math.Log10(-O), 2);
                    label1.Text = '-'+"10^" +O.ToString();
                } else
                    label1.Text = Math.Round(O, 2).ToString();   // вывод ответа
            }
            
                
               
          

        }

        private double DvaNM(int n,double h,float a)
        {
            double otvet = 0d, xi = 0d;
            int i = 1;
            for (i = 1; i <= 2*n; i += 2)
            {
                xi = a + i * h;
                otvet += Func((float)xi);
            };

            return otvet;
        }

        private double DvaN(int n,double h,float a)
        {
            double otvet = 0d, xi = 0d;
            int i = 0;
            for (i = 0; i <= 2*n-1; i += 2)
            {
                xi = a + i * h;
                otvet += Func((float)xi);
            };

            return otvet;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void очиститьКуюПлстьToolStripMenuItem_Click(object sender, EventArgs e)//очистка плоскости
        {
          
        }

        private void размерОсейToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поУмолчаниюToolStripMenuItem_Click(object sender, EventArgs e)// меню по умолчанию
        {
           callback.get1=t1 = "-5"; //min x
           callback.get2 = t2 = "10"; // max x
           callback.get3 = t3 = "-5"; //min y
           callback.get4 = t4 = "10"; //max y
            buildgrapg(t1,t2,t3,t4);
        }

        private void очиститьПолеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graph0();
           
            label35.Text = "Не определено";
            label33.Text = "Не определено";
            label34.Text = "Не определено";
            label32.Text = "Не определено";
            flagemp = true;
        }

        private void сброситьКоэффициентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            textBox2.Text = "1";
            textBox3.Text = "1";
            textBox4.Text = "1";
            textBox5.Text = "1";
            textBox6.Text = "1";
            textBox7.Text = "1";
            textBox8.Text = "1";
            textBox9.Text = "1";
            textBox10.Text = "1";
            textBox11.Text = "0";
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void первыйЗапускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void параболаToolStripMenuItem_Click(object sender, EventArgs e)// меню парабола
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "1";
            textBox10.Text = "1";
            textBox11.Text = "1";
            arr();
            label35.Text = "Не определено";
            label33.Text = "Не определено";
            label34.Text = "Не определено";
            label32.Text = "Не определено";
         
            graph();
            flagemp = true;
        }

        private void кубПараболаToolStripMenuItem_Click(object sender, EventArgs e)// меню куб парабола
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "1";
            textBox9.Text = "1";
            textBox10.Text = "1";
            textBox11.Text = "1";
            arr();
            label35.Text = "Не определено";
            label33.Text = "Не определено";
            label34.Text = "Не определено";
            label32.Text = "Не определено";
           
            graph();
            flagemp = true;
        }

        private void построитьГрафикToolStripMenuItem_Click(object sender, EventArgs e)//построение графика 
        {
            buildgrapg(t1,t2,t3,t4);
        }

        public void buildgrapg(string s1, string s2, string s3, string s4)
        {
                        
            arr();
            label35.Text = "Не определено";
            label33.Text = "Не определено";
            label34.Text = "Не определено";
            label32.Text = "Не определено";
            t1 = s1;
            t2 = s2;
            t3 = s3;
            t4 = s4;
           
            graph();
            flagemp = true;
           
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

       
    
        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) // рандом коеф
        {

            Random rnd = new Random();
       
            textBox1.Text = rnd.Next(-10,10).ToString();
            textBox2.Text = rnd.Next(-10, 10).ToString();
            textBox3.Text = rnd.Next(-10, 10).ToString();
            textBox4.Text = rnd.Next(-10, 10).ToString();
            textBox5.Text = rnd.Next(-10, 10).ToString();
            textBox6.Text = rnd.Next(-10, 10).ToString();
            textBox7.Text = rnd.Next(-10, 10).ToString();
            textBox8.Text = rnd.Next(-10, 10).ToString();
            textBox9.Text = rnd.Next(-10, 10).ToString();
            textBox10.Text = rnd.Next(-10, 10).ToString();
            textBox11.Text = rnd.Next(-10, 10).ToString();
            arr();
            label35.Text = "Не определено";
            label33.Text = "Не определено";
            label34.Text = "Не определено";
            label32.Text = "Не определено";
           
            graph();
            flagemp = true;
        }

        public void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

       
      

        private void graph0()
        {
            
             prov(ref t1);
             prov(ref t2);
             prov(ref t3);
             prov(ref t4);

            cht1();
            cht2();

            
            func("0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0",false);
           
        }//рисует пустые графики
        
        private string minmax()
        {
            string s = null;
            arr();
            Boolean flag = true, flag1 = true;
            int p = 0, t = 0;
            float u = 0.002f;
          
           
            
            for (float x = -10,h=0; h <= N; x += u,h++)
             {
               

                if ((proiz(x - u) > 0) && (proiz(x + u) < 0))
                {

                    for (int i = 0; i < 10; i++)
                    {
                        if (max[i] != Math.Round(x, 1))
                        {
                            flag = true;
                        }
                        else { flag = false; break; }
                    };
                    if (flag == true)
                    {
                        max[p] = Math.Round(x, 1);
                        p++;
                        s += " x=" + Math.Round((double)x, 1).ToString();
                    };
                    flag = true;

                }
                else
                {
                    if ((proiz(x - u) < 0) && (proiz(x + u) > 0))
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            if (min[i] != Math.Round(x, 1))
                            {
                                flag1 = true;
                            }
                            else { flag1 = false; break; };
                        };
                        if (flag1 == true)
                        {
                            min[t] = Math.Round(x, 1);
                            t++;
                            s += " x=" + Math.Round((double)x, 1).ToString();
                        };
                        flag1 = true;
                    };

                };
            };
           
            return s;
        }// выдает точки перегиба

        private void button3_Click(object sender, EventArgs e)//точки перегиба кнопка
         {
            
            string s = null;
            int k = 0;
            double[] a = new double[min.Length + max.Length];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 0.001d;
            };

            for (int i = 0; i < 10 ; i++)
            {
                if ((max[i] != 0.001d)&&(min[i] != 0.001d))
                {
                    flagemp = false;
                    break;
                };
            };
            
         
            
                for (int i = 0; i < max.Length; i++)
                {
                    if (max[i] != 0.001d) {
                        a[i] = max[i];
                        k++;
                    };

                };
                for (int t = k, j = 0; j<min.Length;  j++)
                {
                    if (min[j] != 0.001d)
                    {
                        a[t] = min[j];
                        t++;
                    }
                };


            for (int i=0;i<a.Length;i++)
                for (int t = 0; t < a.Length; t++)
                    if (a[i]<a[t])
                    {
                        double c = a[i];
                        a[i] = a[t];
                        a[t] = c;
                    }



                    for (int i = 0; i < a.Length; i++)
                {
                    if (a[i]!=0.001d)
                    s += " x=" + a[i].ToString();
                };

                  
                
            
            if (flagemp)
            {
               
                s = minmax();
                flagemp = false;
            };
            if (s == null) { label35.Text = "Точек перегиба нет";  }
            else
            {
                label35.Text = s;
            }
        }

        private float proiz(float x)
        {
            return (float)(10 * x1 * Math.Pow(x, 9) + 9 * x2 * Math.Pow(x, 8) + 8 * x3 * Math.Pow(x, 7) + 7 * x4 * Math.Pow(x, 6) + 6 * x5 * Math.Pow(x, 5) + 5 * x6 * Math.Pow(x, 4) + 4 * x7 * Math.Pow(x, 3) + 3 * x8 * Math.Pow(x, 2) + 2 * x9 * Math.Pow(x, 1) + x10);
        }

        private double Func(double x)

        {
            return (x1 * Math.Pow(x, 10) + x2 * Math.Pow(x, 9) + x3 * Math.Pow(x, 8) + x4 * Math.Pow(x, 7) + x5 * Math.Pow(x, 6) + x6 * Math.Pow(x, 5) + x7 * Math.Pow(x, 4) + x8 * Math.Pow(x, 3) + x9 * Math.Pow(x, 2) + x10 * Math.Pow(x, 1) + c);
        }

      
    }
}
