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
        private List<Autor> autorzy;

        public Ksiazka()
        {
        }
        
      

        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron, List<Autor> autorzy) : base(tytul, id, wydawnictwo, rokWydania)
        {
            this.liczbaStron = liczbaStron;
            this.autorzy = autorzy;
        }

      
        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("LiczbaStron: " + liczbaStron);
            autorzy.ForEach(delegate (Autor autor)
            {
                Console.WriteLine("Autor: " + autor.Imie + "  " + autor.Nazwisko);
            });
       
        }
    }

 
}
