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
            LoeKangelasedFailist("andmed.txt");

            // Шаг 2: находим одного обычного и одного супергероя
            Kangelane tavaline = kangelased.Find(k => k.GetType() == typeof(Kangelane));
            SuperKangelane super = kangelased.Find(k => k is SuperKangelane) as SuperKangelane;

            // Шаг 3: выводим информацию
            if (tavaline != null)
            {
                Console.WriteLine("=== Tavaline kangelane ===");
                Console.WriteLine(tavaline.Kirjeldus());
                Console.WriteLine("Päästetud inimesed: " + tavaline.Paasta(1000));
                Console.WriteLine("Vormiriietus: " + tavaline.Vormiriietus());
                Console.WriteLine("Tervitus: " + tavaline.Tervitus());
                Console.WriteLine("Staatus: " + tavaline.MissiooniStaatus());
            }

            if (super != null)
            {
                Console.WriteLine("\n=== Superkangelane ===");
                Console.WriteLine(super.Kirjeldus());
                Console.WriteLine("Päästetud inimesed: " + super.Paasta(1000));
                Console.WriteLine("Vormiriietus: " + super.Vormiriietus());
                Console.WriteLine("Tervitus: " + super.Tervitus());
                Console.WriteLine("Staatus: " + super.MissiooniStaatus());
            }
        }
    }
}
