using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketbolSuperLig
{
    class Basketbolcu:Sporcu //kalıtım alacak
    {
        private string ulke;
        private string takim;
        private string lig;

        public string ULKE
        {
            get { return ulke; }
            set { ulke = value; }
        }
        public string TAKIM
        {
            get { return takim; }
            set { takim = value; }
        }
        public string LIG
        {
            get { return lig; }
            set { lig = value; }
        }
    }
}
