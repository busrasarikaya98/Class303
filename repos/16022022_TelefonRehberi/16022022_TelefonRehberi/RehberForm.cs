using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16022022_TelefonRehberi
{
    public partial class RehberForm : Form
    {
        public RehberForm()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection("server=localhost;database=TelefonRehberi;user=sa;password=12345");
        //SERVER BİLGİLERİ DEĞİŞİRSE appconfig e tanımladık bağlantıyı değiştirdik
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        

        private void RehberForm_Load(object sender, EventArgs e)
        {
            //class olusturduk rehber adlı sqldeki parametlere göre proplar olusturduk

            RehberListele();
        }

        private void RehberListele()
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select*From rehber";
            komut.Connection = baglanti;
            baglanti.Open();
            SqlDataReader rdr = komut.ExecuteReader();//sql data reader döndürecek
            List<Rehber> rehberlistesi = new List<Rehber>(); //rehber class ından okuma verdik
            while (rdr.Read()) //satır satır okuyarak listeye alacak listboxa aktaracak
            {
                rehberlistesi.Add(new Rehber()
                {
                    ID = rdr.GetInt32(0),
                    Isim = rdr.IsDBNull(1)?string.Empty:rdr.GetString(1), //eğer datada değer boşsa hata verme boşluk koy, boş değilse değeri yaz
                    Soyisim = rdr.IsDBNull(2) ? string.Empty : rdr.GetString(2), //soru işareti boş olup olmadığını sordurdu
                    Telefon1 = rdr.IsDBNull(3) ? string.Empty : rdr.GetString(3), //: else anlamı verir
                    Telefon2 = rdr.IsDBNull(4) ? string.Empty : rdr.GetString(4),
                    Email = rdr.IsDBNull(5) ? string.Empty : rdr.GetString(5),
                    WebAdres = rdr.IsDBNull(6) ? string.Empty : rdr.GetString(6),
                    Aciklama = rdr.IsDBNull(7) ? string.Empty : rdr.GetString(7)
                });
            }
            baglanti.Close();
            list_Rehber.DataSource = rehberlistesi;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("RehberEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Isim", txtisim.Text);
            komut.Parameters.AddWithValue("@Soyisim", txtsoyisim.Text);
            komut.Parameters.AddWithValue("@Telefon1", txttel1.Text);
            komut.Parameters.AddWithValue("@Telefon2", txttel2.Text);
            komut.Parameters.AddWithValue("@Email", txtemail.Text);
            komut.Parameters.AddWithValue("@WebAdres", txtwebadres.Text);
            komut.Parameters.AddWithValue("@Aciklama", txtaciklama.Text);
            baglanti.Open();
            int sonuc = komut.ExecuteNonQuery();
            baglanti.Close();
            if (sonuc > 0)
            { 
            MessageBox.Show("KAYIT BAŞARILI :)");
            RehberListele();
        }
            else
                MessageBox.Show("KAYIT BAŞARISIZ :(");
        }

        private void list_Rehber_Click(object sender, EventArgs e) //rehber clasından ulaşmaya çalışıyoruz
        {
            Rehber r = (Rehber)list_Rehber.SelectedItem;
            txt_secisim.Text = r.Isim;
            txt_secsoyisim.Text = r.Soyisim;
            txt_sectel1.Text = r.Telefon1;
            txt_sectel2.Text = r.Telefon2;
            txt_secemail.Text = r.Email;
            txt_secwebadres.Text = r.WebAdres;
            txt_secaciklama.Text = r.Aciklama;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int sonuc=0;
            //her durumda sağlıklı close yapmak için try catch kullanmak gerekir 
            try
            {
                int id = ((Rehber)list_Rehber.SelectedItem).ID; //listboxtan arka plandaki id yi alıyor tutuyor id e göre güncelleme yapacağız
                SqlCommand komut = new SqlCommand("RehberGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ID", id); //id yi yukarda çektik listeboxtan tıklayınca ekrana yazdırıyordu 
                komut.Parameters.AddWithValue("@Isim", txt_secisim.Text); //listboxta seöilen kişi
                komut.Parameters.AddWithValue("@Soyisim", txt_secsoyisim.Text);
                komut.Parameters.AddWithValue("@Telefon1", txt_sectel1.Text);
                komut.Parameters.AddWithValue("@Telefon2", txt_sectel2.Text);
                komut.Parameters.AddWithValue("@Email", txt_secemail.Text);
                komut.Parameters.AddWithValue("@Webadres", txt_secwebadres.Text);
                komut.Parameters.AddWithValue("@Aciklama", txt_secaciklama.Text);               
                baglanti.Open();
                sonuc=komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA:" + ex);
            }
            finally
            {
            baglanti.Close();
            }           
            if (sonuc > 0)
            { MessageBox.Show("KAYIT GÜNCELLENDİ");
                RehberListele();
            }
            else
                MessageBox.Show("KAYIT GÜNCELLENDİ");
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = ((Rehber)list_Rehber.SelectedItem).ID;
            SqlCommand komut = new SqlCommand("rehbersil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ID", id);
            baglanti.Open();
            int sonuc = komut.ExecuteNonQuery();
            baglanti.Close();
            if (sonuc > 0)
            {
                MessageBox.Show("KAYIT SİLİNDİ");
                txt_secisim.Text = "";
                txt_secsoyisim.Text = "";
                txt_sectel1.Text = "";
                txt_sectel2.Text = "";
                txt_secemail.Text = "";
                txt_secwebadres.Text = "";
                txt_secaciklama.Text = "";
                RehberListele();
            }
            else
                MessageBox.Show("KAYIT SİLME BAŞARISIZ");
        }
    }
}
