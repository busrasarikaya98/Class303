using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Partial1 deneme = new Partial1();
            deneme.MesajYazdır1();
            deneme.MesajYazdır2();
            deneme.MesajYazdır3();
            Console.Read();
        }
    }
}
