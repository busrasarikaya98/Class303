using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisUYG
{
    class Satis:Calisan //kalitim aldik
    {
        private int satismiktari;
        public int SATISMIKTARI
        {
            get { return satismiktari; }
            set { satismiktari = value; }
        }

        private int primmiktari;
        public int PRIMMIKTARI
        {
            get { return primmiktari; }
            set
            {
                if(SATISMIKTARI>10)
                {
                    PRIMMIKTARI = 100;
                }
                if(SATISMIKTARI>15)
                {
                    PRIMMIKTARI = 200;
                }
                if (SATISMIKTARI>20)
                {
                    PRIMMIKTARI = 300;
                }
            }
        }
    }
}
