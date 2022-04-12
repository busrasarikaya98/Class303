using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mervehocauygdevam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] dizi = alankodu.GetNames(typeof(alankodu));
            for (int i = 0; i < 5; i++)
                comboBox1.Items.Add(dizi[i]);
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            short kod;
            if (comboBox1.Text== "Ankara")
            {
                kod = (short)alankodu.Ankara;
                textBox1.Text = kod.ToString();
            }
            if (comboBox1.Text == "İzmir")
            {
                kod = (short)alankodu.İzmir;
                textBox1.Text = kod.ToString();

            }
            if (comboBox1.Text == "Rize")
            {
                kod = (short)alankodu.Rize;
                textBox1.Text = kod.ToString();

            }
            if (comboBox1.Text == "İstanbul")
            {
                kod = (short)alankodu.İstanbul;
                textBox1.Text = kod.ToString();
            }
            if (comboBox1.Text == "Bursa")
            {
                kod = (short)alankodu.Bursa;
                textBox1.Text = kod.ToString();
            }

        }

         enum alankodu : short
        {
        Ankara = 6,
        İzmir = 35,
        Rize = 53,
        İstanbul = 34,
        Bursa = 16
        }

    }
    
    
}
