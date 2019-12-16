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
            Katalog historia = new Katalog("Historyczny");
            Pozycja biblia = new Ksiazka("Biblia", 1, "Maryjne", 1992, 1000, autor1);
            Pozycja historiaSwiata = new Ksiazka("Historia świata", 2, "ISBN", 2008, 234, autor2);
            Pozycja kobietyZeSlynnychObrazow = new Ksiazka("Kobiety ze słynnych obrazów",3, "Wydawnictwo Lira", 2019, 336, new Autor("Iwona", "Kienzler"));
            historia.DodajPozycje(biblia);
            historia.DodajPozycje(historiaSwiata);
            historia.DodajPozycje(kobietyZeSlynnychObrazow);

            biblia.WypiszInfo();
            Console.WriteLine();
            historiaSwiata.WypiszInfo();
            Console.WriteLine();
            kobietyZeSlynnychObrazow.WypiszInfo();

            Console.ReadLine();
        }
    }
}
