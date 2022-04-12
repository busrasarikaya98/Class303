using System;
using System.Collections.Generic;
using System.Text;

namespace Kbt303
{
    public class Car :BaseProduct,IProduct //interface implement ettik //her yerden erişebildik //once abstractlar
    {
        public int Id { get; set; }
        public string Color { get; set; }
        
        //INTERFACE GEÇİŞ
    }
}
