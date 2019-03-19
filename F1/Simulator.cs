using System;
using System.Collections.Generic;
using System.Text;

namespace F1
{
    static class Simulator
    {
        // Teszteli a meglevo osztályokat, és azok metódusait
        private static Alakzat[] alakzatok;
        public static void Test(int db = 1)
        {
            // alakzatok init
            Init(db);
            //felesleges ide több háromszögterulet, lehetne csak egy
            List<double> haromszog_teruletek = new List<double>();
            List<double> kor_teruletek = new List<double>();
            List<double> teglalap_teruletek = new List<double>();
            // Bekéri a szükséges adatokat, majd kiírja teruletet
            // majd hozzaadja a teruletet a teruletekhez
            foreach (Alakzat alakzat in alakzatok)
            {
                alakzat.Kiir();
                if (alakzat is Kor) kor_teruletek.Add(alakzat.Ter);
                if (alakzat is Teglalap) teglalap_teruletek.Add(alakzat.Ter);
                if (alakzat is Haromszog) haromszog_teruletek.Add(alakzat.Ter);
            }
            if (haromszog_teruletek.Count > 0)
                Console.WriteLine("Legnagyobb Háromszog terulet:  {0}", MaximumKereses(haromszog_teruletek));
            else
                Console.WriteLine("Nincs háromszög az alakzatok között");
            if (kor_teruletek.Count > 0)
                Console.WriteLine("Legnagyobb Kör terulet:  {0}", MaximumKereses(kor_teruletek));
            else
                Console.WriteLine("Nincs kör az alakzatok között");
            if (teglalap_teruletek.Count > 0)
                Console.WriteLine("Legnagyobb Téglalap terulet:  {0}", MaximumKereses(teglalap_teruletek));
            else
                Console.WriteLine("Nincs téglalap az alakzatok között");
        }
        // alakzat init
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
                    max = obj;
            }
            return max;
        }
    }
}
