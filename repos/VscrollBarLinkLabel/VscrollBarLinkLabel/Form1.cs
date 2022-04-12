using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VscrollBarLinkLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (vScrollBar1.Value>=50)
            {
                this.BackColor = Color.Yellow;
            }
            if (vScrollBar1.Value<=30)
            {
                this.BackColor = Color.Red;
            }
        }
    }
}
