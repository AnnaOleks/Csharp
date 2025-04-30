using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Funktsioonid_2osa
    {

        public static List<string> Sonad()
        {
            List<string> sonad = new List<string>();
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Nimi");
                sonad.Add(Console.ReadLine());
            }
            return sonad;
        }
        public static Isik[] Isikud(int k, string[] nimed, string[] aadressid)
        {
            Isik[] isikud = new Isik[k];

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(i);
                //isikud[i] = new Isik();
                isikud[i] = new Isik
                {
                    Nimi = nimed[i],
                    Vanus = i + 10,
                    Isikukood = "12345678901" + i,
                    Aadress = aadressid[i]
                };
            }
            return isikud;
        }
        public static List<Isik> Isikud2(int p, string[] nimed, string[] aadressid)
        {
            List<Isik> isikud2 = new List<Isik>();
            for (int j = p-1; j > -1; j--)
            { 
                Console.WriteLine(j);
                Isik isik = new Isik
                {
                    Nimi = nimed[j],
                    Vanus = 50,
                    Isikukood = "11223344556",
                    Aadress = aadressid[j]
                };
            isikud2.Add(isik);
            }
            return isikud2;
        }
    }
}
