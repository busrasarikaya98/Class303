using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticUygulama
{
    class Program
    {
        public static void Main(string[] args)
        {
            var toplam = Hesapla.topla(100, 200);
            Console.WriteLine("TOPLAM = " + toplam);
            Console.ReadKey();
        }
    }
}
