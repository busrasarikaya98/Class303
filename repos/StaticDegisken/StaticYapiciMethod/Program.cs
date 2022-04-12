using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapiciMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            User U1 = new User(1, "Franz", "KAFKA");
            U1.showInformation();
            U1.makeRaise(50000);
            Console.ReadKey();
        }
    }
}
