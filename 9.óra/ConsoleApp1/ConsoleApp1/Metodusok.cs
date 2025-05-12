using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public class Metodusok
    {
        public List<Auto> Fajlbol_olvasas(string fajl_nev)
        {
            string[] fajl_sorai = File.ReadAllLines(fajl_nev);
            List<Auto> eredmeny = new List<Auto>();

            for (int i = 1; i < fajl_sorai.Length; i++)
            {
                var sor_elemei = fajl_sorai[i].Split(',');

                eredmeny.Add(new Auto(int.Parse(sor_elemei[0]), sor_elemei[1], int.Parse(sor_elemei[2]), int.Parse(sor_elemei[3])));
            }

            return eredmeny;
        }

        public double atlag_szamitas()
        {
            var fajl_tartalma = Fajlbol_olvasas("autok.txt");

            double eredmeny = 0;
            double db = 0;

            foreach (var item in fajl_tartalma)
            {
                eredmeny += item.ar;

                if(item.ar > 0)
                {
                    db++;
                }
            }
            return eredmeny / db;
        }
    }
}
