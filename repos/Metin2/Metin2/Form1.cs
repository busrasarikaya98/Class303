using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Metin2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Metin Dosyası(*txt)|.txt"; //sadece bu uzantılı olanları filtreledik
            open.Multiselect = false;
            if(open.ShowDialog()==System.Windows.Forms.DialogResult.OK) //seçimim gösterdiklerinden biri ise
            {
                textBox1.Text = open.SafeFileName; //dosyayı güvenli okuma
                try
                {
                    StreamReader oku = new StreamReader(open.FileName); //dosya adını okuma metodu
                    richTextBox1.Text = oku.ReadToEnd(); //dosyayı sonuna kadarr oku
                    oku.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("DOSYA OKUNAMADI");
                }
            }
        }
    }
}
