using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuslarKalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalitim baykus = new Kalitim();
            baykus.Dogal();
            baykus.BaykusTur();
            
            Console.ReadKey();

        }
        class Cesit
        {
            public Cesit ()
            {
                Console.WriteLine("ÇOK FAZLA KUŞ TÜRÜ VARDIR!!");
            }
        }
        class Kuslar:Cesit
        {
            public void Dogal()
            {
                Console.WriteLine("GECE YIRTICI KUŞLARI EN ÇOK SEVDİĞİM KUŞ TÜRÜDÜR!!");
            }
        }
        class Kalitim:Kuslar
        {
            public void BaykusTur()
            {
            Console.WriteLine("BAYKUŞGİLLER VE PEÇELİ BAYKUŞGİLLER OLMAK ÜZERE İKİ TÜRÜ VARDIR!!");
            }
            
        }
    }
}
