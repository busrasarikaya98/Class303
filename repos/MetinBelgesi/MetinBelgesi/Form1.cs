using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //input output

namespace MetinBelgesi
{   public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StreamWriter sw; //IO nun bir sınıfı
        string belgeadi, belgeyolu;
       private void button2_Click(object sender, EventArgs e)
        {
            belgeadi = textBox1.Text; //yazdığımız ad
            sw = File.CreateText(belgeyolu + "\\" + belgeadi + ".txt"); //belgeyi bu sekilde kaydet
            sw.Close();
            MessageBox.Show("Efendim belgeniz oluşturuldu!");
        }
       private void label3_Click(object sender, EventArgs e)
        {

        }
       private void ilaktar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satir = oku.ReadLine();
                while(satir!=null)
                {
                    listBox1.Items.Add(satir);
                    satir = oku.ReadLine(); //satır satır okuma yöntemi
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "KAYIT YERİNİ SEÇ"; //kayıt kutusunda üsttki metin
                saveFileDialog1.Filter = "METİN DOYASI(*.txt)|*.txt"; //kayıt kutusunda kayıt türü
                saveFileDialog1.FilterIndex = 2; //kayıt türünde oto hangisini seçsin
                saveFileDialog1.InitialDirectory = "C:\\"; //hangi klasör oto açılsın
                saveFileDialog1.ShowDialog(); //bunları göster komutu
                StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName); //yazdıklarımızı kaydediyor
                kaydet.WriteLine(richTextBox2.Text); //yazdık
                kaydet.Close();
                MessageBox.Show("Kaynak Metin Belgesine Yazdırıldı");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) //açılan penceredeki dosyalardan birini seçiyoruz
            { //folderbrowswe kayıt edilebilecek dosyaları gösterir show ile //dialogresult bizim secimimiz
                belgeyolu = folderBrowserDialog1.SelectedPath.ToString(); //sectigimizi tutuyor
                //belgeyolunun adını seçime eşitledi
                textBox2.Text = belgeyolu.ToString();
            }
        }
    }
}

