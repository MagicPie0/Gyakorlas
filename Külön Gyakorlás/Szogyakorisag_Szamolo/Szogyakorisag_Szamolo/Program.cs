using System;
using System.Collections.Generic; // Listákhoz és más gyűjteményekhez
using System.Linq; // LINQ varázslathoz, pl. GroupBy, Select, stb.
using System.Text; 
using System.Threading.Tasks; 
using System.IO; // Fájlműveletekhez, pl. File.ReadAllLines

namespace Szogyakorisag_Szamolo // A projekt névtere (namespace) – logikailag összefogja a kódot
{
    internal class Program // A program fő osztálya
    {
        static void Main(string[] args) // Belépési pont, innen indul a program
        {
            Console.WriteLine("Szógyakoriság elemzés elindult"); // Kiírja, hogy a program elindult

            // Ha nincs "szoveg.txt", akkor létrehozzuk egy alap szöveggel
            if (!File.Exists("szoveg.txt"))
            {
                File.WriteAllText("szoveg.txt", "Hello világ! Ez egy próba. A próba célja a teszt. Teszt próba.");
            }

            // Beolvassuk a szövegfájlt soronként egy string tömbbe
            string[] sorok = File.ReadAllLines("szoveg.txt");

            // Meghívjuk a rekurzív függvényt, ami kinyeri az összes szót a sorokból
            List<string> szavak = szavakKigyujtese(sorok);

            // LINQ: csoportosítjuk a szavakat, megszámoljuk hányszor fordulnak elő
            // Aztán csökkenő sorrendbe rakjuk, és kiválasztjuk a 3 leggyakoribb szót
            var stat = szavak
                .GroupBy(szo => szo)
                .Select(g => new { Szo = g.Key, Darab = g.Count() })
                .OrderByDescending(x => x.Darab)
                .Take(3);

            Console.WriteLine("\n Top 3 leggyakoribb szó: "); // Kiírás kezdete

            // Végigmegyünk a három leggyakoribb szón, és kiírjuk őket
            foreach (var item in stat)
            {
                Console.WriteLine($"{item.Szo} - {item.Darab} alkalommal");
            }

            Console.WriteLine("\n Program vége."); // Vége üzenet
            Console.ReadLine(); // Várunk egy entert, hogy ne záródjon be a konzol rögtön
        }

        // Ez egy rekurzív függvény, ami soronként dolgozza fel a szöveget
        // Minden sort szavakra bont, és hozzáadja egy listához
        static List<string> szavakKigyujtese(string[] sorok, int index = 0)
        {
            // Alap eset: ha elértük a sorok végét, visszatérünk egy üres listával
            if (index >= sorok.Length)
            {
                return new List<string>();
            }

            // Az aktuális sort kisbetűssé tesszük, és feldaraboljuk szóközöknél, írásjeleknél
            var szavakEbben = sorok[index]
                .ToLower()
                .Split(new[] { ' ', '.', ',', '!', '?', ';', ':', '-', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            // Meghívjuk magát újra a következő sorra
            var tovabbiSzavak = szavakKigyujtese(sorok, index + 1);

            // Összefűzzük a mostani sort szavaival a következő sorok szavaival
            szavakEbben.AddRange(tovabbiSzavak);

            return szavakEbben; // Visszaadjuk az összes szót
        }
    }
}
