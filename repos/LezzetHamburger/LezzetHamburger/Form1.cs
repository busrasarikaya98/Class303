using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LezzetHamburger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);//seçim yaptırdığımız checkboxı yazdıracağız
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            foreach (Control kontrol in this.groupBox1.Controls)
            {
            if (kontrol is CheckBox)   
                {
                    if (((CheckBox)kontrol).Checked == true)
                    {
                        listBox6.Items.Add(((CheckBox)kontrol).Text.ToString());
                    }
                }
            }
            //VEYA YENİ GBOX OLUSTUR VE LABELLAR KOY GBOX1DEKİ CHECKLERİ(ÜSTÜNE TIKLA) TEKTEK LABELLARA ESİTLE
            //GBOX2 NIN VISIBLEINI FALSE YAP
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }
    }
}
