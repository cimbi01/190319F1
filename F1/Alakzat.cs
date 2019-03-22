using System;
using System.Collections.Generic;

namespace F1
{
    internal abstract class Alakzat
    {
        #region Public Fields

        public const int ALAKZATTIPUSHAROMSZOG = 2;
        // alakzattípusok és az alakzati tipusok nevei
        public const int ALAKZATTIPUSKOR = 1;
        public const int ALAKZATTIPUSTEGLALAP = 3;
        public static readonly List<int> ALAKZATOK = new List<int>();

        #endregion Public Fields

        #region Protected Fields

        // terulet
        protected double ter;

        #endregion Protected Fields

        #region Private Fields

        private const int ALAKZATOKSZAMA = 3;
        private readonly string name;

        #endregion Private Fields

        #region Public Constructors

        static Alakzat()
        {
            for (int i = 1; i < ALAKZATOKSZAMA + 1; i++)
            {
                ALAKZATOK.Add(i);
            }
        }
        // LEHETNE ÚGYIS, HOGY AZ ALAKZAT TIPUSÁT ADJÁK MEG ÉS KONSTRUKTOR ELDÖNTI MI A NEVE
        public Alakzat(string _nev)
        {
            this.name = _nev;
            Beolvas();
            Szamol();
        }

        #endregion Public Constructors

        #region Public Properties

        public double Ter => this.ter;

        #endregion Public Properties

        #region Public Methods

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
        public void Kiir()
        {
            Console.WriteLine("{0} Terulet: {1}", this.name, Ter);
        }

        #endregion Public Methods

        #region Protected Methods

        // minden adatot beolvas
        protected abstract void Beolvas();
        // visszaadja a bekeroszoveg által kért vélhetően double adatot ami nagyobb mint 0
        protected double Olvas(string bekeroszoveg)
        {
            return AdatBekeres.EllenorzottBekeres(bekeroszoveg);
        }
        protected abstract void Szamol();

        #endregion Protected Methods
    }
}
