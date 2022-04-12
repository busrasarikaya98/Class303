using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsansorUygulama
{
    class asansor
    {
        public int asansorno;
        public int ASANSORNO
        {
            get
            {
                return asansorno;
            }
            set
            {
                if (value <= 9)
                { if (value >= 0)
                    {
                        Console.WriteLine(value + ". KATA ÇIKILIYOR");
                    }

                }
                else
                {
                    Console.WriteLine("GİRİLEN KAT NUMARASI BULUNAMADI!");
                }
            }
        }
        

    }
}
