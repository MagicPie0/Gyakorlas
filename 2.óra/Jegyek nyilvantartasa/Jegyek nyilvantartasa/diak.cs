using System.Collections.Generic;

namespace diakokjegyeikezelo
{
    internal partial class Program
    {
        public class Diak
        {
            public string Nev;
            public List<int> Jegyek;

            public Diak(string nev)
            {
                Nev = nev;
                Jegyek = new List<int>();
            }
            public string ToSor()
            {
                return Nev + ";" + string.Join(",", Jegyek);
            }
            public static Diak FromSor(string sor)
            {
                string[] reszek = sor.Split(';');
                Diak diak = new Diak(reszek[0]);
                if (reszek.Length > 1 && reszek[1] != "")
                {
                    string[] jegyekSzoveg = reszek[1].Split(',');
                    foreach (string j in jegyekSzoveg)
                    {
                        diak.Jegyek.Add(int.Parse(j));
                    }
                }
                return diak;
            }
        }
    }
}