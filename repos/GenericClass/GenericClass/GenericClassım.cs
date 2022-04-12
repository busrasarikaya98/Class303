using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class MyList<T>
    {
        private static int nesneSay = 0;
        public MyList()
        {
            nesneSay++;
        }
        public int Say
        {
            get { return nesneSay; }
        }
    }
}
