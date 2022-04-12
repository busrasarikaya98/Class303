using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            int number1;
            int number2;
            int total;
            number1 = Convert.ToInt32(textBox1.Text); //textbox1 de yazdığımız sayı number1 dir
            number2 = Convert.ToInt32(textBox2.Text); //textbox2 de yazdığımız sayı number2 dir 
            total = number1 + number2; //totali tanımladık
            label4.Text = total.ToString();  //labela yazdırabilmesi için to string yapmalıyız label4 tür
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, carpim;
            a = Convert.ToInt32(textBox3.Text); //texbox 3 te yazdığımız sayı a sayısıdır
            b = Convert.ToInt32(textBox4.Text); //texbox 4 te yazdığımız sayı b sayısıdır
            carpim = a * b; //carpimi tanimaldik
            label8.Text = carpim.ToString(); //label8 e carpimi yazdirdik
        }
    }
}
