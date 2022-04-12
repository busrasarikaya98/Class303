using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackGroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //hata fırlatmasını engellemiş olacağız
        }
        private void dongu()
        {
            long toplam = 0;
            for(int i=0; i<1000; i++)
            {
                toplam = toplam + i;
                this.Text = i.ToString(); //en ustteki form yazı alanındaki yazıyı degistirdik
            }
            MessageBox.Show(toplam.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dongu(); //arkaplanda islem yapıyor yukarda sayı artıyor o calısırken ekranda islem yapamıyoruz!
        }
       private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(topla.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
        long topla = 0;
        private void dongum()
        {
            for (int i = 0; i < 1000; i++)
            {
                topla = topla + i;
                this.Text = i.ToString(); //en ustteki form yazı alanındaki yazıyı degistirdik
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            dongum();
        }
    }
}
