using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarKovetoConsoleAlkalmazas
{
    internal class Program
    {

        static void Main(string[] args)
        {
            LibraryService funkciok = new LibraryService();

            Console.WriteLine("Irratassuk ki a könyveket(1) ");
            Console.WriteLine("Könyv hozzáadása(2) ");
            Console.WriteLine("Kölcsönzés hozzáadása(3) ");
            Console.WriteLine("Kilépés(4): ");
            string input = Console.ReadLine();

            switch (input) 
            {
                case "1":
                    funkciok.fajlKiolvasas();
                    Main(args);
                    break;

                //case "2":
                    //funkciok.konyHozzaadasa();
            }


        }
    }
}
