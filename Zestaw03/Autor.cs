namespace Zestaw03
{
    internal class Autor
    {
        private string imie;
        private string nazwisko;

        public Autor()
        {
        }

        public Autor(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
    }
}