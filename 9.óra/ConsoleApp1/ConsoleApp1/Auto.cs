using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Auto
    {
        public Auto(int id, string marka, int ev, int ar)
        {
            this.id = id;
            this.marka = marka;
            this.ev = ev;
            this.ar = ar;
        }

        public int id { get; set; }

        public string marka { get; set; }

        public int ev { get; set; }

        public int ar { get; set; }
    }
}
