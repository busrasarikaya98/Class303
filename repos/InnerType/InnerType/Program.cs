using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba bilgi = new Araba();
            bilgi.InfoShow();
            Console.WriteLine();
            Araba.ArabaIcDonanim donanim = new Araba.ArabaIcDonanim();
            donanim.IcBilgi();
            Console.Read();

        }
    }
}
