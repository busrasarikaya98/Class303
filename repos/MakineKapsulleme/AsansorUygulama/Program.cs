using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsansorUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            asansor asansor1 = new asansor();
            Console.WriteLine("LÜTFEN KAT NUMARASINI GİRİNİZ = ");
            asansor1.ASANSORNO = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
