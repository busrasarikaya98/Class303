using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YONETIM
{
    class Program
    {
        static void Main(string[] args)
        {
            MuhendisYonetim Muhendis1 = new MuhendisYonetim();
            MuhendisYonetim Muhendis2 = new MuhendisYonetim();
            MuhendisYonetim Muhendis3 = new MuhendisYonetim();

            Muhendis1.personeladi = "BÜŞRA";
            Muhendis1.personelsoyadi = "SARIKAYA";
            Muhendis1.meslekadi = "Endustri Muhendisligi";
            Muhendis1.maas = 5000;

            Muhendis2.personeladi = "ÇİSEM";
            Muhendis2.personelsoyadi = "TÜRKOĞLU";
            Muhendis2.meslekadi = "Elektrik Muhendisligi";
            Muhendis2.maas = 6000;

            Muhendis3.personeladi = "MERVE";
            Muhendis3.personelsoyadi = "ÇATAK";
            Muhendis3.meslekadi = "Bilgisayar Muhendisligi";
            Muhendis3.maas = 7000;

            Muhendis1.PersonelBilgileriGoster();
            Console.WriteLine();
            Muhendis1.ZAM();
            Console.WriteLine("------------------------");
            Muhendis2.PersonelBilgileriGoster();
            Console.WriteLine();
            Muhendis2.ZAM();
            Console.WriteLine("------------------------");
            Muhendis3.PersonelBilgileriGoster();
            Console.WriteLine();
            Muhendis3.ZAM();

            Console.ReadKey();
        }
    }
}
