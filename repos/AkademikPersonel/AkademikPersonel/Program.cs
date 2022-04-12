using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademikPersonel
{
    class Program
    {
        static void Main(string[] args)
        {
            AkademikPersonel personel = new AkademikPersonel();
            personel.personelAdi = "İlber";
            personel.personelSoyadi = "Ortaylı";
            personel.personelUnvan = "Prof. Dr. Tarihçi";
            personel.personelMail = "ilber.ortayli@gmail.com";

            Console.WriteLine("Personelin Adı = " + personel.personelAdi);
            Console.WriteLine("Personelin Soyadı = " + personel.personelSoyadi);
            Console.WriteLine("Personelin Unvanı = " + personel.personelUnvan);
            Console.WriteLine("Personelin Maili = " + personel.personelMail);

            Console.ReadLine();

        }
    }
}
