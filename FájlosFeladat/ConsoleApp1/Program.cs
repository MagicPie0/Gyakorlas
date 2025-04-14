using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kiolvassuk a szöveget
            string szamokSzoveg = File.ReadAllText("szamok.txt");

            //Beletesszük egy tömbbe
            string[] szamok = szamokSzoveg.Split(',');
            
            
            //A tömb körbe járásval ki irattatom a számokat
            Console.Write("Rendezetlen számok: ");
            foreach (string s in szamok)
            {
                Console.Write(s + ',');
            }

            //Számmá konvertálom a tömböt
            int[] szam = new int[szamok.Length];

            for (int i = 0; i < szamok.Length; i++)
            {
                szam[i] = int.Parse(szamok[i]);
               
            }
            
            //Sorrenbe teszem a tömböt bubble sort-tal
            /*for (int i = 0;i < szam.Length - 1; i++)
            {
                for (int j = 0; j < szam.Length - i - 1 ; j++)
                {
                    if (szam[i] > szam[j+1])
                    {
                        int ideiglenes = szam[j];
                        szam[j] = szam[j + 1];
                        szam[j + 1] = ideiglenes;
                    }
                }
                break;
            }*/

            Array.Sort(szam);

            //Ki írjuk a rendezetett
            Console.Write("\nRendezett: ");
            for (int i = 0; i < szam.Length; i++)
            {
                Console.Write(szam[i].ToString() + ',');
            }

            //Össze adjuk a számokat
            int osszeg = 0;
            for (int i = 0; i < szam.Length; i++)
            {
                osszeg += szam[i];
            }

            Console.WriteLine("\nÖsszeg: " + osszeg);

        }
    }
}
