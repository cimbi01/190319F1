using System;
using System.Collections.Generic;
using System.Text;

namespace F1
{
    class Teglalap : Alakzat
    {
        private double oldal1;
        private double oldal2;

        public Teglalap(string _nev = "Téglalap") : base(_nev) {}

        protected override void Beolvas()
        {
            this.oldal1 = this.Olvas("Add meg a téglalap egyik oldalát!");
            this.oldal2 = this.Olvas("Add meg a téglalap másik oldalát");
        }

        protected override void Szamol()
        {
            this.ter = (oldal1 * oldal2);
        }
    }
}
