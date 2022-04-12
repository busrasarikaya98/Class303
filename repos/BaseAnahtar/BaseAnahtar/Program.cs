using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAnahtar
{
    class Program
    {   
        class Tanısma
        {
            protected void İsminizNe() //korumalı metot
            {
                Console.WriteLine("İsminiz Nedir? ");
            }
        }
        class Tanısma1:Tanısma
        {
            public void YasKac()
            {
                base.İsminizNe();
                Console.WriteLine("Yaşınız Kaç Acaba?");
            }
        }
        class Tanısma2:Tanısma1
        {
            public void MeslekNe()
            {
                base.YasKac();
                Console.WriteLine("Mesleğiniz Nedir Peki?");
            }
        }
        static void Main(string[] args)
        {
            Tanısma2 tanis = new Tanısma2();
            tanis.MeslekNe();
            //Tanısma1 tani = new Tanısma1();
            //tani.YasKac();
            Console.Read();
        }
    }
}
