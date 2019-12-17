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

        public int Id { get => id; set => id = value; }
        public string Tytul { get => tytul; set => tytul = value; }
        public string Wydawnictwo { get => wydawnictwo; set => wydawnictwo = value; }

        public virtual void WypiszInfo()
        {
            Console.WriteLine("Tytuł: " + tytul);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Wydawnictwo: " + wydawnictwo);
            Console.WriteLine("Rok wydania: " + rokWydania );
        }




    }
}