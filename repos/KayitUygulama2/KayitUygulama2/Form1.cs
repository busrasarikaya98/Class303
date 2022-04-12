using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayitUygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = " BENİ DEĞİŞTİRDİ"; //butona tıkladığımızda label değişti
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = " C# FORM UYGULAMASINA GEÇTİK";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "KAYIT DENEME YAPILDI";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text; //textboxta yazılanı labela yolladı
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
