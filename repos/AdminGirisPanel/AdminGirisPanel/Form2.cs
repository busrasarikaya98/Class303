using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminGirisPanel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e) //butona bastığımzda;
        {
            if (comboBox1.Text == "KIRMIZI")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + "RENK=" + "LİDERLİK,HIRS, İRADEYİ TEMSİL EDER";
                button2.BackColor = Color.Red;
            }
            else if (comboBox1.Text == "SARI")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + "RENK=" + "UMUT, MUTLULUK, NEŞE VE EĞLENCE SUNAR";
                button2.BackColor = Color.Yellow; //buton rengini değiştirdik sağ tarafta
            }   //label4 e adımızı rengimizi ve açıklamamızı eklettik
            else 
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + "RENK=" + "HUZURUN VE BARIŞIN RENGİ";
                button2.BackColor = Color.Blue;
            }
        }
    }
}
