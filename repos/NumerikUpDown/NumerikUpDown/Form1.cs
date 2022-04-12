using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerikUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       private void button1_Click(object sender, EventArgs e)
        {
            int toplam;
            toplam = Convert.ToInt32(numericUpDown2.Value + numericUpDown3.Value);
            //numeriklerden seçtiğimiz adetleri toplattırdık
            label2.Text = toplam.ToString();
        }
    }
}
