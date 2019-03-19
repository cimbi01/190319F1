using System;
using System.Collections.Generic;
using System.Text;

namespace F1
{
    class Kor : Alakzat
    {
        public Kor(string _nev =  "Kör") : base(_nev) {}

        protected override void Szamol()
        {
            double r = this.Olvas("Add meg a Kör sugarát");
            this.ter = Math.Pow(r, 2) * Math.PI;
        }
    }
}
