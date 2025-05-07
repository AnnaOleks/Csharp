using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Kangelane
{
    class Kangelane
    {
        // Приватные (скрытые) поля — имя и город героя
        private string nimi;    // имя героя
        private string asukoht; // город, где герой работает

        // Свойство для получения и изменения имени и города
        public string Nimi { get; set; }
        public string Asukoht { get; set; }

        // Конструктор — вызывается при создании объекта класса
        public Kangelane(string nimi, string asukoht)
        {
            Nimi = nimi;
            Asukoht = asukoht;
        }

        // Метод Paasta — вычисляет, сколько человек герой может спасти
        public int Paasta(int ohus)
        {
            // герой спасает 95% из тех, кто в беде
            return (int)(ohus * 0.95); // результат округляется до целого
        }

        // Метод Vormiriietus — описание костюма героя
        public string Vormiriietus()
        {
            return "Tavaline kangelase kostüüm."; // обычный костюм без наворотов
        }

        // Метод Tervitus — возвращает приветствие героя
        public string Tervitus()
        {
            return $"Tere, mina olen {Nimi}!"; // приветствие с именем
        }

        // Метод MissiooniStaatus — говорит, свободен ли герой
        public string MissiooniStaatus()
        {
            return "Olen saadaval!"; // по умолчанию, герой не занят
        }

        // Метод Kirjeldus — возвращает строку с описанием героя
        public string Kirjeldus()
        {
            return $"Kangelane: {Nimi}\nAsukoht: {Asukoht}";
        }
    }
}
