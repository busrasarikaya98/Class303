using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediUygulama
{
    class KrediBilgileri
    {
        public string krediadi;
        public double faizorani;
        public int vadesuresi;

        public void KREDIBILGILERIYAZDIR()
        {
            Console.WriteLine("KREDİ ADI = " + krediadi + "\n" + "FAİZ ORANI = " + faizorani + "\n" + "VADE SÜRESİ = " + vadesuresi + " AY  ");
        }
    }
}
