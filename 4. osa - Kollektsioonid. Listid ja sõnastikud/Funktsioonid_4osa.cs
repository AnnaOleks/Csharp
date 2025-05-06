using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp._4._osa___Kollektsioonid._Listid_ja_sõnastikud
{
    internal class Funktsioonid_4osa
    {
        public static void Pealinnaotsing(Dictionary<string, string> Maakonnad)
        {
            Console.WriteLine("Sisesta maakonna nimi:");
            string maakond = Console.ReadLine();
            if (Maakonnad.ContainsKey(maakond))
            {
                Console.WriteLine($"Vastus: {Maakonnad[maakond]}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Maakonda ei leitud.");
                Console.WriteLine();
            }
        }
        public static void Maakonnaotsing(Dictionary<string, string> Maakonnad)
        {
            Console.WriteLine("Sisesta pealinna nimi:");
            string pealinn = Console.ReadLine();
            if (Maakonnad.ContainsValue(pealinn))
            {
                foreach(var paar in Maakonnad)
                {
                    if (paar.Value == pealinn)
                    {
                        Console.WriteLine($"Vastus: {paar.Key}");
                        Console.WriteLine();
                        break;
                    }
                    if (paar.Value != pealinn)
                    {
                        Console.WriteLine("Pealinna ei leitud.");
                        Console.WriteLine();
                        break;
                    }
                }
            }
            
        }
        public static void LisaMaakondPealinn(Dictionary<string, string> Maakonnad)
        {
            Console.WriteLine("Sisesta maakonna nimi:");
            string maakond = Console.ReadLine();
            if (!Maakonnad.ContainsKey(maakond))
            {
                Console.WriteLine("Maakond juba olemas.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Sisesta pealinna nimi:");
                string pealinn = Console.ReadLine();
                Maakonnad.Add(maakond, pealinn);
                Console.WriteLine($"Lisatud: {maakond} - {pealinn}");
                Console.WriteLine();
            }
        }
        public static void Mang(Dictionary<string, string> Maakonnad)
        {
            Random rnd = new Random();
            int oigeVastus = 0;
            int valeVastus = 0;
            int loendur = 0;

            foreach (var paar in Maakonnad)
            {
                if (oigeVastus == 5 || valeVastus == 5)
                {
                    break;
                }
                bool pealinnakusimus = rnd.Next(2) == 0;
                if (pealinnakusimus)
                {
                    Console.WriteLine($"Mis on {paar.Key} pealinn?");
                    string vastus = Console.ReadLine();
                    if (vastus.ToLower() == paar.Value.ToLower())
                    {
                        Console.WriteLine("Õige vastus!");
                        oigeVastus++;
                    }
                    else
                    {
                        Console.WriteLine($"Vale vastus! Õige vastus on {paar.Value}.");
                        valeVastus++;
                    }
                }
                else
                {
                    Console.WriteLine($"Mis maakonna pealinn on {paar.Value}?");
                    string vastus = Console.ReadLine();
                    if (vastus.ToLower() == paar.Key.ToLower())
                    {
                        Console.WriteLine("Õige vastus!");
                        oigeVastus++;
                    }
                    else
                    {
                        Console.WriteLine($"Vale vastus! Õige vastus on {paar.Key}.");
                        valeVastus++;
                    }
                }
            }
            int kokku = oigeVastus + valeVastus;
            double protsent = (double)oigeVastus / kokku * 100;
            Console.WriteLine($"Mängu lõpp.\nÕigeid vastuseid: {oigeVastus}\nVale vastuseid: {valeVastus}\nTulemus: {protsent}");
        }
        public static List<Film> LeiaFilmidZanriJargi(List<Film> filmid, string zanr)
        {
            List<Film> tulemused = new List<Film>();
            for (int i = 0; i < filmid.Count; i++)
            {
                if (filmid[i].Zanr.ToLower() == zanr.ToLower())
                {
                    tulemused.Add(filmid[i]);
                }
            }
            return tulemused;
        }
        public static Film LeiaUusimFilm(List<Film> filmid)
        {
            Film uusim = filmid[0];
            for (int i = 1; i < filmid.Count; i++)
            {
                if (filmid[i].Aasta > uusim.Aasta)
                {
                    uusim = filmid[i];
                }
            }
            return uusim;
        }
        public static Dictionary<string, List<Film>> GrupeeriZanriteJargi(List<Film> filmid)
        {
            Dictionary<string, List<Film>> grupeeritud = new Dictionary<string, List<Film>>();

            for (int i = 0; i < filmid.Count; i++)
            {
                string zanr = filmid[i].Zanr;

                if (!grupeeritud.ContainsKey(zanr))
                {
                    grupeeritud[zanr] = new List<Film>();
                }

                grupeeritud[zanr].Add(filmid[i]);
            }

            return grupeeritud;
        }
    }
}


