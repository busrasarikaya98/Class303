using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGirisPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar=char.Parse("*");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form2 fr2 = new Form2(); //bilgiler doğru ise form2 ekranına geçiş yapıyoruz
                fr2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ YAPTINIZ!"); //bilgiler yanlış ise form2ye geçiş yok mesaj yazdır
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
