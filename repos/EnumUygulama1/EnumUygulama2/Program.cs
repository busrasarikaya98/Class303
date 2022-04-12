using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumUygulama2
{   public enum EvTuru
    {
        Belirsiz,
        Apart,
        Apartman,
        Mustakil,
        Residence,
        Villa,
    }
    public class Ev
    {
        public EvTuru ozellik;
        public Ev()
        {
            ozellik = EvTuru.Belirsiz;
        }
        public void Goruntule()
        {
            Console.WriteLine("Konut Türü:{0}", ozellik);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ev bicim = new Ev();
            bicim.Goruntule();
            bicim.ozellik = EvTuru.Villa;
            bicim.Goruntule();
            Console.WriteLine();
            Console.Read();
        }
    }
}
