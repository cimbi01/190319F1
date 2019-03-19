using System;
using System.Collections.Generic;
using System.Text;

namespace F1
{
    abstract class Alakzat
    {
        // alakzattípusok
        public const int ALAKZATTIPUSKOR = 1;
        public const int ALAKZATTIPUSHAROMSZOG = 2;
        public const int ALAKZATTIPUSTEGLALAP = 3;
        private const int ALAKZATOKSZAMA = 3;
        public static readonly List<int> ALAKZATOK = new List<int>();
        // konstruktor 
        static Alakzat()
        {
            for (int i = 1; i < ALAKZATOKSZAMA+1; i++)
            {
                ALAKZATOK.Add(i);
            }
        }

        private readonly string name;
        protected double ter;
        public Alakzat(string _nev)
        {
            this.name = _nev;
            this.Szamol();
        }
        protected double Olvas(string bekeroszoveg)
        {
            double adat = 0;
            adat = Convert.ToDouble(AdatBekeres.EllenorzottBekeres<double>(bekeroszoveg));
            return adat;
        }
        protected abstract void Szamol();
        public void Kiir() {Console.WriteLine("{0} Terulet: {1}", this.name, this.Ter); }
        public double Ter { get { return this.ter; } }

        // visszaad egy alakzatot megadott alakzattipus függvényében
        public static Alakzat GetAlakzat(int alakzattipus)
        {
            Alakzat alakzat = null;
            switch (alakzattipus)
            {
                case ALAKZATTIPUSHAROMSZOG:
                    alakzat = new Haromszog();
                    break;
                case ALAKZATTIPUSKOR:
                    alakzat = new Kor();
                    break;
                case ALAKZATTIPUSTEGLALAP:
                    alakzat = new Teglalap();
                    break;
            }
            return alakzat;
        }
    }
}
