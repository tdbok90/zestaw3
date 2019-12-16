﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw03
{
    class Czasopismo : Pozycja
    {
        private int numer;

        public Czasopismo()
        {
        }

        public Czasopismo(string tytul, int id, string wydawnictwo, int rokWydania, int numer) : base(tytul, id, wydawnictwo, rokWydania)
        {
            this.numer = numer;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Numer: " + numer);
        }
    }
}
