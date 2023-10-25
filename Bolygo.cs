using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Bolygo
    {
        public string Nev { get; set; }
        public int HoldakSzama { get; set; }
        public double TerfogatArany { get; set; }

        public Bolygo(string sor)
        {
            string[] s = sor.Split(';');
            Nev = s[0];
            HoldakSzama = int.Parse(s[1]);
            TerfogatArany = double.Parse(s[2].Replace('.',','));
        }
    }

}
