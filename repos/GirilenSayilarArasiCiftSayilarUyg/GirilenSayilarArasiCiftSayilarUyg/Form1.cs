using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirilenSayilarArasiCiftSayilarUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ilksayi, sonsayi;
            ilksayi = Convert.ToInt32(textBox1.Text);
            sonsayi = Convert.ToInt32(textBox2.Text);

            for (int i = ilksayi; i <= sonsayi; i++)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
            listBox1.Items.Add("--");
        }
    }
}
