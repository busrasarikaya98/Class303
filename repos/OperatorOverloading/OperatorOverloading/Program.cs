using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Sayim s1 = new Sayim(10);
            Sayim s2 = new Sayim(10);
            int s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.ReadKey();
        }
    }
}
