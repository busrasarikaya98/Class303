using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketbolSuperLig
{
    class Sporcu
    {
        private string ad;
        private string soyad;
        private int yas;
        private string pozisyon;
        
        public string AD
        {
            get { return ad; }
            set { ad = value; }
        }
        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public int YAS
        {
            get { return yas; }
            set { yas = value; }
        }
        public string POZISYON
        {
            get { return pozisyon; }
            set { pozisyon = value; }
        }


    }
}
