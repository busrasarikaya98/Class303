using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakineKapsulleme
{
    class Makine
    {
        public int ısı
        {
            get
            {
                return ısı;
            }
            set
            {   
                
                if ( 0 <= value)
                {    if (value <= 100)
                        {
                        Console.WriteLine("ISI NORMALDİR!");
                        }
                   
                }
                if (value < 0)
                {
                    value = 0;
                    Console.WriteLine("MAKİNA FAZLA SOĞUDU! DİKKAT!");
                }
                if (value > 100)
                {
                    value = 100;
                    Console.WriteLine("MAKİNA FAZLA ISINDI! DİKKAT!");
                }
                
                
                
                
                
            }
        }
        
            

    }
}
