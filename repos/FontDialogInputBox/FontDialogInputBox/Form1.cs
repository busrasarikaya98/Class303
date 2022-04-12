using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace FontDialogInputBox
{ public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) //yazı tipi butonu
        {
            FontDialog yazi = new FontDialog(); //metodumuzu olusturduk
            yazi.ShowDialog(); //yazının fontunu değiştirmek için bir pencere açılacak
            label1.Font = yazi.Font; //yazı tipinin degismis hali
        }
        private void button2_Click(object sender, EventArgs e) //kaydet butonu
        {
            string ad,soyad;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            string ilce = Interaction.InputBox("İLÇE GİRİN" /*giriş*/, "KİŞİ BİLGİLERİ" /*dış*/, "İLÇE" /*seçenek yeri*/, 50, 50); 
            //ilçe girme butonu çıkıyor
            label5.Text = ad + " " + soyad + " " + ilce;
        }
    }
}
