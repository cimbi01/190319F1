using System;
using System.Collections.Generic;
using System.Text;

namespace F1
{
    abstract class Alakzat
    {
        private string name;
        protected double ter;
        private const string OLDALBEKERESZOVEG = "Add meg az egyik oldalt!";
        public Alakzat(string _nev)
        {
            this.name = _nev;
        }
        public double Olvas()
        {
            double adat = 0;
            adat = Convert.ToDouble(AdatBekeres.EllenorzottBekeres(AdatBekeres.BEKERESOLDAL, OLDALBEKERESZOVEG));
            return adat;
        }
        public abstract double Szamol();
        public void Kiir() => Console.WriteLine("Terulet: {0}", this.ter);
        public double Ter { get; set; }
    }
}
