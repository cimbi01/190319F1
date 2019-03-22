namespace F1
{
    internal class Teglalap : Alakzat
    {
        #region Private Fields

        private double oldal1;
        private double oldal2;

        #endregion Private Fields

        #region Public Constructors

        public Teglalap(string _nev = "Téglalap") : base(_nev)
        {
        }

        #endregion Public Constructors

        #region Protected Methods

        protected override void Beolvas()
        {
            this.oldal1 = Olvas("Add meg a téglalap egyik oldalát!");
            this.oldal2 = Olvas("Add meg a téglalap másik oldalát");
        }
        protected override void Szamol()
        {
            this.ter = (this.oldal1 * this.oldal2);
        }

        #endregion Protected Methods
    }
}
