using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw03
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;

        public Ksiazka()
        {
        }

        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron) : base(tytul, id, wydawnictwo, rokWydania)
        {
            this.liczbaStron = liczbaStron;
        }




    }
}
