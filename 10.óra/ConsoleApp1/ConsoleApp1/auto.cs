using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class auto
    {
        public auto(int id, string marka, string szin, DateTime evjarat, int ar)
        {
            this.id = id;
            this.marka = marka;
            this.szin = szin;
            this.evjarat = evjarat;
            this.ar = ar;
        }

        public int id { get; set; }
        public string marka { get; set; }
        public string szin { get; set; }
        public DateTime evjarat { get; set; }
        public int ar { get; set; }


    }
}
