using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakineKapsulleme
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Makine makine2 = new Makine();
                Console.WriteLine("LÜTFEN ISI DERECESİNİ GİRİNİZ ? ");
                makine2.ısı = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            
            Console.ReadKey();

            
            
        }
    }
}
