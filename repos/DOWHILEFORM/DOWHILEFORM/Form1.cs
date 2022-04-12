using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOWHILEFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int j = 0;
            do
            {
                listBox2.Items.Add(j);
                j++;
            }
            while (j <= 40);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int m=0; m<=35; m++)
            {
                listBox3.Items.Add(m);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 20) 
            {
                listBox1.Items.Add(i);
                i++;
            }
        }
    }
}
