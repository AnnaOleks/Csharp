using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp._2._osa___Kordused__massiivid_ja_klassid
{
    internal class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public Inimene(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
        public void Statistika(List<Inimene> inimesed)
        {
            int summa = inimesed.Sum(p => p.Vanus);
            double keskmine = inimesed.Average(p => p.Vanus);
            Inimene vanim = inimesed.OrderByDescending(p => p.Vanus).First();
            Inimene noorim = inimesed.OrderBy(p => p.Vanus).First();

            Console.WriteLine($"\nStatistika:");
            Console.WriteLine($"Vanuste summa: {summa}");
            Console.WriteLine($"Keskmine vanus: {keskmine:F1}");
            Console.WriteLine($"Vanim inimene: {vanim.Nimi}, {vanim.Vanus} aastat");
            Console.WriteLine($"Noorim inimene: {noorim.Nimi}, {noorim.Vanus} aastat");
        }
    }
}
