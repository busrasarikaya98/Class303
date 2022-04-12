using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalangun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime sinavtarihi, buguntarihimiz;
            buguntarihimiz = DateTime.Now;
            sinavtarihi = Convert.ToDateTime(textBox1.Text);
            TimeSpan kalangun = sinavtarihi - buguntarihimiz;
            label3.Text = "KALAN GÜN = " + kalangun;
        }
    }
}
