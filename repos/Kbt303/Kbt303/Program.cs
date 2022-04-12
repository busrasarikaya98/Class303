using System;

namespace Kbt303
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var Product1 = new Product();
            Product1.Id = 1;
            Product1.Name = "Elma";
            Product1.Price = 10;
            Product1.currency = Currency.EUR; //hangi para birimi ile çalışıyorsun
            Console.WriteLine(Product1.Name);
            Console.WriteLine(Product1.getPrice().ToString());
            IProduct val = new Car(); //interfaceteki değeri sınıftan çekebildik 
            val.getPrice();


        }
    }
}
