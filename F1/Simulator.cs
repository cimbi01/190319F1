using System;
using System.Collections.Generic;
using System.Text;

namespace F1
{
    static class Simulator
    {
        // Teszteli a meglevo osztályokat, és azok metódusait
        private static Alakzat[] alakzatok;
        public static void Test()
        {

        }
        // alakzat init
        private static void Init(int db = 1)
        {
            // bekéri, milyen tipusú legyen az alakzat
            int alakzattipus;
            string bekeroszoveg =
                    "Miyen típusú Alakzatot szeretnél létrehozni?\n" +
                    "Add meg a megadott számok közül:\n" +
                    "Kör" + Alakzat.ALAKZATTIPUSKOR +
                    "Teglalap" + Alakzat.ALAKZATTIPUSTEGLALAP +
                    "Háromszog" + Alakzat.ALAKZATTIPUSHAROMSZOG;
            for (int i = 0; i < db; i++)
            {
                alakzattipus = AdatBekeres.EllenorzottBekeres<int>(Alakzat.ALAKZATOK, bekeroszoveg);
                alakzatok[0] = Alakzat.GetAlakzat(alakzattipus);
            }
        }
    }
}
