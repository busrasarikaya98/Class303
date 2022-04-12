using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDeneme
{
    class Vergiler
    {
        public static decimal brutGelir;
        const byte vergiYuzdesi = 30;
        public static decimal GelirVergisiHesapla(decimal x)
        {
            decimal y;
            brutGelir = x;
            y = (x * vergiYuzdesi) / 100;
            return y;
        }
    }
}
