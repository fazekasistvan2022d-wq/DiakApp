using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiakApp
{
    internal class Diak
    {
        public string Nev { get; set; }
        public string Osztaly { get; set; }
        private int pontszam;
        public int Pontszan
        {
            get { return pontszam; }

            set
            {
                if (value > 100) pontszam = 100;
                if (value < 0) pontszam = 0;
            }
        }

    }
}
