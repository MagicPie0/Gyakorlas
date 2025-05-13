using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            metodusok metodusok = new metodusok();

            Console.WriteLine(metodusok.fajlbol_olvasas("autok.txt"));
            Console.WriteLine(metodusok.hany_eves());
            Console.WriteLine(metodusok.atlag_ar());
            Console.WriteLine(metodusok.novekvo_sorrend());
        }
    }
}
