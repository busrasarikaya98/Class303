using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAnahtar1
{
    public class Limuzin:Araba
    {
        public int Uzunluk { get; set; }
        public string Segment { get; set; }

        public Limuzin(int motorgucu,string marka,int uzunluk):base(motorgucu,marka)
        {
            this.Uzunluk = uzunluk;
            
        }
        public override void OzellikleriGoster()
        {
            base.OzellikleriGoster();
            Console.WriteLine("Uzunluk: {0}", Uzunluk);
            if (base.MotorGucu>3000)
            {
                Segment = "Exclusive";
            }
            else
            {
                Segment = "Premium";
            }
            Console.WriteLine("Segment:{0}", Segment);
        }
    }
}
