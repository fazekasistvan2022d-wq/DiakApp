using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiakApp
{
    public class Diak
    {
        public string Nev { get; set; }
        public string Osztaly { get; set; }
        private int pontszam;
        public int Pontszam
        {
            get { return pontszam; }

            set
            {
                if (value >= 100)
                {
                    pontszam = 100;
                }
                else
                {
                    if (value <= 0)
                    {
                        pontszam = 0;
                    }
                    else
                    {
                        pontszam = value;
                    }
                }
            }
        }
        public Diak(string nev, string osztaly, int pontszam)
        {
            Nev = nev;
            Osztaly = osztaly;
            Pontszam = pontszam;
        }

        public override string ToString()
        {
            return $"Név: {Nev} || Osztály: {Osztaly} || Pontszám: {Pontszam} ";
        }

    }
}
