using System;
namespace Zestaw03
{
    class Osoba
    {
        private string imie;
        private string nazwisko;

        protected string Imie { get => imie; set => imie = value; }
        protected string Nazwisko { get => nazwisko; set => nazwisko = value; }

        public Osoba()
        {
        }

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public virtual void WypiszInfo()
        {
            Console.Write(imie + " " + nazwisko+" ");
        }


    }
}