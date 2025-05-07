using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Kangelane
{
    internal class Main_Kangelane
    {
        static void Main(string[] args)
        {
            // Шаг 1: читаем героев из файла
            List<Kangelane> kangelased = FailiLugemine.LoeKangelasedFailist(@"C:\\Users\\annao\\source\\repos\\Csharp\\Kangelane\\andmed.txt");

            if (kangelased.Count == 0)
            {
                Console.WriteLine("Kangelasi ei leitud failist.");
                return;
            }

            // Выводим информацию о каждом герое
            foreach (Kangelane k in kangelased)
            {
                if (k is SuperKangelane super)
                {
                    Console.WriteLine("=== Superkangelane ===");
                    Console.WriteLine(super.Kirjeldus());
                    Console.WriteLine("Päästetud inimesed: " + super.Paasta(1000));
                    Console.WriteLine("Vormiriietus: " + super.Vormiriietus());
                    Console.WriteLine("Tervitus: " + super.Tervitus());
                    Console.WriteLine("Staatus: " + super.MissiooniStaatus());
                }
                else
                {
                    Console.WriteLine("=== Tavaline kangelane ===");
                    Console.WriteLine(k.Kirjeldus());
                    Console.WriteLine("Päästetud inimesed: " + k.Paasta(1000));
                    Console.WriteLine("Vormiriietus: " + k.Vormiriietus());
                    Console.WriteLine("Tervitus: " + k.Tervitus());
                    Console.WriteLine("Staatus: " + k.MissiooniStaatus());
                }

                Console.WriteLine(); // Пустая строка между героями
            }

            Console.WriteLine("Kõik kangelased on edukalt näidatud! 🦸‍♂️");
        }
    }
}
