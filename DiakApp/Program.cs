using System;
using System.Collections.Generic;
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
            Console.WriteLine("Összes beolvasott diák adatai");

            string beolvasottDiakok = File.ReadAllLines(@"C:\Users\13d\source\repos\DiakApp\DiakApp\bin\Debug\eredmenyek.csv").Skip(1);
            foreach (var item in diakok)
            {
                Console.WriteLine(item);
            }
        }
    }
}
