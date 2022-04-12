using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafikLambası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label1.Text); 
            sayi++; 
            label1.Text = sayi.ToString();
            //button1.BackColor = Color.Red;
            if (sayi < 30)
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
            }
            if (sayi == 30)
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Yellow;
                button3.BackColor = Color.Gray;
            }
            if (sayi == 40)
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Green;
            }
        
            if (sayi == 70)
            {
                sayi = 0;
                label1.Text = sayi.ToString();
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
