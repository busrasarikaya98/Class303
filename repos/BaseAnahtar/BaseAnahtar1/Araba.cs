using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAnahtar1
{
    public class Araba
    {
        public int MotorGucu { get; set; }
        public string Marka { get; set; }

        public Araba(int motorgucu, string marka)
        {
            this.MotorGucu = motorgucu;
            this.Marka = marka;
        }
        public virtual void OzellikleriGoster()
        {
            Console.WriteLine("Marka: {0}", Marka);
            Console.WriteLine("Motor Gücü: {0}", MotorGucu);
        }
    }
}
