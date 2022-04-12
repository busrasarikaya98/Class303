using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphism
{
    class Program
    {
        public class Hesaplama
        {
            public virtual double Alan()
            {
                return 0;
            }
        }
        public class Cember : Hesaplama
        {
            public double YariCap { get; set; }
            public Cember()
            {
                YariCap = 5;
            }
            public override double Alan()
            {
                return (3.14) * Math.Pow(YariCap, 2);
            }
        }
        public class Kare:Hesaplama
        {
            public double Uzunluk { get; set; }
            public Kare()
            {
                Uzunluk = 6;
            }
            public override double Alan()
            {
                return Math.Pow(Uzunluk,2);
            }
        }
        public class Dikdortgen:Hesaplama
        {
            public double Yukseklik { get; set; }
            public double Genislik { get; set; }
            public Dikdortgen()
            {
                Yukseklik = 5.3;
                Genislik = 3.4;
            }
            public override double Alan()
            {
                return Yukseklik * Genislik;
            }
        }

        static void Main(string[] args)
        {
            Cember cember = new Cember();
            Console.WriteLine("Cember Alanı:" + cember.Alan());

            Kare kare = new Kare();
            Console.WriteLine("Kare Alanı:" + kare.Alan());

            Dikdortgen dikdortgen = new Dikdortgen();
            Console.WriteLine("Dikdörtgenin Alan:" + dikdortgen.Alan());

            Console.ReadLine();
        }
    }
}
