using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalanGunHesaplatma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime buguntarihimiz = DateTime.Now;
            DateTime sinavtarihi = new DateTime(2022, 11, 20);
            TimeSpan ts = sinavtarihi - buguntarihimiz;
            label1.Text = "SINAV TARİHİ = " + sinavtarihi.ToShortDateString();
            label2.Text = "KALAN GÜN = " + ts.Days.ToString();
        }
    }
}
