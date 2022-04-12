using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketbolSuperLig
{
    class Program
    {
        static void Main(string[] args)
        {
            Basketbolcu KOBE = new Basketbolcu();
            KOBE.ULKE = "Amerika";
            KOBE.LIG = "NBA";
            KOBE.TAKIM = "Los Angeles Lakers";
            KOBE.AD = "KOBE";
            KOBE.
            KOBE.SOYAD = "BRYANT";
            KOBE.POZISYON = "Şütor Grd"; //kısa forvet
            KOBE.YAS = 41;

            Console.WriteLine("AD = " + KOBE.AD);
            Console.WriteLine("SOYAD = " + KOBE.SOYAD);            
            Console.WriteLine("YAS = " + KOBE.YAS);
            Console.WriteLine("POZİSYON= " + KOBE.POZISYON);
            
            Console.WriteLine("ÜLKE = " + KOBE.ULKE);
            Console.WriteLine("LİG = " + KOBE.LIG);
            Console.WriteLine("TAKIM = " + KOBE.TAKIM);

            Console.ReadLine();
        }
    }
}
