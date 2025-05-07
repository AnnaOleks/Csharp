using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Kangelane
{
    class FailiLugemine
    {
        public static List<Kangelane> LoeKangelasedFailist(string fail)
        {
            List<Kangelane> kangelased = new List<Kangelane>();

            if (!File.Exists(fail))
            {
                Console.WriteLine("Faili ei leitud: " + fail);
                return kangelased;
            }

            string[] read = File.ReadAllLines(fail);

            foreach (string rida in read)
            {
                string[] osad = rida.Split('/');

                string nimi = osad[0].Trim();
                string asukoht = osad[1].Trim();

                if (nimi.Contains("*"))
                {
                    nimi = nimi.Replace("*", "");
                    kangelased.Add(new SuperKangelane(nimi, asukoht));
                }
                else
                {
                    kangelased.Add(new Kangelane(nimi, asukoht));
                }
            }
            return kangelased;
        }
    }
}
