using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YGSHESAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkce, matematik, sosyal, fen;
            double ygs1, ygs2;

            turkce = Convert.ToDouble(textBox1.Text);
            sosyal = Convert.ToDouble(textBox2.Text);
            matematik = Convert.ToDouble(textBox3.Text);
            fen = Convert.ToDouble(textBox4.Text);
            ygs1 = 100.160 + (turkce * 1.999) + (sosyal * 1) + (matematik * 3.998) + (fen * 2.999);
            label7.Text = ygs1.ToString();
            ygs2 = 100.160 + (turkce * 1.999) + (sosyal * 1) + (matematik * 2.999) + (fen * 3.998);
            label8.Text = ygs2.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
