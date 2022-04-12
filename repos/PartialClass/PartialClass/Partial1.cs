using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Partial1
    {
        public void MesajYazdır1()
        {
            Console.WriteLine("Hey!!");
        }
    }
    public partial class Partial1
    {
        public void MesajYazdır2()
        {
            Console.WriteLine("Ben");
        }
    }
    public partial class Partial1
    {
        public void MesajYazdır3()
        {
            Console.WriteLine("Partial Class'ım!!");
        }
    }
}
