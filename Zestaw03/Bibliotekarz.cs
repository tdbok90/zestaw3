using System;

namespace Zestaw03
{
     class Bibliotekarz : Osoba
    {
        private string dataZatrudnienia;
        private double wynagrodzenie;

        public Bibliotekarz()
        {
        }

        public Bibliotekarz( string imie, string nazwisko, string dataZatrudnienia, double wynagrodzenie) : base(imie, nazwisko)
        {
            this.dataZatrudnienia = dataZatrudnienia;
            this.wynagrodzenie = wynagrodzenie;
        }

        public string DataZatrudnienia { get => dataZatrudnienia; set => dataZatrudnienia = value; }
        public double Wynagrodzenie { get => wynagrodzenie; set => wynagrodzenie = value; }

        public override void WypiszInfo()
        {

            base.WypiszInfo();
            Console.Write(dataZatrudnienia + " " + wynagrodzenie + " ");

        }
    }
}