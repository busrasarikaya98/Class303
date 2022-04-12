using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastgeleSayıOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            Random rastgele = new Random();
            for (int i = 1; i < 4; i++)
            {
                int rndmsayi = rastgele.Next(sayi1, sayi2);
                listBox1.Items.Add(rndmsayi);
            }
        }
    }
}
