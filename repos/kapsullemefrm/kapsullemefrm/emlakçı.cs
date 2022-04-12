using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsullemefrm
{
    class emlakçı
    {
        private string semt; //sağ tıkla hızlı eylemler alanı kapsulle otomatik get set
        private int odasayisi;
        private int katno;

        public string Semt { get => semt; set => semt = value.ToUpper(); } //yazılanları daima büyük yapacak
        public int Odasayisi { get => odasayisi; set => odasayisi = Math.Abs(value); } //negatif olmasnı engelliyor
        public int Katno { get => katno; set => katno = Math.Abs(value); }
    }
}
