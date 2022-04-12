using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize1, vize2, ortalama;
            vize1 = Convert.ToDouble(textBox2.Text); //textbox2 değeri vize1 dir
            vize2 = Convert.ToDouble(textBox3.Text); //textbox3 değeri vize2dir
            ortalama = (vize1 + vize2) / 2;
            textBox4.Text = ortalama.ToString(); //textbox4 değeri ortalamadır
            
            listBox1.Items.Add(textBox1.Text); //adsoyad yazıp her hesapla tıkladığımızda listbox1 e eklesin
            listBox2.Items.Add(textBox2.Text); //vize1 yazıp her tıkladığımızda listbox2 e eklesin
            listBox3.Items.Add(textBox3.Text); //vize2 yazıp her tıkladığımızda listbox3 e eklesin
            listBox4.Items.Add(textBox4.Text); //her ortalamayı listbox4 e eklesin

            if (ortalama>=65)  //ortalamaya göre listbox5 e yazı yazdırdık
            {
                listBox5.Items.Add("GEÇTİNİZ!");
            }
            else
            {
                listBox5.Items.Add("KALDINIZ :(");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();  //sil butonuna her tıkladığımzda textboxları temizleyecek elle silmemize gerek yok
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
