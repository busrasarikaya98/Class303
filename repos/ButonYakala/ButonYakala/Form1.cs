using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButonYakala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AFERİN SANA :)");
            this.Close(); //kapatma durumu
        }
        Random r = new Random();
        int boyut = 40;  //butonun hareket alanı 

        private void button1_MouseHover(object sender, EventArgs e)  //formda yakala kısmında ozelkden mousehover seçip çift tıkladık
        {
            boyut += 1; //ok yaklaştığında kaçacak
            button1.Top = r.Next(0, this.Height - 40); //üstünden yaklaştığımızdaki hareketi
            button1.Left = r.Next(0, this.Width - 40); //genisliginden cıkardık
            button1.Width = boyut;
            button1.Height = boyut;  
        }
    }
}
