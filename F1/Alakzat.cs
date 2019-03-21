using System;
using System.Collections.Generic;
using System.Text;

namespace F1
{
    abstract class Alakzat
    {
        // alakzattípusok és az alakzati tipusok nevei
        public const int ALAKZATTIPUSKOR = 1;
        public const int ALAKZATTIPUSHAROMSZOG = 2;
        public const int ALAKZATTIPUSTEGLALAP = 3;
        private const int ALAKZATOKSZAMA = 3;
        public static readonly List<int> ALAKZATOK = new List<int>();
        static Alakzat()
        {
            for (int i = 1; i < ALAKZATOKSZAMA+1; i++)
            {
                ALAKZATOK.Add(i);
            }
        }
        private readonly string name;
        // terulet
        protected double ter;
        // LEHETNE ÚGYIS, HOGY AZ ALAKZAT TIPUSÁT ADJÁK MEG
        // ÉS KONSTRUKTOR ELDÖNTI MI A NEVE
        public Alakzat(string _nev)
        {
            this.name = _nev;
            this.Beolvas();
            this.Szamol();
        }
        // minden adatot beolvas
        protected abstract void Beolvas();
        // visszaadja a bekeroszoveg által kért
        // vélhetően double adatot
        // ami nagyobb mint 0
        protected double Olvas(string bekeroszoveg)
        {
            return AdatBekeres.EllenorzottBekeres(bekeroszoveg);
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
