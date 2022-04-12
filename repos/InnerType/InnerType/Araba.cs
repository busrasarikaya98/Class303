using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    public class Araba
    {
        public string Marka;
        public string Model;

        public void InfoShow()
        {
            Marka = "Lamborghini";
            Model = "Aventador";
            Console.WriteLine(" Arabanın Markası = " + Marka + " Model = " + Model);
        }
        public class ArabaIcDonanim //innertype
        {
            public string direksiyon;
            public string viteskolu;

            public void IcBilgi()
            {
                direksiyon = "Elektirkli Direksiyon";
                viteskolu = "Tam Otomatik";
                Console.WriteLine(" Direksiyon Türü = " + direksiyon + " Vites Kolu = " + viteskolu);
            }
        }
    }
}
