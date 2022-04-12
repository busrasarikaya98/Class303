using System;
using System.Collections.Generic;
using System.Text;

namespace Kbt303
{
    public class Product:BaseProduct,IProduct //ONCE ABSTRACTLAR IMPLEMET EDILIR
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //method yazalım       
    }
}
