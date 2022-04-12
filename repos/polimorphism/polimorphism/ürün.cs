using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorphism
{
    public class ürün
    {
        public string urunadi { get; set; }
        public double fiyatim { get; set; }
        public ürün()
        {
                
        }
        public ürün(string ad, double fiyat)
        {
            urunadi = ad;
            fiyatim = fiyat;
        }
    }
}
