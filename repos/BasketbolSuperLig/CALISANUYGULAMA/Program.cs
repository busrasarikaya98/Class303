using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALISANUYGULAMA
{
    class Program
    {
        static void Main(string[] args)
        {
            Satis1 Personel = new Satis1();
            Personel.SATISMIKTARI = 9;           
            Personel.AD = "BÜŞRA";
            Personel.SOYAD = "SARIKAYA";
            Personel.MAAS = 3000;
            

            Console.WriteLine("AD = " + Personel.AD);
            Console.WriteLine("SOYAD = " + Personel.SOYAD);
            Console.WriteLine("MAAS= " + Personel.MAAS);
            Console.WriteLine("SATIS MIKTARI = " + Personel.SATISMIKTARI);
            Personel.PRIMMIKTARI();
            
            Console.ReadLine();

        }
    }
}
