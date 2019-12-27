 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw03
{
    interface IZarzadzaniePozycjami
    {
        string ZnajdzPozycjePoTytule(string tytul);
        int ZnajdzPozycjePoId(int id);
        void WypiszWszystkiePozycje();

    }
}
