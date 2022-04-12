using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinamiklabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label lbl = new Label();
            Point lblkonum = new Point(100,100); //labeli konumlandırdık
            lbl.Location = lblkonum;
            lbl.Text = "LABEL1";
            lbl.Name = "LBL1";
            this.Controls.Add(lbl);
        }
    }
}
