using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Tracing;

namespace diakokjegyeikezelo
{
    //A dani munkája(nem tökéletes)
    internal partial class Program
    {
        static List<Diak> diakok = new List<Diak>();

        static void Main(string[] args)
        {
            if (File.Exists("diakok.txt"))
            {
                string[] sorok = File.ReadAllLines("diakok.txt");
                foreach (string sor in sorok)
                {
                    diakok.Add(Diak.FromSor(sor));
                }
            }
            while (true)
            {
                Console.WriteLine("\n1. Új tanuló hozzáadása");
                Console.WriteLine("2. Jegy hozzáadása tanulóhoz");
                Console.WriteLine("3. Egy tanuló jegyei");
                Console.WriteLine("4. Összes tanuló listázása");
                Console.WriteLine("5. Kilépés és mentés");
                Console.Write("Válassz egy számot: ");
                string valasz = Console.ReadLine();

                if (valasz == "1")
                    UjDiak();
                else if (valasz == "2")
                    JegyHozzaadas();
                else if (valasz == "3")
                    JegyekMegjelenitese();
                else if (valasz == "4")
                    OsszesDiak();
                else if (valasz == "5")
                {
                    Mentes();
                    break;
                }
                else
                    Console.WriteLine("Hibás választás, próbáld újra!");
            }
        }

        static void UjDiak()
        {
            Console.Write("Add meg a diák nevét: ");
            string nev = Console.ReadLine();
            Diak diak = new Diak(nev);
            diakok.Add(diak);
            Console.WriteLine("Diák hozzáadva.");
        }

        static void JegyHozzaadas()
        {
            Console.Write("Kinek szeretnél jegyet adni? Írd be a nevét: ");
            string nev = Console.ReadLine();
            Diak diak = diakok.Find(d => d.Nev == nev);
            if (diak == null)
            {
                Console.WriteLine("Nincs ilyen nevű diák.");
                return;
            }
            Console.Write("Add meg a jegyet (szám maximum 5-ig): ");
            string input = Console.ReadLine();
            int jegy = int.Parse(input);
            if (jegy < 5)
            {


                diak.Jegyek.Add(jegy);
                Console.WriteLine("Jegy hozzáadva.");

            }
            else
            {
                Console.WriteLine("Magyarországon nem adható ilyen jegy!");
            }

        }

        static void JegyekMegjelenitese()
        {
            Console.Write("Kinek szeretnéd látni a jegyeit? ");
            string nev = Console.ReadLine();
            Diak diak = diakok.Find(d => d.Nev == nev);
            if (diak == null)
            {
                Console.WriteLine("Nincs ilyen nevű diák.");
                return;
            }
            Console.WriteLine("Jegyek: " + string.Join(", ", diak.Jegyek));
        }

        static void OsszesDiak()
        {
            foreach (Diak d in diakok)
            {
                Console.WriteLine(d.ToSor());
            }
        }

        static void Mentes()
        {
            List<string> sorok = new List<string>();
            foreach (Diak d in diakok)
            {
                sorok.Add(d.ToSor());
            }
            File.WriteAllLines("diakok.txt", sorok);
            Console.WriteLine("Adatok elmentve. Viszlát!");
        }
    }
}