using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismUygulama
{
    public class OrnekSınıf //statik-derleme polymorfizm -overloading
    {
        public int Toplama(int a,int b,int c)
        {
            return a + b + c ;
        }
        public int Toplama(int a,int b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OrnekSınıf YeniNesne = new OrnekSınıf();
            int UcSayiToplami = YeniNesne.Toplama(45, 34, 67);
            int IkiSayiToplami = YeniNesne.Toplama(23, 34);
            Console.WriteLine(IkiSayiToplami);
            Console.WriteLine(UcSayiToplami);
            Console.ReadKey();
        }
    }
}
