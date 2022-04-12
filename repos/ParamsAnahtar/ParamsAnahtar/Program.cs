using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsAnahtar
{
    class Program
    {
        public static int SayilariTopla(params int[]sayilar)
        {
            int toplam = 0;
            foreach (int i in sayilar)
            {
                toplam += i;
            }
            return toplam;
        }
        static void Main(string[] args)
        {
            int result1 = SayilariTopla(22);
            int result2 = SayilariTopla(7, 5, -3);
            int result3 = SayilariTopla(-8, 8, 7, 5, -7, 2, 9, 0);
            Console.WriteLine("SONUÇLARI GÖSTER = " + result1);
            Console.WriteLine("SONUÇLARI GÖSTER = " + result2);
            Console.WriteLine("SONUÇLARI GÖSTER = " + result3);

            Console.ReadLine();

        }
    }
}
