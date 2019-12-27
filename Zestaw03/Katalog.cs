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

        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
        }

    

        public string DzialTematyczny { get => dzialTematyczny; set => dzialTematyczny = value; }
        internal List<Pozycja> Pozycje { get => pozycje; set => pozycje = value; }
  

        public void DodajPozycje(Pozycja pozycja)
        {
            pozycje.Add(pozycja);
        }


        public Pozycja znajdzPozycje(int id)
        {
            for (int i=0;i<pozycje.Count;i++)
            {
                if (pozycje[i].Id == id)
                {
                    return pozycje[i];
                }
             
            }
            return null;
        }
        public Pozycja znajdzPozycje(string tytul, string wydawnictwo)
        {
            for (int i = 0; i < pozycje.Count; i++)
            {
                if (pozycje[i].Tytul.Contains(tytul) || pozycje[i].Wydawnictwo.Contains(wydawnictwo))
                {
                    return pozycje[i];
                }

            }
            return null;
        }

        public void WypiszWszystkiePozycje()
        {
            foreach (Pozycja pozycja in pozycje)
            {

                Console.WriteLine(pozycja.Tytul + " ");

            }
            Console.WriteLine();
        }

    }
}
