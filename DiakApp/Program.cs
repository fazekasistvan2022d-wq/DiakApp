using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiakApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Diak> diakok = new List<Diak>();
            int hibasSorokSzama = 0;
            foreach (var sor in File.ReadAllLines(@"C:\Users\13d\source\repos\DiakApp\DiakApp\bin\Debug\eredmenyek.csv").Skip(1))
            {
                string[] adatok = sor.Split(';');
                if(adatok.Length != 3)
                {
                    hibasSorokSzama++;
                    continue;
                }
                else
                {
                    string nev = adatok[0];
                    string osztaly = adatok[1];
                    if (string.IsNullOrWhiteSpace(nev) || string.IsNullOrWhiteSpace(osztaly))
                    {
                        hibasSorokSzama++;
                        continue;
                    }           
                    if (!int.TryParse(adatok[2], out int pontszam))
                    {
                        hibasSorokSzama++;
                        continue;
                    }
                    Diak diak = new Diak(nev,osztaly,pontszam);
                    diakok.Add(diak);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Sikeresen beolvasott diákok száma: {diakok.Count()} || Hibás beolvasások: {hibasSorokSzama}");
            Console.WriteLine();
            Console.WriteLine("Összes beolvasott diák adatai:");
            foreach (var item in diakok)
            {
                Console.WriteLine(item);
            }
        }
    }
}
