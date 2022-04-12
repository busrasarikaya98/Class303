using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALARM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.Hour.ToString();
            label6.Text = DateTime.Now.Minute.ToString();
            if (label5.Text == comboBox1.Text && label6.Text == comboBox2.Text) 
            {
                timer1.Enabled = false;
                axWindowsMediaPlayer1.URL = "C:\\Users\\303BUSRA_AKSAM\\Desktop\\music.mp3"; 
                //veya sağa sürüklediğim müzikten tam yolu kopyala başına @ koy
                //MessageBox.Show("UYAN ARTIK"); //seçimimiz zamana eşitse uyarı versin
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i=0; i<24; i++)  //comboboxlara sayı ekleme yapıyoruz
            {
                comboBox1.Items.Add(i);
            }
            for(int j=0; j<60; j++)
            {
                comboBox2.Items.Add(j);
            }
            

        }
    }
}
