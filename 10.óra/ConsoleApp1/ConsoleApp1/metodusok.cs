using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public class metodusok
    {
        public List<auto> fajlbol_olvasas(string fajl_nev)
        {
            string[] fajl_sorai = File.ReadAllLines(fajl_nev);

            List<auto> eredmeny = new List<auto>();

            for (int i = 1; i < fajl_sorai.Length; i++) 
            {
                var sor_elemek = fajl_sorai[i].Split(',');

                eredmeny.Add(new auto(int.Parse(sor_elemek[0]), sor_elemek[1], sor_elemek[2], new DateTime(int.Parse(sor_elemek[3])), int.Parse(sor_elemek[4])));
            }

            return eredmeny;
        }

        public string[] hany_eves()
        {
            var lista = fajlbol_olvasas("autok.txt");

            string[] eredmeny = { }; 

            foreach (var item in lista) 
            {
                eredmeny.Append(item.marka);
                var dateTime = DateTime.Now - item.evjarat;
                eredmeny.Append(dateTime.ToString());
            }

            return eredmeny;
        }

        public double atlag_ar()
        {
            var lista = fajlbol_olvasas("autok.txt");

            double osszeg = 0;
            double db = 0;

            foreach (var item in lista) 
            {
                osszeg += item.ar;
                db++;
            }

            return osszeg / db;
        }

        public List<auto> novekvo_sorrend()
        {
            var lista = fajlbol_olvasas("autok.txt");

            return lista.OrderBy(a => a.evjarat).ToList();
        }
    }
}
