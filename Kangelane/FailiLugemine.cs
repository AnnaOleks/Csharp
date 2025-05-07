using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Kangelane
{
    class FailiLugemine
    {
        // Список для хранения всех героев
        List<Kangelane> kangelased = new List<Kangelane>();

        // Метод, который читает героев из файла
        public static void LoeKangelasedFailist(string fail)
        {
            // Проверяем, существует ли файл
            if (!File.Exists(fail))
            {
                Console.WriteLine("Faili ei leitud: " + fail);
                return;
            }

            // Читаем все строки из файла
            string[] read = File.ReadAllLines(fail);

            // Обрабатываем каждую строку
            foreach (string rida in read)
            {
                string[] osad = rida.Split('/');

                string nimi = osad[0].Trim();
                string asukoht = osad[1].Trim();

                // Если имя содержит *, создаём SuperKangelane
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
        }
    }
}
