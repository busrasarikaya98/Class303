using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnneCocukKalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Anne an = new Anne();
            an.ad = "Mina";
            an.soyad = "URGAN";

            Cocuk coc = new Cocuk();
            coc.ad = "Zeynep";
            coc.soyad = an.soyad;

            Console.WriteLine(an.ad + "\n" + an.soyad);
            an.Annem();
            an.Selam();
            an.Konus();
            

            Console.WriteLine(coc.ad + "\n" + coc.soyad);
            coc.miniCocuk();
            coc.CocukKonus();

            Console.ReadLine();
        }
    }
}
