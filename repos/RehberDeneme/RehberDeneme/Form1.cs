using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RehberDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text; //textbox kısmına yazdığımız text labela attırdık
            label10.Text = textBox2.Text; //textbox kısmına yazdığımız text labela attırdık
            label11.Text = comboBox1.Text; //combodan seçimimizi labela aktardık
            label12.Text = textBox3.Text; //textbox kısmına yazdığımız text labela attırdık

            comboBox2.Items.Add("İSTANBUL"); //combo kısmına buradan ekleme yaapbiliriz kaydet tusuna bastıktan sonra geliyor
            comboBox2.Items.Add("ANKARA");
            comboBox2.Items.Add("İZMİR");
            comboBox2.Items.Add("MERSİN");
        }
    }
}
