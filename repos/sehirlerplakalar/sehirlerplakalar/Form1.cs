using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sehirlerplakalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum sehirler
        {
            İstanbul=34,Ankara=6
        }
        sehirler sehir;
        private void button1_Click(object sender, EventArgs e)
        {
            int i = string.Parse(comboBox1.Text);
            sehir = (sehirler)i;
            label1.Text ="Sehir Kodu = "+ sehir;

        }
    }
}
