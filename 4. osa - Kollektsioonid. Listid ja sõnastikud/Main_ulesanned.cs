using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Vale valik. Proovi uuesti.");
                }
            }

            //Ülesanne 3 – Õpilased ja hinnete analüüs
            List<Opilane> klass = new List<Opilane>
            {
                new Opilane("Kati", new List<int> { 5, 3, 5, 3 }),
                new Opilane("Mati", new List<int> { 4, 4, 4, 5 }),
                new Opilane("Jüri", new List<int> { 5, 5, 5, 5 })
            };

            Console.WriteLine("Õpilaste keskmised hinded:");
            foreach (var op in klass)
            {
                Console.WriteLine($"{op.Nimi}: {op.KeskmineHinne()}");
            }

            Opilane parim = klass[0];
            foreach (Opilane op in klass)
            {
                if (op.KeskmineHinne() > parim.KeskmineHinne())
                {
                    parim = op;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Kõrgem keskmine hinne: {parim.Nimi} - {parim.KeskmineHinne()}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Ülesanne 4 – Filmide kogu
            List<Film> filmid = new List<Film>
            {
                new Film("Matrix", 1999, "Ulme"),
                new Film("Inception", 2010, "Ulme"),
                new Film("Titanic", 1997, "Romantika"),
                new Film("The Godfather", 1972, "Krimi"),
                new Film("Barbie", 2023, "Komöödia")
            };
            while (true)
            {
                Console.WriteLine("Vali tegevus:");
                Console.WriteLine("1. Otsi film žanri järgi");
                Console.WriteLine("2. Leia uusim film");
                Console.WriteLine("3. Vaata grupeerivad filmid žanrite kaupa");
                Console.WriteLine("4. Välju");
                Console.WriteLine();
                Console.WriteLine("Sisesta valik (1-5):");

                int valik = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (valik == 1)
                {
                    Console.WriteLine("Sisesta žanr:");
                    string zanr = Console.ReadLine();
                    Console.WriteLine();
                    List<Film> tulemused = Funktsioonid_4osa.LeiaFilmidZanriJargi(filmid, zanr);

                    if (tulemused.Count == 0)
                    {
                        Console.WriteLine("Selle žanri filme ei leitud.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Leitud filmid:");
                        foreach (Film f in tulemused)
                        {
                            Console.WriteLine("  - " + f.Info());
                        }
                        Console.WriteLine();
                    }
                }
                else if (valik == 2)
                {
                    Film uusim = Funktsioonid_4osa.LeiaUusimFilm(filmid);
                    Console.WriteLine("Uusim film: " + uusim.Info());
                    Console.WriteLine();
                }
                else if (valik == 3)
                {
                    Console.WriteLine("Filmid žanrite kaupa:");
                    Dictionary<string, List<Film>> grupeeritud = Funktsioonid_4osa.GrupeeriZanriteJargi(filmid);
                    foreach (string zanr in grupeeritud.Keys)
                    {
                        Console.WriteLine("\nŽanr: " + zanr);
                        foreach (Film f in grupeeritud[zanr])
                        {
                            Console.WriteLine("  - " + f.Info());
                        }
                    }
                    Console.WriteLine();
                }
                else if (valik == 4)
                {
                    Console.WriteLine("Head aega!");
                    break;
                }
                else
                {
                    Console.WriteLine("Vale valik. Proovi uuesti.");
                    Console.WriteLine();
                }
            }
        }
    }
}
