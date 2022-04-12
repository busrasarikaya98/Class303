using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpimTablosuUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i=1; i<11; i++)
            {
                for (int j=0; j<11; j++)
                {
                    listBox1.Items.Add(i + "x" + j + "=" + i * j);
                }
                listBox1.Items.Add("------------------------------");
            }
        }
    }
}
