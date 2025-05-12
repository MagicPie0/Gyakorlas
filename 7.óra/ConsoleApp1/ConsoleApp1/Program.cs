using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("szavak.txt")) 
            {
                File.WriteAllText("szavak.txt", "apple;alma");           
            }

            Console.WriteLine("Fájlba írás(1)");
            Console.WriteLine("Angol szóra keresés(2): ");

            string input = Console.ReadLine();

            switch (input) 
            {
                case "1":
                    Console.WriteLine(fajlba_iras()); 
                    break;
                case "2":
                    Console.WriteLine(kereses());
                    break;
                default:
                    return;           
            }
           
        }

        static string fajlba_iras()
        {
            Console.WriteLine("Milyen angol szót szeretnél elmenteni: ");
            string angol = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Mi a magyar párja: ");
            string magyar = Console.ReadLine().Trim().ToLower();

            File.AppendAllText("szavak.txt", "\n" + angol + ";" + magyar );

            return "Le van mentve!";
        }

        static string kereses()
        {
            Console.WriteLine("Milyen angol szót szeretnél keresni: ");

            string angolSzo = Console.ReadLine().Trim().ToLower();

            var sorok = File.ReadAllLines("szavak.txt");

            foreach (var s in sorok) 
            {
                var sor = s.Split(';');
                if (angolSzo == sor[0].ToLower())
                {
                    return $"Angol: {sor[0]} -> Magyar: {sor[1]}";
                }
            }
            return "";
        }
    }
}
