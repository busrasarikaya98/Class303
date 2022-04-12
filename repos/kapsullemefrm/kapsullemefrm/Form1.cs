using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kapsullemefrm
{
    public partial class Form1 : Form
    {      public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            emlakçı ev = new emlakçı();
            ev.Semt = textBox1.Text; //verileri aldık
            ev.Odasayisi = Convert.ToInt32(textBox2.Text);
            ev.Katno = Convert.ToInt32(textBox3.Text);
            ListViewItem kayıt = new ListViewItem(); //listview metodu olusturduk
            kayıt.Text = ev.Semt;

            kayıt.SubItems.Add(ev.Odasayisi.ToString());
            kayıt.SubItems.Add(ev.Katno.ToString()); //itemleri ekledik
            listView1.Items.Add(kayıt); //kayıtları yazdır
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear(); 
            textBox2.Focus(); //uygulama açıldığında imlecim üstünde olacak
        }
    }
}
