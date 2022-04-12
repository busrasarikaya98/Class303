using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();  //yeni obje tanımladık
            dog.animal_name = "KANGAL";  //temel sınıf değişkenleri yeni propertyler atadık
            dog.animal_gender = "FEMALE";
            dog.animal_color = "GREY";
            dog.animal_age = 2;
           
            dog.dog_size = 65;  //alt sınıfın değişkenleri
            dog.dog_weight = 45;
            
            dog.animalInfoShow();
            dog.dogMethod();
            
            Console.ReadLine();
        }
    }
}
