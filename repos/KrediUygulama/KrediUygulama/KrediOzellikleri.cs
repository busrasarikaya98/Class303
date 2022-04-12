using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediUygulama
{
    class KrediOzellikleri:KrediBilgileri
    {
        public double kredicekilentutar;
        public void KREDICEKILENTUTARYAZDIR()
        {
            Console.WriteLine("ÇEKMEK İSTEDİĞİNİZ KREDİ TUTARINI GİRİNİZ = ");
            kredicekilentutar = Convert.ToInt32(Console.ReadLine());
        }

        public double geriodenecektutar;
        public void GERIODENECEKTUTARYAZDIR()
        {
            geriodenecektutar = (kredicekilentutar * faizorani) + kredicekilentutar;
            Console.WriteLine("GERİ ÖDEYECEĞİNİZ TUTAR = " + geriodenecektutar+ "TL");
        }
    }
}
