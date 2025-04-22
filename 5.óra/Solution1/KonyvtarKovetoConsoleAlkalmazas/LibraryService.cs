using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KonyvtarKovetoConsoleAlkalmazas
{
    internal class LibraryService
    {

        public string konyHozzaadasa(string cim, string szerzo, DateTime? ev)
        {
            if (!File.Exists("konyvespolc.txt"))
            {
                File.WriteAllText("konyvespolc.txt", cim + ';' + szerzo + ';' + ev + '\n');
                return "Könyv hozzáadva!";
            }
            else
            {
                File.AppendAllText("konyvespolc.txt", cim + ';' + szerzo + ';' + ev + '\n');
                return "Könyv hozzáadva!";
            }
        }

        public string fajlKiolvasas()
        {
            if (File.Exists("konyvespolc.txt"))
            {
                return File.ReadAllText("konyvespolc.txt") == "" ? "Nincs érték" : File.ReadAllText("konyvespolc.txt");
            }

            return "Nincs egy könyv se!";
        }

        public string kolcsonzes(string nev, string cim)
        {
            string fajlTartalma = fajlKiolvasas();

            if (!File.Exists("kolcsonzes.txt"))
            {

                if (fajlTartalma.Contains(cim))
                {
                    File.WriteAllText("kolcsonzes.txt", nev + ';' + cim + '\n');
                    return "Sikeresen kikölcsönözve!";
                }
                else
                {
                    return "Nincs ilyen könyv!";
                }

            }
            else
            {
                if (fajlTartalma.Contains(cim))
                {
                    File.AppendAllText("kolcsonzes.txt", nev + ';' + cim + '\n');
                    return "Sikeresen kikölcsönözve!";
                }
                else
                {
                    return "Nincs ilyen könyv!";
                }

            }
        }

    }
}
