using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp._4._osa___Kollektsioonid._Listid_ja_sõnastikud
{
    internal class Main_ulesanned
    {
        public static void Main(string[] args)
        {
            //Ülesanne 2 – Maakonnad ja pealinnad (sõnastik ja test)
            Dictionary<string, string> Maakonnad = new Dictionary<string, string>();
            Maakonnad.Add("Harjumaa", "Tallinn");
            Maakonnad.Add("Tartumaa", "Tartu");
            Maakonnad.Add("Pärnumaa", "Pärnu");
            Maakonnad.Add("Saaremaa", "Kuressaare");
            Maakonnad.Add("Läänemere maakond", "Kihnu");
            Maakonnad.Add("Jõgevamaa", "Jõgeva");
            Maakonnad.Add("Valgamaa", "Valga");
            Maakonnad.Add("Võrumaa", "Võru");
            Maakonnad.Add("Põlvamaa", "Põlva");
            Maakonnad.Add("Raplamaa", "Rapla");
            Maakonnad.Add("Järvamaa", "Paide");
            Maakonnad.Add("Viljandimaa", "Viljandi");

            Console.WriteLine("Tere tulemast maakondade ja pealinnade mängu!");
            while (true)
            {
                Console.WriteLine("Vali tegevus:");
                Console.WriteLine("1. Otsi maakonda pealinna järgi");
                Console.WriteLine("2. Otsi pealinna maakonna järgi");
                Console.WriteLine("3. Lisa uus maakond ja pealinn");
                Console.WriteLine("4. Soovin mängida");
                Console.WriteLine("5. Välju");
                Console.WriteLine();
                Console.WriteLine("Sisesta valik (1-5):");
                
                int valik = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (valik == 1)
                {
                    Funktsioonid_4osa.Pealinnaotsing(Maakonnad);
                }
                else if (valik == 2)
                {
                    Funktsioonid_4osa.Maakonnaotsing(Maakonnad);
                }
                else if (valik == 3)
                {
                    Funktsioonid_4osa.LisaMaakondPealinn(Maakonnad);
                }
                else if (valik == 4)
                {
                    Console.WriteLine("Mäng algab!");
                    Funktsioonid_4osa.Mang(Maakonnad);
                    Console.WriteLine();
                }
                else if (valik == 5)
                {
                    Console.WriteLine("Head aega!");
                    break;
                }
                else
                {
                    Console.WriteLine("Vale valik. Proovi uuesti.");
                }
            }
        }
    }
}
