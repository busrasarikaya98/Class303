using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16022022_TelefonRehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=localhost;database=TelefonRehberi;user=sa;password=12345");
        private void btbGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select count(*) from Kullanici where KullaniciAdi = @ad and Sifre=@sifre",baglanti); 
            //kullanıcı adı ve sifremizi sqlden alıyoruz sqlde varsa giris yapabiliriz
            komut.Parameters.AddWithValue("@ad", txtKulAd.Text); //sql eslesmelerimizi textboxla eslestiriyoruz
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text); //sql eslesmelerimizi textboxla eslestiriyoruz
            baglanti.Open();
            int sayi =(int)komut.ExecuteScalar(); //tek bir kolon döndürme işlemi
            if (sayi > 0)
            {
                //MessageBox.Show("KULLANICI GEÇERLİ");
                RehberForm REH = new RehberForm();
                REH.Show();
            }
            else
                MessageBox.Show("HATALI KULLANICI ADI VEYA ŞİFRE","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //i ikon resmi ve yularıda uyarı yazar
            baglanti.Close();

        }
    }
}
