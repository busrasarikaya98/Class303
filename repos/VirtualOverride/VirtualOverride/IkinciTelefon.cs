using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    class IkinciTelefon:Telefon
    {
        public override double Fiyat()
        {
            return alisfiyat - 400;
        }
    }
}
