namespace F1
{
    internal class Haromszog : Alakzat
    {
        #region Private Fields

        private double oldal1, magassag;

        #endregion Private Fields

        #region Public Constructors

        public Haromszog(string _nev = "Háromszög") : base(_nev)
        {
        }

        #endregion Public Constructors

        #region Protected Methods

        protected override void Beolvas()
        {
            this.oldal1 = Olvas("Add meg a háromszog egy oldalát!");
            this.magassag = Olvas("Add meg a háromszog ehhez tartozo magassagat");
        }
        protected override void Szamol()
        {
            this.ter = (this.oldal1 * this.magassag) / 2;
        }

        #endregion Protected Methods
    }
}
