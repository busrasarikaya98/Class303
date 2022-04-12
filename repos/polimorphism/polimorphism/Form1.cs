using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polimorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tekstil text = new tekstil();
            text.urunadi = "ŞAL";
            text.kumasturu = "IPEK";
            text.ureticifirma = "ARMİNE";
            text.fiyatim = 1000;
            textBox1.Text = text.urunadi; //yukarıdaki değerleri textboxa yazdırdık
            textBox2.Text = text.kumasturu;
            textBox3.Text = text.ureticifirma;
            textBox4.Text = Convert.ToString(text.fiyatim);
        }
    }
}
