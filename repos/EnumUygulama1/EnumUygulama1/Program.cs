using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumUygulama1
{
    enum Gun { Pazartesi =1, Salı=2, Çarşamba=3, Perşembe=4, Cuma=5, Cumartesi=6, Pazar=7}
    class Program
    {
        static void Main(string[] args)
        {
            int secilenGun = (int)Gun.Cuma;
            if (secilenGun == (int)Gun.Cumartesi || secilenGun==(int)Gun.Pazar)
            {
                Console.WriteLine("Hafta Sonudur.");
            }
            else
            {
                Console.WriteLine("Hafta İçidir.");
            }
            Console.ReadLine();
        }

    }
}
