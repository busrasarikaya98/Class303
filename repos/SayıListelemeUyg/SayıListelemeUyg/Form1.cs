using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayıListelemeUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int girilensayi;
            girilensayi = Convert.ToInt32(textBox1.Text);
            int i;
            for (i=1; i<=girilensayi; i++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
