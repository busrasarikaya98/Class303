using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        class SampleClass { }
        static void Main(string[] args)
        {
            MyList<int> myIntList = new MyList<int>();
            MyList<int> myIntList2 = new MyList<int>(); //MY LISTLERI SIRALATACAGIZ

            MyList<double> myDoubleList = new MyList<double>();

            MyList<SampleClass> mySampleList = new MyList<SampleClass>();

            Console.WriteLine(myIntList.Say);
            Console.WriteLine(myIntList2.Say);
            Console.WriteLine(myDoubleList.Say);
            Console.WriteLine(mySampleList.Say);
            Console.WriteLine(new MyList<SampleClass>().Say);

            Console.ReadKey();
        }
    }
}
