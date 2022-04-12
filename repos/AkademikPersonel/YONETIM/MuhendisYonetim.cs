using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YONETIM
{
    class MuhendisYonetim:PersonelYonetim
    {
        public string meslekadi;
        public int maas;
        private int zam;
        public void ZAM()
        {
          
            {
            if(meslekadi == "Bilgisayar Muhendisligi")
                {
                    zam = 1000;
                    maas = maas + zam;
                    Console.WriteLine("Personel Zam Almıştır.! :)"+ "\n"+ "Personelin Yeni Maaşı:" + maas);
                }
            else
                {
                    zam = -550;
                    maas = maas + zam;
                    Console.WriteLine("Üzgünüz.. Maaşınız Düşürüldü :(" + "\n" + "Personelin Yeni Maaşı:" + maas);
                }
            }
        }
        public void PersonelBilgileriGoster()
        {
            Console.WriteLine("Personelin Adı:" + personeladi +"\n"+"Personelin Soyadı: " + personelsoyadi + "\n" + 
                "Personelin Mesleği: " + meslekadi + "\n" + "Personelin Eski Maaşı: " +maas);
        }

    }
}
