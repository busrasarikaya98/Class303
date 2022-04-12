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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string user_name;
        public string password;
       private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = user_name;
            label4.Text = password;
        }
    }
}
