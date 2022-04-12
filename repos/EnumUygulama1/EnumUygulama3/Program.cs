using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumUygulama3
{
    class Program
    {
        enum Kadrolar : byte
        {
            Başhekim,
            Mali_Mudur,
            Doktor,
            Hemşire,
        }
        static void PersonelBul(Kadrolar e)
        {
            switch (e)
            {
                case Kadrolar.Başhekim:
                    Console.WriteLine("Başhekimsiniz->5000 TL");
                    break;
                case Kadrolar.Mali_Mudur:
                    Console.WriteLine("Mali İşler Müdürüsünüz-->4500 TL");
                    break;
                case Kadrolar.Doktor:
                    Console.WriteLine("Doktorsunuz->3000 TL");
                    break;
                case Kadrolar.Hemşire:
                    Console.WriteLine("Hemşiresiniz-->1000 TL");
                    break;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kadro Türünü seçiniz");
            Console.WriteLine();
            Console.WriteLine("Başhekim->1");
            Console.WriteLine("Mali İşler Müdürü->2");
            Console.WriteLine("Doktor->3");
            Console.WriteLine("Hemşire->4");
            Console.WriteLine("Seçiminiz");
            Kadrolar personel = (Kadrolar)Convert.ToByte(Console.ReadLine());
            PersonelBul(personel - 1);
            Console.ReadLine();
        }
    }
}

