using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAnahtar1
{
    class Program
    {
        static void Main(string[] args)
        {
            Limuzin limuzin = new Limuzin(3000, "Bentley", 5);
            limuzin.OzellikleriGoster();
            Console.Read();
        }
    }
}
