using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> yazarlar = new List<string>();
            yazarlar.Add("CEMAL SÜREYA");
            yazarlar.Add("FYODOR DOSTOYEVSKI");
            yazarlar.Add("MONTAIGNE");
            yazarlar.Add("TURGUT UYAR");
            yazarlar.Add("OĞUZ ATAY");

            Console.WriteLine();
            Console.WriteLine("LİSTEDEKİ YAZAR SAYISI = {0}", yazarlar.Count);
            foreach(string yazar in yazarlar)
            {
                Console.WriteLine(yazar);
            }
            
            Console.ReadKey();
        }
    }
}
