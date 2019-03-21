using System;
using System.Collections.Generic;
using System.Text;

namespace F1
{
    class Kor : Alakzat
    {
        private double r;
        // konstruktor
        public Kor(string _nev =  "Kör") : base(_nev) {}

        protected override void Beolvas()
        {
            this.r = this.Olvas("Add meg a Kör sugarát");
        }

        protected override void Szamol()
        {
            this.ter = Math.Pow(r, 2) * Math.PI;
        }
    }
}
