using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16022022_TelefonRehberi
{
    public class Rehber
    {
        public int ID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Email { get; set; }
        public string WebAdres { get; set; }
        public string Aciklama { get; set; }

        public override string ToString()
        {
            return Isim + " " + Soyisim + " " + Telefon1 + " "+Telefon2+" "+Email+" "+WebAdres+" "+Aciklama;
        }
    }
}
