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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*pictureBox1.Visible = false;*/ //komuta tıklayınca resmi yokettik
            pictureBox1.BackColor = Color.Coral; //komuta basınca renk atadı
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.onedio.com");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.LinkBehavior = LinkBehavior.HoverUnderline; //mousela üzerine geldiğimizde çizgisi kalksın
            //davranışını belirliyoruz
            System.Diagnostics.Process.Start("Mspaint.exe"); //painti çalıştır
        }
    }
}
