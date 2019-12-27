using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw03
{
    class Program
    {
        static void Main(string[] args)
        {


            Autor autor1 = new Autor("Jan", "Niziołek");
            Autor autor2 = new Autor("Krzysztof", "Szczeka");
            List<Autor> pierwsiAutorzy = new List<Autor>();
            pierwsiAutorzy.Add(autor1);
            pierwsiAutorzy.Add(autor2);


            Autor autor3 = new Autor("Tadeusz", "Bak");
            Autor autor4 = new Autor("Sandra", "Michalczyk" );
            List<Autor> drudzyAutorzy = new List<Autor>();
            drudzyAutorzy.Add(autor3);
            drudzyAutorzy.Add(autor4);

            Katalog historia = new Katalog("Historyczny");
            Pozycja biblia = new Ksiazka("Biblia", 1, "Maryjne", 1992, 1000, pierwsiAutorzy);
            Pozycja historiaSwiata = new Ksiazka("Historia świata", 2, "ISBN", 2008, 234, pierwsiAutorzy);
            Pozycja kobietyZeSlynnychObrazow = new Ksiazka("Kobiety ze słynnych obrazów",3, "Wydawnictwo Lira", 2019, 336, drudzyAutorzy);
            Pozycja programistaMagazyn = new Czasopismo("Programista Polski", 5, "Nauka i rodzina", 2019, 12);
            historia.DodajPozycje(biblia);
            historia.DodajPozycje(historiaSwiata);
            historia.DodajPozycje(kobietyZeSlynnychObrazow);

            biblia.WypiszInfo();
            Console.WriteLine();
            historiaSwiata.WypiszInfo();
            Console.WriteLine();
            kobietyZeSlynnychObrazow.WypiszInfo();
            Console.WriteLine();
            int id = 1;
            Pozycja szukanaPozycja = historia.znajdzPozycje(id);
            Console.WriteLine("Pozycja szukana po id= " + id);
            if (szukanaPozycja != null)
            {
                szukanaPozycja.WypiszInfo();
            } 
            else
            {
                Console.WriteLine("Nie znaleziono pozycj.");
            }

            Console.WriteLine();
            szukanaPozycja = historia.znajdzPozycje("Biblia", "Maryjne");
            Console.WriteLine("Szukana pozycja po tytule i wydawnictwu");
            szukanaPozycja.WypiszInfo();
            Console.WriteLine();


           
            Bibliotekarz nowaOsoba = new Bibliotekarz("Karol", "Bąk", "17-01-2019", 4500);
            Bibliotekarz nowaOsoba1 = new Bibliotekarz("Sandra", "Bąk", "15-01-2020", 3600);
            Biblioteka bibliotekaRadosna = new Biblioteka();
            bibliotekaRadosna.DodajBibliotekarza(nowaOsoba);
            bibliotekaRadosna.DodajBibliotekarza(nowaOsoba1);
            bibliotekaRadosna.WypiszBibliotekarzy();

            bibliotekaRadosna.WypiszWszystkiePozycje();

            Console.WriteLine();
            historia.WypiszWszystkiePozycje();

            Console.ReadLine();

          
        }
    }
}
