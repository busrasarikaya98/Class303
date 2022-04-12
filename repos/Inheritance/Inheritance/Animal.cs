using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        public string animal_name;
        public string animal_gender;
        public string animal_color;
        public int animal_age;

        public void animalInfoShow()  //METHOD OLUŞTURDUK!
        {
            Console.WriteLine("ANİMAL NAME = " + animal_name);
            Console.WriteLine("ANİMAL GENDER = " + animal_gender);
            Console.WriteLine("ANİMAL COLOR = " + animal_color);
            Console.WriteLine("ANİMAL AGE = " + animal_age);

        }
    }
}
