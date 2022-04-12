using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapiciMethod
{
    class User
    {
        private int userID { get; set; }
        private string name { get; set; }
        private string surname { get; set; }
        private static int salary { get; set; }
        static User()
        {
            salary = 100000;  //maası staticte verdik
        }
        public User(int _userıd, string _name, string _surname)
        {
            userID = _userıd;
            name = _name;
            surname = _surname;
        }
        public void showInformation()
        {
            Console.WriteLine("USER INFORMATION");
            Console.WriteLine(userID);
            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(salary);
        }
        public void makeRaise (int raiseAmount)
        {
            Console.WriteLine("The User is Give a Raise");  //cagırmamamıza ragmen static maası bastı..
            Console.WriteLine("Current Salary = " + (salary + raiseAmount ));  
        }

        
    }
}
