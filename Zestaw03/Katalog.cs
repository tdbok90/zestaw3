using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw03
{
    class  Katalog
    {
        private string dzialTematyczny;
        private List<Pozycja> pozycje = new List<Pozycja>();

        public Katalog()
        {
        }

        public Katalog(string dzialTermiczny)
        {
            this.dzialTematyczny = dzialTermiczny;
        }

        public void DodajPozycje(Pozycja pozycja)
        {
            pozycje.Add(pozycja);
        }
    }
}
