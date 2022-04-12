using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Kanepe knp1 = new Kanepe();
            Masa calısma_masası = new Masa();
            knp1.renk = "Pembe";
            knp1.kumas = "Deri";
            calısma_masası.renk = "Yeşil";
            calısma_masası.Malzeme = "Ahşap";

            knp1.OzellikYaz();
            calısma_masası.OzellikYaz();

            Console.ReadLine();
        }
    }
}
