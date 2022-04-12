using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REHBER
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TelefonList> kisiListesi = new List<TelefonList>();
            TelefonList yenikisi1 = new TelefonList();
            TelefonList yenikisi2 = new TelefonList();
            TelefonList yenikisi3 = new TelefonList();

            yenikisi1.Ad = "Ahmet";
            yenikisi1.Soyad = "Can";
            yenikisi1.Telefon = "050555554";

            yenikisi2.Ad = "Ali";
            yenikisi2.Soyad = "Aydın";
            yenikisi2.Telefon = "13213546541";


            yenikisi3.Ad = "Serdar";
            yenikisi3.Soyad = "Kaymaz";
            yenikisi3.Telefon = "875154";

            kisiListesi.Add(yenikisi1);
            kisiListesi.Add(yenikisi2);
            kisiListesi.Add(yenikisi3);
            for (int i = 0; i < kisiListesi.Count; i++)
            {
                Console.WriteLine(kisiListesi[i].Ad + "\t" + kisiListesi[i].Soyad + "\t" + kisiListesi[i].Telefon);
            }
            Console.ReadKey();
        }
    }
}
