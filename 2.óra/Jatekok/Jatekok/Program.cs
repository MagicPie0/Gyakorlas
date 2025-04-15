using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Jatekok
{
    public class Jatek
    {
        public Jatek(string cim, string kategoria, int ev)
        {
            this.cim = cim;
            this.kategoria = kategoria;
            this.ev = ev;
        }

        public string cim {  get; set; }

        public string kategoria { get; set; }

        public int ev {  get; set; }
    }

    internal class Program
    {
        static List<Jatek> JatekLista = new List<Jatek>();

        static void ujJatek()
        {
            Console.WriteLine("Írd be a játék címét: ");
            string cim = Console.ReadLine();
            if (cim == "")
            {
                Console.WriteLine("Nem adtál meg címet!");
                hibaKezeles();
            }

            Console.WriteLine("Írd be a játék kategóriáját: ");
            string kategoria = Console.ReadLine();
            if (kategoria == "")
            {
                Console.WriteLine("Nem adtál meg kategóriát!");
                hibaKezeles();
            }

            Console.WriteLine("Írd be a megjelenési dátumod: ");
            int ev = int.Parse(Console.ReadLine());
            

            JatekLista.Insert(0, new Jatek(cim, kategoria, ev));
            hibaKezeles();
            
        }

        static void hibaKezeles()
        {
            Console.WriteLine("Szeretnéd folytatni(i/n): ");
            string bevitel = Console.ReadLine();
            if (bevitel == "i")
            {
                Main();
            }
            else
            {
                return;
            }
        }

        static void mentes()
        {
            for (int i = 0; i < JatekLista.Count; i++)
            {
                File.AppendAllText("jatekok.txt", JatekLista[i].cim + ';' + JatekLista[i].kategoria + ';' + JatekLista[i].ev);
            }
            return;
        }


            static void Main()
            {
            Console.WriteLine("Új játék felvétele(1) ");
            Console.WriteLine("A játék listázást(2) ");
            Console.WriteLine("Kilépés(3): ");
            
            //Megnézzük hogy létezik a fájl, és ha nincs akkor csinálunk egyet 
            if (!File.Exists("jatekok.txt"))
            {
                File.Create("jatekok.txt");
            }


            string bevitel = Console.ReadLine();

            switch (bevitel)
            {
                case "1":
                    ujJatek();
                    break;
                case "2":
                    Console.WriteLine(File.ReadAllText("jatekok.txt"));
                    break;
                case "3":
                    mentes();
                    break;
                default:
                    Console.WriteLine("Nem írtál be semmit vagy nincs ilyen menüpont!");
                    hibaKezeles();

                    break;

            }
        }
    }
}
