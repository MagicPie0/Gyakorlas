using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Kedvenc_Gyumolcs
{
    public class Gyumolcs
    {
        public Gyumolcs(string nev, string szin)
        {
            this.nev = nev;
            this.szin = szin;
        }

        public string nev {  get; set; }

        public string szin { get; set; }
    }

    internal class Program
    {
        static List<Gyumolcs> gyumolcs = new List<Gyumolcs>(); 

        static void ujGyumolcs()
        {
            Console.WriteLine("Írd be a nevét: ");
            string nev = Console.ReadLine();
            Console.WriteLine("Írd be a színét: ");
            string szin = Console.ReadLine();

            gyumolcs.Insert(0, new Gyumolcs(nev, szin));
        }

        static void gyumolcsokListazasa()
        {
            if (gyumolcs.Count > 0) 
            {
                Console.WriteLine(File.ReadAllText("gyumolcsok.txt") + '\n' + "Még nem lementett gyümölcs: " + gyumolcs[0].nev + ';' + gyumolcs[0].szin);
            }
            else
            {
                Console.WriteLine(File.ReadAllText("gyumolcsok.txt"));
            }
        }

        static void mentes()
        {
            File.AppendAllText("gyumolcsok.txt", '\n' + gyumolcs[0].nev + ';' + gyumolcs[0].szin);
        }

        static void Main()
        {
            if (!File.Exists("gyumolcsok.txt"))
            {
                File.WriteAllText("gyumolcsok.txt", "Alma;piros");
            }

            Console.WriteLine("Új gyümölcs hozzá adása(1)");
            Console.WriteLine("Gyümölcsök listázása(2)");
            Console.WriteLine("Kilépés és mentés(3): ");
            string cmd = Console.ReadLine();

            switch (cmd) 
            {
                case "1":
                    ujGyumolcs();
                    Main();
                    break;
                case "2":
                    gyumolcsokListazasa();
                    Main();
                    break;
                case "3":
                    mentes();
                    return;
                default:
                    return;
            }
        }
    }
}
