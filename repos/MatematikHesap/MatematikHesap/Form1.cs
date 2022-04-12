using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikHesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "KARE";
            label3.Visible = false; //GÖRÜNÜMLERİNİ KAPATTIK
            label4.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            panel1.Visible = true;
            button4.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kenar_uzunlugu;
            int alan, cevre;
            kenar_uzunlugu = Convert.ToInt32(textBox1.Text);
            cevre = 4 * (kenar_uzunlugu);
            alan = kenar_uzunlugu * kenar_uzunlugu;
            label7.Text = cevre.ToString();
            label8.Text = alan.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "DİKDÖRTGEN";
            panel1.Visible = true;
            label2.Visible = false;
            textBox1.Visible = false;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kisa, uzun, cevre, alan;
            kisa = Convert.ToInt32(textBox2.Text);
            uzun = Convert.ToInt32(textBox3.Text);
            cevre = (kisa + uzun) * 2;
            alan = kisa * uzun;
            label7.Text = cevre.ToString();
            label8.Text = alan.ToString();
        }
    }
}
