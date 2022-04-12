using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQTOOBJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            urunler = new List<urun>();
            urun u = new urun();
            u.urunadi = "YİYECEK";
            Kategori kat01 = new Kategori() { KategoriID = 1, KategoriAdi = "MEYVELER" };
            Kategori kat02 = new Kategori() { KategoriID = 2, KategoriAdi = "SEBZELER" };
            urunler.Add(new urun()
            { urunID = 1, urunadi = "ELMA", kategori = kat01, fiyat = 3.45m, stok = 250 });
            urunler.Add(new urun()
            { urunID = 2, urunadi = "KİRAZ", kategori = kat01, fiyat = 3.75m, stok = 50 });
            urunler.Add(new urun()
            { urunID = 3, urunadi = "KABAK", kategori = kat02, fiyat = 5.35m, stok = 150 });
            urunler.Add(new urun()
            { urunID = 4, urunadi = "PATLICAN", kategori = kat02, fiyat = 6.50m, stok = 350 });
        }
        List<urun> urunler;

        private void Form1_Load(object sender, EventArgs e)
        {
            //sürekli aynı şeyi çağırmamak için buraya yazmadık
        }

        private void button1_Click(object sender, EventArgs e)
        {   //BU LINQ TO OLMADANNNNNNNNNNNN

            //List<urun> secilenler = new List<urun>();
            //foreach(var item in urunler)
            //{
            //    if(item.fiyat>5)            
            //    {
            //        secilenler.Add(item);
            //    }
            //}
            //dataGridView1.DataSource = secilenler; //listelediğimiz verileri çekme

            // LINQ TO OBJECT İLE
            //var sorgu = (from item in urunler where item.fiyat > 5 select item).ToList();
            //dataGridView1.DataSource = sorgu;

            var SORGU = (from x in urunler where x.urunadi.StartsWith("P") && x.stok > 250 select x).ToList(); // P İLE BASLAYAN
            dataGridView1.DataSource = SORGU;
        }
    }
}
