using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    class Telefon
    {
        public double alisfiyat = 5000;

        public virtual double Fiyat()
        {
            return alisfiyat + 1000;
        }
    }
}
