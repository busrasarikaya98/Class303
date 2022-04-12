using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumUygulama
{
    enum bolumler
    {
        bilgisayar_muhendisligi,
        elektrik_muhendisligi,
        makine_muhendisligi,
        insaat_muhendisligi,
    }
    class Program
    {
        static void Main(string[] args)
        {
            bolumler b;
            for (b = bolumler.bilgisayar_muhendisligi; b <= bolumler.insaat_muhendisligi; b++)
            {
                Console.WriteLine("{0}'nin numberı = {1} ", b, (int)b);
            }
            Console.ReadKey();
        }
    }
}
