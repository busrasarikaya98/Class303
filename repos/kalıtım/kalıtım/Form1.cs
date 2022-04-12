using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalıtım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            personel pers = new personel();
            pers.ad = "SALVADOR";
            pers.soyad = "DALİ";
            pers.yas = 50;
            pers.departman = "SANAT";
            pers.yer = "ŞUBE-303";
            label6.Text = pers.ad.ToString();
            label7.Text = pers.soyad.ToString();
            label8.Text = pers.yas.ToString();
            label9.Text = pers.departman.ToString();
            label10.Text = pers.yer.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
