using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GünleriSorgulatma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            string sonuc = "";
            switch(sayi)
            {
                case 1: sonuc = "PAZARTESİ";break;
                case 2: sonuc = "SALI"; break;
                case 3: sonuc = "ÇARŞAMBA"; break;
                case 4: sonuc = "PERŞEMBE"; break;
                case 5: sonuc = "CUMA"; break;
                case 6: sonuc = "CUNARTESİ"; break;
                case 7: sonuc = "PAZAR"; break;
                default:
                    MessageBox.Show("UYGUN SEÇİM DEĞİLDİR");
                    break;
            }
            MessageBox.Show("SEÇİLEN GÜN:" + sonuc);
        }
    }
}
