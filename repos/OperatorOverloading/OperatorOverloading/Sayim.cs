using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Sayim
    {
        private int sayimiz;
        public Sayim(int gelenSayi)
        {
            this.sayimiz = gelenSayi;
        }
        public void Yazdir()
        {
            Console.WriteLine(this.sayimiz);
        }
        public static int operator +(Sayim a, Sayim b)
        {
            return a.sayimiz + b.sayimiz;
        }
        public static implicit operator int (Sayim a) //kullanıcı tanımlı operator donusturme  //operator ile farklı işlevli yapıları toplattık
        {
            return a.sayimiz;
        }
        public static implicit operator Sayim(int a)
        {
            return new Sayim(a);
        }
    }
}
