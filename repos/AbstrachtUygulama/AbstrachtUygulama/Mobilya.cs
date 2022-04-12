using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractUygulama
{
    abstract class Mobilya
    {
        public string renk;
        abstract public void OzellikYaz(); //; ile bildirim yaptık
    }
    class Kanepe:Mobilya
    {
        public string kumas;
        public override void OzellikYaz()
        {            
            {
                Console.WriteLine("KANEPENİN ÖZELLİKLERİ = ");
                Console.WriteLine("Renk = {0}", renk);
                Console.WriteLine("Kumaş = {0}", kumas);
            }
        }
    }

    class Masa:Mobilya
    {
        public string Malzeme;
        public override void OzellikYaz()
        {
            {
                Console.WriteLine("MASANIN ÖZELLİKLERİ = ");
                Console.WriteLine("Renk = {0}", renk);
                Console.WriteLine("Malzeme = {0}", Malzeme);
            }
        }
    }

}
