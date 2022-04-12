using System;

namespace ArabaPark
{
    public interface IArabaSur
    {
        void Calistir();
        void Sur();
        void Parket();
        void VitesDegistir(int vites);
        void Durdur();
    }
    public class Araba : IArabaSur
    {
        public void Calistir()
        {
            Console.WriteLine("ARABA ÇALIŞTIRILDI");
        }
        public void Sur()
        {
            Console.WriteLine("DEVAM");
        }
        public void Parket()
        {
            Console.WriteLine("PARK YAPILIYOR");
        }
        public void VitesDegistir(int vites)
        {
            Console.WriteLine(vites.ToString() + " . vitese geçildi hızını ona göre ayarla ");
        }

        public void Durdur()
        {
            Console.WriteLine("HEDEFE ULAŞILDI");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Araba ford = new Araba();
            ford.Calistir();
            ford.VitesDegistir(2);
            ford.Sur();//www.bilisimogretmeni.com
            ford.Parket();
            ford.Durdur();
            Console.ReadKey();
        }
    }
}


