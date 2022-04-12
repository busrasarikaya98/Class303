using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim2;
            Console.WriteLine("BANKAMIZA HOŞGELDİNİZ" + "\n" + "LÜTFEN BİLGİ ALMAK İSTEDİĞİNİZ KREDİ ÇEŞİDİNİ SEÇİNİZ = " + "\n"
                + "1-İHTİYAÇ KREDİSİ 2-KONUT KREDİSİ 3-ARAÇ KREDİSİ 4-EĞİTİM KREDİSİ");
            secim2 = Convert.ToInt32(Console.ReadLine());
            if (secim2 == 1)
            {
                KrediOzellikleri ihtiyackredisi = new KrediOzellikleri();
                ihtiyackredisi.krediadi = "İHTİYAÇ KREDİSİ";
                ihtiyackredisi.vadesuresi = 12;
                ihtiyackredisi.faizorani = 0.65;
                ihtiyackredisi.KREDIBILGILERIYAZDIR();
                ihtiyackredisi.KREDICEKILENTUTARYAZDIR();
                ihtiyackredisi.GERIODENECEKTUTARYAZDIR();
            }
            if (secim2 == 2)
            {
                KrediOzellikleri konutkredisi = new KrediOzellikleri();
                konutkredisi.krediadi = "KONUT KREDİSİ";
                konutkredisi.vadesuresi = 48;
                konutkredisi.faizorani = 0.95;
                konutkredisi.KREDIBILGILERIYAZDIR();
                konutkredisi.KREDICEKILENTUTARYAZDIR();
                konutkredisi.GERIODENECEKTUTARYAZDIR();
            }
            if (secim2 == 3)
            {
                KrediOzellikleri arackredisi = new KrediOzellikleri();
                arackredisi.krediadi = "ARAÇ KREDİSİ";
                arackredisi.vadesuresi = 24;
                arackredisi.faizorani = 0.45;
                arackredisi.KREDIBILGILERIYAZDIR();
                arackredisi.KREDICEKILENTUTARYAZDIR();
                arackredisi.GERIODENECEKTUTARYAZDIR();
            }
            if (secim2 == 4)
            {
                KrediOzellikleri egitimkredisi = new KrediOzellikleri();
                egitimkredisi.krediadi = "EĞİTİM KREDİSİ";
                egitimkredisi.vadesuresi = 36;
                egitimkredisi.faizorani = 0.35;
                egitimkredisi.KREDIBILGILERIYAZDIR();
                egitimkredisi.KREDICEKILENTUTARYAZDIR();
                egitimkredisi.GERIODENECEKTUTARYAZDIR();
            }
            Console.ReadLine();
        }
    }
}
