using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTOOBJECT
{
    public class urun
    {
        public int urunID { get; set; }
        public string urunadi { get; set; }
        public Kategori kategori { get; set; }
        public decimal fiyat { get; set; }
        public int stok { get; set; }
        //public override string ToString()
        //{
        //    return urunID + " " + urunadi;
        //}
    }
    public class Kategori
    {
        public int KategoriID { get; set; }

        public string KategoriAdi { get; set; }
        public override string ToString()
        {
            return KategoriID +" "+ KategoriAdi;
            //buradan yazıyor
        }       
    }
}
