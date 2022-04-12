using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorphism
{
    class tekstil:ürün
    {
        public string kumasturu { get; set; }
        public string ureticifirma { get; set; }
        public tekstil() //yıkıcı ctor
        {

        }
        public tekstil(string ad, double fiyat, string kumasturum, string ureticifirmam)
        {
            urunadi = ad;
            fiyatim = fiyat;
            kumasturu = kumasturum;
            ureticifirma = ureticifirmam;
        }
    }
}
