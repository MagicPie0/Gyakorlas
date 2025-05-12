using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodusok met = new Metodusok();
            Console.WriteLine(met.atlag_szamitas()); 
        }
    }
}
