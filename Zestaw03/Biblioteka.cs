using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw03
{
    class Biblioteka : IZarzadzaniePozycjami
    {
        private string adres;
        private List<Bibliotekarz> bibliotekarze = new List<Bibliotekarz>();
        private List<Katalog> katalogi = new List<Katalog>();
     
        public Biblioteka()
        {
        }

        public Biblioteka(string adres)
        {
            this.adres = adres;
        }

        public void WypiszWszystkiePozycje()
        {
            for (int i = 0; i < katalogi.Count; i++)
            {
               
                    katalogi[i].WypiszWszystkiePozycje();
           
            }
        }

        public int ZnajdzPozycjePoId(int id)
        {
            throw new NotImplementedException();
        }

        public string ZnajdzPozycjePoTytule(string tytul)
        {
            throw new NotImplementedException();
        }

        public void DodajBibliotekarza(Bibliotekarz bibliotekarz)
        {
            bibliotekarze.Add(bibliotekarz);
        }

        public void WypiszBibliotekarzy()
        {
            for (int i=0;i<bibliotekarze.Count;i++)
            {
                Console.Write( i+1 + ":"+"\t");
                bibliotekarze[i].WypiszInfo();
            }
        }

        public void DodajKatalog(Katalog katalog)
        {
            katalogi.Add(katalog);
        }

        public void DodajPozycje(Pozycja pozycja, string dzialTematyczny)
        {
            for (int i=0;i<katalogi.Count;i++)
            {
                if (katalogi[i].DzialTematyczny.Equals(dzialTematyczny))
                {
                    katalogi[i].DodajPozycje(pozycja);
                    break;
                }
            }
        }
    }
}
