using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace PCIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "BİLGİSAYAR:" + Dns.GetHostName(); //bilgisayarımzın adı
            foreach (IPAddress adres in Dns.GetHostAddresses(Dns.GetHostName())) //ip adreste obje tanımladık
            //bu obje gethostta gezip benim ip me erisecek
            {
                textBox2.Text = "IP ADRESİ=" + adres;
            }
        }
    }
}
