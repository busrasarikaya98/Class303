using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulama
{       public interface IIslem
        {
        void topla (int sayi1 , int sayi2);
        void carp (int sayi1 , int sayi2);
        }
    public class Hesap:IIslem
    {
        public void carp(int sayi1,int sayi2)
        {
            Console.WriteLine(sayi1 + "*" + sayi2+ "=" + sayi1 * sayi2);
        }
        public void topla(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + "+" + sayi2 + "=" + (sayi1 + sayi2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hesap hesap = new Hesap();
            hesap.topla(5, 10);
            hesap.carp(5, 10);
            Console.ReadLine();
        }
    }
}
