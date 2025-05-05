using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp._3._osa___Failitöötlus
{
    internal class Main_ulesanned
    {
        public static void Main(string[] args)
        {
            // 1. Loo failinimi Kuud.txt
            string path = Funktsioonid_3osa.FailiPath(@"C:\Users\annao\source\repos\Csharp\3. osa - Failitöötlus\Kuud.txt");

            // 2. Kirjuta programmi abil 3 kuud faili
            Funktsioonid_3osa.FailiKirjutamine(path);

            // 3. Loe kuud List<string> sisse
            List<string> kuude_list = Funktsioonid_3osa.FailiLugemine(path);

            // 4. Eemalda „Juuni“, muuda esimene element
            Funktsioonid_3osa.EemaldamineMuutmine(path, kuude_list);

            // 5. Kuvada kõik kuud
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }

            // 6. Luba kasutajal otsida kuud nime järgi
            Console.WriteLine("Sisesta kuu nimi, mida otsida:");
            string otsitav_kuu = Console.ReadLine();
            string vastus = Funktsioonid_3osa.Otsing(otsitav_kuu, kuude_list);
            Console.WriteLine(vastus);

            // 7. Salvesta muudatused faili tagasi
            Funktsioonid_3osa.Salvestamine(path, kuude_list);
        }
    }
}
