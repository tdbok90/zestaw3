using System;

namespace Zestaw03
{
    abstract class Pozycja
    {
        private string tytul;
        private int id;
        private string wydawnictwo;
        private int rokWydania;

        protected Pozycja()
        {
        }

        protected Pozycja(string tytul, int id, string wydawnictwo, int rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }

     
         public void WypiszInfo()
        {
            Console.WriteLine("Tytuł: " + tytul);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Wydawnictwo: " + wydawnictwo);
            Console.WriteLine("Rok wydania: " + rokWydania );
        }



    }
}