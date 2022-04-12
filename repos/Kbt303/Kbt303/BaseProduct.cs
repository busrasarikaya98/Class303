using System;
using System.Collections.Generic;
using System.Text;

namespace Kbt303
{
    public abstract class BaseProduct //ortak ozellikleri bir yere koyma amacı abstract hem car a hem product a koyduk
        //tekrar eden kodları abstract class a yazarız interfaceten once implement ederiz
    {
        public Currency currency { get; set; }
        public double Price { get; set; }

        public double getPrice() //istersek classın içindeki bir değeri getirir console.writeline a yazarken
        {
            {
                return this.Price;
            }
        }
    }
}
