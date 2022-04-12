using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsalMıdır
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kontrol = 0;
            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi == 1 || sayi == 0)
            {
                MessageBox.Show("Girdiğiniz sayı asal değildir.");
                textBox1.Clear();

            }
            else
            {
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0) //Kalansız bölünüyormu?
                    {
                        kontrol++;
                        break; //Diğer sayılara bakmaya gerek duymuyoruz.
                    }


                }

                if (kontrol != 0)
                {
                    MessageBox.Show("Girdiğiniz sayı asal değildir.");
                    textBox1.Clear();
                }

                else
                {
                    MessageBox.Show("Girdiğiniz sayı asaldır.");
                    textBox1.Clear();
                }
            }
        }
    }
}
