using System;
using System.Collections.Generic;
using System.Text;

namespace F1
{
    abstract class Alakzat
    {
        private readonly string name;
        protected double ter;
        private const string OLDALBEKERESZOVEG = "Add meg az egyik oldalt!";
        public Alakzat(string _nev)
        {
            this.name = _nev;
        }
        protected double Olvas(string bekeroszoveg)
        {
            double adat = 0;
            adat = Convert.ToDouble(AdatBekeres.EllenorzottBekeres<double>(OLDALBEKERESZOVEG));
            return adat;
        }
        protected abstract void Szamol();
        public void Kiir() { Console.WriteLine("Terulet: {0}", this.Ter); }
        public double Ter { get; set; }
    }
}
