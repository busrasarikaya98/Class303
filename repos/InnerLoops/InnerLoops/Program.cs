using System;

namespace InnerLoops
{
    public class Book
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }
    public class User
    {
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public virtual List<Book> ReadedBooks { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
