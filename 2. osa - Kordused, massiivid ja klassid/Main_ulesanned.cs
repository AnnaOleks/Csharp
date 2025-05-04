using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp._2._osa___Kordused__massiivid_ja_klassid
{
    internal class Main_ulesanned
    {
        public static void Main(string[] args)
        {
            //1. Juhuslike arvude ruudud
            (int[] arvud, int[] ruudud) = ArvuTöötlus.GenereeriRuudud(-100, 100);
            for (int i = 0; i < ruudud.Length; i++)
            {
                Console.WriteLine($"{arvud[i]} -> {ruudud[i]}");
            }
            Console.WriteLine();

            //2. Viie arvu analüüs
            double[] arvud2 = Funktsioonid_2osa.Tekstist_arvud();
            var tulemus = Funktsioonid_2osa.AnalüüsiArve(arvud2);
            Console.WriteLine("Arvude analüüs:");
            Console.WriteLine($"Sisestatud arvud: {string.Join(",", arvud2)}");
            Console.WriteLine($"Arvude summa: {tulemus.Item1}");
            Console.WriteLine($"Arvude korrutis: {tulemus.Item2}");
            Console.WriteLine($"Arvude keskmine: {tulemus.Item3}");
            Console.WriteLine();

            //3. Nimed ja vanused

        }
    }
}
