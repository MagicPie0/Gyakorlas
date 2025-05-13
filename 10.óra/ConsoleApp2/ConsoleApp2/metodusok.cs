using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    public class metodusok
    {
        static string fajl_nev = "autok.txt";

        public List<autok> fajlbol_olvasas()
        {
            string[] fajl_sorai = File.ReadAllLines(fajl_nev);

            List<autok> eredmeny = new List<autok>();

            for (int i = 1; i < fajl_sorai.Length; i++) 
            {
                var sor_elemei = fajl_sorai[i].Split(',');
               
                eredmeny.Add(new autok( int.Parse(sor_elemei[0]), sor_elemei[1], sor_elemei[2], new DateTime( int.Parse(sor_elemei[3]), 1, 1),  int.Parse(sor_elemei[4])));
            }

            return eredmeny;
        }

        public double atlag_szamitas()
        {
            var lista = fajlbol_olvasas();

            double osszeg = 0;
            double db = 0;

            foreach (var item in lista)
            {
                osszeg += item.ar;
                db++;
            }

            return osszeg / db;
        }

        public string[] ev_szamitas()
        {
            var lista = fajlbol_olvasas();

            string[] eredmeny = { };

            foreach (var item in lista)
            {
                eredmeny.Append(item.marka);

                var ev = DateTime.Now - item.evjarat;
                
                eredmeny.Append(ev.ToString());
            }

            return eredmeny;
        }

        public List<autok> novekvo_sorrend()
        {
            var lista = fajlbol_olvasas();

            return lista.OrderByDescending(a => a.evjarat).ToList();
        }

    }
}
