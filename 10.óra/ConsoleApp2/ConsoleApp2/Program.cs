using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            metodusok metodusok = new metodusok();



            //Minden ami a fájlban van
            var lista = metodusok.fajlbol_olvasas();
            Console.WriteLine("Minden ami a fájlban van: ");
            for (int i = 0; i < lista.Count; i++) 
            {
                Console.Write(lista[i].id.ToString() + ", ");
                Console.Write(lista[i].marka + ", ");
                Console.Write(lista[i].szin + ", ");
                Console.Write(lista[i].evjarat.Year + ", ");
                Console.Write(lista[i].ar );
                Console.WriteLine("");
            }
            //--

            //--
            Console.WriteLine("Átlag: " + metodusok.atlag_szamitas());
            //--


            //Minden ami a fájlban van csökkenő sorrendbe
            var novekvo = metodusok.novekvo_sorrend();
            Console.WriteLine("Minden ami a fájlban van csökkenő sorrendbe: ");
            for (int i = 0; i < novekvo.Count; i++)
            {
                Console.Write(novekvo[i].id.ToString() + ", ");
                Console.Write(novekvo[i].marka + ", ");
                Console.Write(novekvo[i].szin + ", ");
                Console.Write(novekvo[i].evjarat.Year + ", ");
                Console.Write(novekvo[i].ar);
                Console.WriteLine("");
            }
            //--

            Console.ReadKey();
        }
    }
}
