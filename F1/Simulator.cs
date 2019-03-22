using System;
using System.Collections.Generic;

namespace F1
{
    internal static class Simulator
    {
        #region Private Fields

        // Teszteli a meglevo osztályokat, és azok metódusait
        private static Alakzat[] alakzatok;

        #endregion Private Fields

        #region Public Methods

        // Init kiszámitja az összes teruletet, majd kiirja majd megkeresi a legnagyobbakat, ha több
        // mint 0 van és kiirja
        public static void Test(int db = 1)
        {
            // alakzatok init
            Init(db);
            List<double> haromszog_teruletek = new List<double>();
            List<double> kor_teruletek = new List<double>();
            List<double> teglalap_teruletek = new List<double>();
            // Bekéri a szükséges adatokat, majd kiírja teruletet majd hozzaadja a teruletet a teruletekhez
            foreach (Alakzat alakzat in alakzatok)
            {
                alakzat.Kiir();
                if (alakzat is Kor)
                {
                    kor_teruletek.Add(alakzat.Ter);
                }

                if (alakzat is Teglalap)
                {
                    teglalap_teruletek.Add(alakzat.Ter);
                }

                if (alakzat is Haromszog)
                {
                    haromszog_teruletek.Add(alakzat.Ter);
                }
            }
            if (haromszog_teruletek.Count > 0)
            {
                Console.WriteLine("Legnagyobb Háromszog terulet:  {0}", MaximumKereses(haromszog_teruletek));
            }
            else
            {
                Console.WriteLine("Nincs háromszög az alakzatok között");
            }

            if (kor_teruletek.Count > 0)
            {
                Console.WriteLine("Legnagyobb Kör terulet:  {0}", MaximumKereses(kor_teruletek));
            }
            else
            {
                Console.WriteLine("Nincs kör az alakzatok között");
            }

            if (teglalap_teruletek.Count > 0)
            {
                Console.WriteLine("Legnagyobb Téglalap terulet:  {0}", MaximumKereses(teglalap_teruletek));
            }
            else
            {
                Console.WriteLine("Nincs téglalap az alakzatok között");
            }
        }

        #endregion Public Methods

        #region Private Methods

        // alakzat init, annyi alakzatot kér be amennyi a db
        private static void Init(int db)
        {
            alakzatok = new Alakzat[db];
            int alakzattipus;
            string bekeroszoveg =
                    "\nMiyen típusú Alakzatot szeretnél létrehozni?\n" +
                    "Add meg a megadott számok közül:\n" +
                    "Kör " + Alakzat.ALAKZATTIPUSKOR +
                    "\nTeglalap " + Alakzat.ALAKZATTIPUSTEGLALAP +
                    "\nHáromszog " + Alakzat.ALAKZATTIPUSHAROMSZOG;
            // bekéri, milyen tipusú legyen az alakzat
            for (int i = 0; i < db; i++)
            {
                alakzattipus = AdatBekeres.EllenorzottBekeres<int>(Alakzat.ALAKZATOK, bekeroszoveg);
                alakzatok[i] = Alakzat.GetAlakzat(alakzattipus);
            }
        }
        private static double MaximumKereses(List<double> teruletek)
        {
            double max = -1;
            foreach (double obj in teruletek)
            {
                if (obj > max)
                {
                    max = obj;
                }
            }
            return max;
        }

        #endregion Private Methods
    }
}
