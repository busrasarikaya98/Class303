using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlararasıgeçiş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.user_name = textBox1.Text;
            fr.password = textBox2.Text;
            fr.ShowDialog();
        }
    }
}
