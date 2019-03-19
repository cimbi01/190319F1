using System;
using System.Collections.Generic;
using System.Text;

namespace F1
{
    class Haromszog : Alakzat
    {
        public Haromszog(string _nev = "Háromszög") : base(_nev)
        {}

        protected override void Szamol()
        {
            double oldal1 = this.Olvas("Add meg a háromszog egy oldalát!");
            double magassag = this.Olvas("Add meg a háromszog magassagat");
            this.ter = (oldal1 * magassag) / 2;
        }
    }
}
