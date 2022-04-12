using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void vForVendettaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "V for Vendetta, 2020 yılında ve İngiltere'de geçiyor.";
            listBox1.Items.Add("V for Vendetta");
            listBox2.Items.Add(toolStripComboBox1.Text);

        }
    }
}
