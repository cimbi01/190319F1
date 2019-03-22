using System;

namespace F1
{
    internal class Kor : Alakzat
    {
        #region Private Fields

        private double r;

        #endregion Private Fields

        #region Public Constructors

        public Kor(string _nev = "Kör") : base(_nev)
        {
        }

        #endregion Public Constructors

        #region Protected Methods

        protected override void Beolvas()
        {
            this.r = Olvas("Add meg a Kör sugarát");
        }
        protected override void Szamol()
        {
            this.ter = Math.Pow(this.r, 2) * Math.PI;
        }

        #endregion Protected Methods
    }
}
