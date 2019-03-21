using System;
using System.Collections.Generic;
using System.Text;

namespace F1
{
    class Haromszog : Alakzat
    {
        private double oldal1, magassag;
        public Haromszog(string _nev = "Háromszög") : base(_nev) {}
        protected override void Beolvas()
        {
            this.oldal1 = this.Olvas("Add meg a háromszog egy oldalát!");
            this.magassag = this.Olvas("Add meg a háromszog ehhez tartozo magassagat");
        }
        protected override void Szamol()
        {
            this.ter = (oldal1 * magassag) / 2;
        }
    }
}
