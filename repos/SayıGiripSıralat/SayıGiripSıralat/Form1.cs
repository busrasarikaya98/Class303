using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayıGiripSıralat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList sayi = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            sayi.Add(textBox1.Text);
            textBox1.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            sayi.Sort();
            foreach(string m in sayi)
            {
                listBox1.Items.Add(m);       
            }
        }
    }
}
