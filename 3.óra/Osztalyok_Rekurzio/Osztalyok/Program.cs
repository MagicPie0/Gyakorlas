using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    public class Teszt1
    {
        public string szin;
        public int meret;

        public virtual void Metodus1()
        {
            Console.WriteLine("Hello");
        }

        public int Metodus2() 
        {
            meret = 5;
            return meret;
        }
    } 

    public class Teszt2 : Teszt1
    {
        public void teszt2Metodus1()
        {
            szin = "szex";
            Metodus1();
        }
    }

    public class Teszt3 : Teszt1
    {
        public override void Metodus1()
        {
            Console.WriteLine("Szia");
        }
    }


    internal class Program
    {
        static void Main()
        {
            Teszt1 teszt1 = new Teszt1();

            Teszt1 teszt3 = new Teszt3();

            teszt1.Metodus1();
            teszt3.Metodus1();

            Main();
        }

    }
}
