using System;
using System.Collections.Generic;
using System.Text;

namespace F1
{
    class Teglalap : Alakzat
    {
        public Teglalap(string _nev = "Téglalap") : base(_nev) {}

        protected override void Szamol()
        {
            double oldal1 = this.Olvas("Add meg a háromszog egy oldalát!");
            double oldal2 = this.Olvas("Add meg a háromszog magassagat");
            this.ter = (oldal1 * oldal2);
        }
    }
}
