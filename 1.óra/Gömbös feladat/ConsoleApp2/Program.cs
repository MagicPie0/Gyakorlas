using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //Kör számítása
    public class CircleCalculator
    {
        //Kör kerülete
        public double GetCircumference(double radius)
        {
            double kerulet = 2 * radius * Math.PI;
            return kerulet;
        }

        //Kör területe
        public double GetArea(double radius)
        {
            double terulet = Math.Pow(radius, 2) * Math.PI;
            return terulet;
        }
    }

    //Gömb számítása 
    public class SphereCalculator
    {
        //A gömb térfogata
        public double GetVolume(double radius)
        {
            double terfogat = (4 + Math.Pow(radius, 3) * Math.PI) / 3;
            return terfogat;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írd be a számítandó kör vagy gömb sugarát: ");
            //Be kérjük a rádiuszt a felhasználótól
            double radius = Console.Read();

            CircleCalculator kor = new CircleCalculator();

            Console.WriteLine("A kör kerülete: " + kor.GetCircumference(radius));
            Console.WriteLine("A kör területe: " + kor.GetArea(radius));

            SphereCalculator gomb = new SphereCalculator();
            Console.WriteLine("A gömb térfogata: " + gomb.GetVolume(radius));
        }
    }
}
