using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KopekKalitim
{
    class Program
    {   public class Canli  //anasınıf   
        {
            public int ayak;
            public int disSayisi;
            public string tur;
        }

       
        public class Kopek:Canli   //kalıtım alır
        {
            public void Havla()  // method tanımladık
            {
                Console.WriteLine("BANA MAMA VER. HAVA SOĞUK, ÜŞÜYORUM, AÇIM!");
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            Kopek kop = new Kopek();     
            kop.ayak = 4;
            kop.disSayisi = 42;
            kop.tur = "C.Lupus";

            Console.WriteLine("KÖPEK AYAK SAYISI = " + kop.ayak);
            Console.WriteLine("KÖPEK DİŞ SAYISI = " + kop.disSayisi);
            Console.WriteLine("KÖPEK TÜRÜ = " + kop.tur);
            kop.Havla();
            Console.ReadLine();    
        }

    }
}
