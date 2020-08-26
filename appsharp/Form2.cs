using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appsharp
{
    public partial class Form2 : Form
    {
       

        private void button1_Click(object sender, EventArgs e)
        {   
            callback.callbackeventHandler(textBox20.Text, textBox21.Text, textBox22.Text, textBox23.Text);
        }

        public Form2()
        {
            callback.calltext1 = new callback.calltext(this.text1);
            callback.calltext2 = new callback.calltext(this.text2);
            callback.calltext3 = new callback.calltext(this.text3);
            callback.calltext4 = new callback.calltext(this.text4);
            callback.flag = true;
            InitializeComponent();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox20.Text = callback.get1;
            textBox21.Text = callback.get2;
            textBox22.Text = callback.get3;
            textBox23.Text = callback.get4;
            Text = "Настройки";
          
        }
        private void text1()
        {
            textBox20.Text = callback.get1;
        }
        private void text2()
        {
            textBox21.Text = callback.get2;
        }
        private void text3()
        {
            textBox22.Text = callback.get3;
        }
        private void text4()
        {
            textBox23.Text = callback.get4;
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }
    }
}