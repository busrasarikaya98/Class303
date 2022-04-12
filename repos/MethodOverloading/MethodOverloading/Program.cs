using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        //1.METOT
        static void Islem(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            Console.WriteLine("İŞLEMİN SONUCU = " + sonuc);
        }
        //2.METOT
        static void Islem(int sayi1, int sayi2, int sayi3 )
        {
            int sonuc = sayi1 * sayi2 * sayi3;
            Console.WriteLine("İŞLEMİN SONUCU = " + sonuc);
        }

        //3.METOT
        static void Islem(int sayi1 , int sayi2, int sayi3, int sayi4)
        {
            int sonuc = sayi1 + sayi2 + sayi3 + sayi4 ;
            Console.WriteLine("İŞLEMİN SONUCU = " + sonuc);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("2 PARAMETRE=BÖLME İŞLEMİ \n" + "3 PARAMETRE=ÇARPMA İŞLEMİ \n" + "4 PARAMETRE=TOPLAMA İŞLEMİ \n");
            Islem(250, 5);
            Islem(30, 4, 5);
            Islem(13, 3, 19, 8);

            Console.ReadLine();
        }
    }
}
