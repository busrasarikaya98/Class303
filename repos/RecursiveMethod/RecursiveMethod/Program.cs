using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveUygulama
{
    class Program
    {
        public static ulong FaktoriyelHesapla (ulong sayi)
        {
            if (sayi<=1)
            {
                return 1;
            }
            else
            {
                return sayi * FaktoriyelHesapla(sayi-(1));
            }
        }
        
        
        public static void Main(string[] args)
        {
         for (ulong sayac =1; sayac<=30; sayac++)
            {
                Console.WriteLine("{0}!={1}", sayac,FaktoriyelHesapla(sayac));
                
            }
            Console.ReadLine();
        }
        
    }
}
