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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=LocalHost;Database=KuzeyYeli;user=sa;password=12345"); //baglanti kodumuz
        private void Form2_Load(object sender, EventArgs e)
        {
            //EKLEME YAPINCA TABLO REFRESH OLSUN !!!!! ONEMLI !!!!!
            UrunListele(); //formloadtaki kodları crtl nokta yapıp method oluşturduk her eklemede direkt ekleme yapıp yenilemesi için
        }

        private void UrunListele()
        {
            //DISCONNECTED MİMARİ yalnızca select sorgularında çalışır
            SqlDataAdapter adp = new SqlDataAdapter("select*from urunler", baglanti); //sqldataadp nesnesi ürettik bu nesne bağlantıyı open execute close edecek
            DataTable dt = new DataTable(); //datagridview kullandığımız için tablo gerekli
            adp.Fill(dt); //adaptördeki bilgiyi data table a doldur
            dataGridView1.DataSource = dt; //datagridview ı da bununla doldur
            //gereksiz kolonları görmek istemezsek
            dataGridView1.Columns["urunID"].Visible = false; //bu kolonları bu şekilde görünmez yaparız
            dataGridView1.Columns["kategoriID"].Visible = false;
            dataGridView1.Columns["tedarikciID"].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(); //yeni metot
            string urunad = txtUrunAdi.Text; //burada tanımladık
            decimal fiyat = NudFiyat.Value; //eklemeleri yaptırıyoruz kullanıcıya
            decimal stok = nudStok.Value; //numeric up down
            komut.Connection = baglanti;
            //komut.CommandText = string.Format("insert urunler(urunadi,fiyat,stok) values('{0}',{1},{2})", urunad, fiyat, stok); EKLEME YÖNTEMİ
            //VEYA DAHA GÜVENLİ BAĞLANTI İÇİN DATABASEI KORUMAK İÇİN xxx,1,1) drop database--
            komut.CommandText = "insert Urunler (UrunAdi,Fiyat,Stok) values (@urunadi,@fiyat,@stok)"; //PARAMETRE İLE ALDIK
            komut.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@fiyat", NudFiyat.Value);
            komut.Parameters.AddWithValue("@stok", nudStok.Value);
            baglanti.Open();
            int sonuc=komut.ExecuteNonQuery(); //execute edip bağlantıyı kapat
            if (sonuc > 0) 
            {
                MessageBox.Show("KAYIT BAŞARILI ŞEKİLDE EKLENDİ :)"); //HER EKLEMEDE ÇALIŞIR
                UrunListele();
            }
            else
                MessageBox.Show("KAYIT EKLEME SIRASINDA HATA OLUŞTU :("); //BAĞLANTI KOPUKLUĞU VS DURUMLARINDA
            baglanti.Close();       
        }

        private void btn_kategori_Click(object sender, EventArgs e)
        {
            kategoriler k = new kategoriler();
            k.Show(); //diğer forma geçiş
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //seçili veriyi textlerde yazdırma
        {
            //tıkladığımız butonlar yukarıda text butonlarında gözüksün istersek
            txtUrunAdi.Text = dataGridView1.CurrentRow.Cells
                ["UrunAdi"].Value.ToString();
            NudFiyat.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Fiyat"].Value);
            nudStok.Value = (short)dataGridView1.CurrentRow.Cells["Stok"].Value;
            txtUrunAdi.Tag = dataGridView1.CurrentRow.Cells["UrunID"].Value; //tag görünmeyen kısımda tutuyor
        }

        private void btnguncelle_Click(object sender, EventArgs e) //güncelleme butonu
        {
            NudFiyat.Text = NudFiyat.Text.Replace(',', '.');
            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("update Urunler set UrunAdi='{0}',Fiyat={1},Stok={2} where UrunID={3}"
                , txtUrunAdi.Text, Convert.ToDecimal(NudFiyat.Text), nudStok.Text,txtUrunAdi.Tag); //arkada calisan veri tag görünürde yok
            komut.Connection = baglanti;
            baglanti.Open();
            int sonuc=komut.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show("KAYIT GÜNCELLENDİ :)");
                UrunListele();
            }
            else
                MessageBox.Show("KAYIT GÜNCELLEME BAŞARISIZ :(");
            baglanti.Close();
            UrunListele();
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e) //verinin üstünde sağ tıkla yapınca çıkıyor silme komutu
            //datagridwiev in context menusunu aktiflestirdik
        {
            
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UrunID"].Value);
            /*if (dataGridView1.CurrentRow.SetValues().ToString() != null)*/ //tıklama yapmadan silmeye çalışılırsa silme hatası versin
            
                /* SqlCommand komut = new SqlCommand(string.Format("delete Urunler where UrunID={0}",id),baglanti);*/ //bu sekilde tek satırda da yazabiliriz



                //VEYA PROCEDURE ILE SILDIREBILIRIZ //DAHA GÜVENLİ
                SqlCommand komut = new SqlCommand("UrunSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id); //or ,txtUrunAdi.tag

                baglanti.Open();
                int sonuc = komut.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    MessageBox.Show("KAYIT SİLİNDİ :(");
                    UrunListele();
                }
                else
                    MessageBox.Show("KAYIT SİLME BAŞARISIZ :(");
            baglanti.Close();
            
        }

        private void btnSPekle_Click(object sender, EventArgs e) //sqlde store procedure olusturduk store procedure ile ekleme yapıyoruz
        {
            SqlCommand komut = new SqlCommand("UrunEkle",baglanti); //yeni komut
            komut.CommandType = CommandType.StoredProcedure; //sp ile iliskilendirdik
            komut.Parameters.AddWithValue("@ad", txtUrunAdi.Text); //girilen verileri iliskilendir
            komut.Parameters.AddWithValue("@fiyat", NudFiyat.Value);
            komut.Parameters.AddWithValue("@stok", nudStok.Value);
            baglanti.Open();
            int sonuc =komut.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show("KAYIT BAŞARILI ŞEKİLDE EKLENDİ :)"); //HER EKLEMEDE ÇALIŞIR
                UrunListele();
            }
            else
                MessageBox.Show("KAYIT EKLEME SIRASINDA HATA OLUŞTU :("); //BAĞLANTI KOPUKLUĞU VS DURUMLARINDA
            baglanti.Close();
        }

        private void btnSPguncelle_Click(object sender, EventArgs e) //sp ile guncelleme yapalim
        {
            SqlCommand komut = new SqlCommand("UrunGuncelle", baglanti); //sp ile iliskilendirdik
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", txtUrunAdi.Tag);
            komut.Parameters.AddWithValue("@ad", txtUrunAdi.Text); //girilen verileri iliskilendir
            komut.Parameters.AddWithValue("@fiyat", NudFiyat.Value);
            komut.Parameters.AddWithValue("@stok", nudStok.Value);
            baglanti.Open();
            int sonuc = komut.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show("KAYIT BAŞARILI ŞEKİLDE GÜNCELLENDİ :)"); 
                UrunListele();
            }
            else
                MessageBox.Show("GÜNCELLEME SIRASINDA HATA OLUŞTU :("); 
            baglanti.Close();
        }
    }
}
