using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Kangelane
{
    class SuperKangelane : Kangelane
    {
        // Добавочное поле — ловкость
        private double osavus;

        // Конструктор SuperKangelane вызывает базовый конструктор и добавляет осавус
        public SuperKangelane(string nimi, string asukoht) : base(nimi, asukoht) // вызываем конструктор родителя Kangelane
        {
            // создаём генератор случайных чисел
            Random rnd = new Random();

            // создаём значение ловкости от 1.0 до 5.0
            osavus = 1.0 + rnd.NextDouble() * 4.0;
        }

        // Свойство Osavus — даёт доступ к значению ловкости
        public double Osavus
        {
            get { return osavus; }
        }

        // Метод Paasta в SuperKangelane не переопределяет, а скрывает метод из базового класса
        // Добавляется +osavus к 95%
        public new int Paasta(int ohus)
        {
            double protsent = 95 + osavus; 
            return (int)(ohus * (protsent / 100)); // вычисляем количество спасённых
        }

        // Крутой костюм
        public new string Vormiriietus()
        {
            return "Superkostüüm koos laseritega!";
        }

        // Более эпичное приветствие
        public new string Tervitus()
        {
            return $"BOOM! Mina olen superkangelane - {Nimi}!";
        }

        // Часто на задании
        public new string MissiooniStaatus()
        {
            return "Olen missioonil!";
        }

        // Метод описания героя с добавлением ловкости
        public new string Kirjeldus()
        {
            // base.Kirjeldus() возвращает описание обычного героя
            // мы добавляем туда ещё информацию об осавусе
            return base.Kirjeldus() + $", Osavus: {osavus:F2}";
        }
    }
}
