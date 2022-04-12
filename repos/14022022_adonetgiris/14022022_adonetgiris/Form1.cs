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

namespace _14022022_adonetgiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Server=LocalHost;Database=KuzeyYeli;user=sa;password=12345";
            //baglanti.ConnectionString = "Server=LocalHost;Database=KuzeyYeli;Integrated Security=true" windows auth için

            //CONNECTED MİMARİ open - execute - close
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select*from Urunler"; //komutumuz bu
            komut.Connection = baglanti;
            baglanti.Open(); //connect açık //bağlantı tanımladıktan sonra her yerde yazılabilir
            SqlDataReader rdr= komut.ExecuteReader(); //komutu execute et
            while(rdr.Read()) //okuyabildiğin sürece dön
            {
               string ad= rdr["urunAdi"].ToString(); //hangi kolonu yazdırmak istiyoruz
               string fiyat = rdr["Fiyat"].ToString(); //kolon
               string stok = rdr["Stok"].ToString();
               listBox1.Items.Add(string.Format("{0}---{1}---{2}", ad, fiyat, stok));
            }
            baglanti.Close();

            SqlCommand komut2 = new SqlCommand();
            komut2.CommandText = "select*from Kategoriler";
            komut2.Connection = baglanti;
            baglanti.Open();
            SqlDataReader rdr2 = komut2.ExecuteReader();
            while (rdr2.Read())
            {
                string kategoriad = rdr2["KategoriAdi"].ToString();
                string tanim = rdr2["Tanimi"].ToString();
                listBox2.Items.Add(string.Format("{0}---{1}", kategoriad, tanim));
            }
            baglanti.Close();
        }
    }
}
