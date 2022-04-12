using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicaklikDegisim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(textBox2.Text);
            textBox1.Text = Convert.ToString((f-32)/1.8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString((c * 1.8) + 32);
        }
    }
}
