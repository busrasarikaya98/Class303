using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefon Tel1 = new Telefon();
            IkinciTelefon ikincitel = new IkinciTelefon();

            Console.WriteLine("Sıfır Telefon = " + Tel1.Fiyat());
            Console.WriteLine("İkinci El Telefon = " + ikincitel.Fiyat());

            Console.ReadLine();

        }
    }
}
