using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kronometrealarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e) //BAŞLA
        {
            int sayi = Convert.ToInt32(label1.Text); //labeldaki sayıyı tutturduk
            sayi++; //tıklayınca artmaya basıyor
            label1.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e) //DURDUR
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e) //SIFIRLA
        {
            int sayi = Convert.ToInt32(label1.Text);
            sayi = 0;
            label1.Text = sayi.ToString();
        }
    }
}
