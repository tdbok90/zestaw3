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
        private Autor autor;

        public Ksiazka()
        {
        }
        
      

        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron, Autor autor) : base(tytul, id, wydawnictwo, rokWydania)
        {
            this.liczbaStron = liczbaStron;
            this.autor = autor;
        }

      
        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("LiczbaStron: " + liczbaStron);
            Console.WriteLine("Autor: " + autor.Imie + " " + autor.Nazwisko);
        }
    }

 
}
