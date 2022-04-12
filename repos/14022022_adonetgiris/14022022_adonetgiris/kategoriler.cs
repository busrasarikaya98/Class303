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
    public partial class kategoriler : Form
    {
        public kategoriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti1 = new SqlConnection("Server=LocalHost;Database=KuzeyYeli;user=sa;password=12345"); //baglanti kodumuz
        private void kategoriler_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void KategoriListele()
        {
            //DISCONNECTED MİMARİ yalnızca select sorgularında çalışır
            SqlDataAdapter adpt = new SqlDataAdapter("select*from kategoriler", baglanti1); //sqldataadp nesnesi ürettik bu nesne bağlantıyı open execute close edecek
            DataTable dtb = new DataTable(); //datagridview kullandığımız için tablo gerekli
            adpt.Fill(dtb); //adaptördeki bilgiyi data table a doldur
            dataGridView1.DataSource = dtb; //datagridview ı da bununla doldur
            //gereksiz kolonları görmek istemezsek
            dataGridView1.Columns["kategoriID"].Visible = false; //bu kolonları bu şekilde görünmez yaparız
            dataGridView1.Columns["resim"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(); //yeni metot
            string kategoriadi = textBox1.Text; //burada tanımladık
            string tanim = textBox2.Text; //eklemeleri yaptırıyoruz kullanıcıya
            komut.CommandText = string.Format("insert Kategoriler(KategoriAdi,Tanimi) values('{0}','{1}')", kategoriadi,tanim);
            komut.Connection = baglanti1;
            baglanti1.Open();
            int sonuc1 = komut.ExecuteNonQuery(); //execute edip bağlantıyı kapat
            if (sonuc1 > 0)
            {
                MessageBox.Show("KAYIT BAŞARILI ŞEKİLDE EKLENDİ."); //HER EKLEMEDE ÇALIŞIR
                KategoriListele();
            }
            else
                MessageBox.Show("KAYIT EKLEME SIRASINDA HATA OLUŞTU"); //BAĞLANTI KOPUKLUĞU VS DURUMLARINDA
            baglanti1.Close();
        }
    }
}
