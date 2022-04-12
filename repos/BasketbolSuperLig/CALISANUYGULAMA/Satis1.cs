using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALISANUYGULAMA
{
    class Satis1:Calisan1
    {
        private int satismiktari;
        public int SATISMIKTARI
        {
            get { return satismiktari; }
            set { satismiktari = value; }
        }

        private int primmiktari;
        public void PRIMMIKTARI()
        {
            
            {
                if (satismiktari < 10)
                {
                    primmiktari = 100;
                }
                else if (satismiktari > 15)
                {
                    primmiktari = 200;
                }
                else if (satismiktari > 20)
                {
                    primmiktari = 300;
                }
                Console.WriteLine("PRIM MIKTARI = " + primmiktari);
            }
        }
    }
}
