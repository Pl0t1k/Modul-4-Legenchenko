﻿using System;
using System.Collections.Generic;

namespace Zadanie_4_Legenchenko
{
    internal interface IBook // Определение интерфейса для книги
    {
        bool Доступность(); // Метод для проверки доступности книги
        void ВыдатьКнигу(); // Метод для выдачи книги
    }

    internal class Роман : IBook // Класс для романа, реализующий интерфейс IBook
    {
        private static bool _выдан = false; // Статическая переменная, указывающая, выдана ли уже книга
        private string _название; // Переменная для хранения названия книги

        public Роман(string название) // Конструктор класса, принимающий название книги
        {
            _название = название;
        }

        public bool Доступность() // Реализация метода Доступность интерфейса
        {
            return !_выдан; // Возвращает true, если книга еще не выдана
        }

        public void ВыдатьКнигу() // Реализация метода ВыдатьКнигу интерфейса
        {
            if (!_выдан) // Проверка, не выдана ли уже книга
            {
                _выдан = true; // Устанавливает флаг, что книга выдана
                Console.WriteLine($"Роман '{_название}' выдан."); // Выводит сообщение о выдаче книги
            }
            else
            {
                Console.WriteLine($"Роман '{_название}' недоступен."); // Выводит сообщение, что книга недоступна
            }
        }
    }

    internal class Учебник : IBook // Класс для учебника, реализующий интерфейс IBook
    {
        private static bool _выдан = false; // Статическая переменная, указывающая, выдан ли уже учебник
        private string _название; // Переменная для хранения названия учебника

        public Учебник(string название) // Конструктор класса, принимающий название учебника
        {
            _название = название;
        }

        public bool Доступность() // Реализация метода Доступность интерфейса
        {
            return !_выдан; // Возвращает true, если учебник еще не выдан
        }

        public void ВыдатьКнигу() // Реализация метода ВыдатьКнигу интерфейса
        {
            if (!_выдан) // Проверка, не выдан ли уже учебник
            {
                _выдан = true; // Устанавливает флаг, что учебник выдан
                Console.WriteLine($"Учебник '{_название}' выдан."); // Выводит сообщение о выдаче учебника
            }
            else
            {
                Console.WriteLine($"Учебник '{_название}' недоступен."); // Выводит сообщение, что учебник недоступен
            }
        }
    }

    internal class Program // Класс программы
    {
        static void Main(string[] args) // Метод Main, точка входа в программу
        {
            var книги = new List<IBook> // Создание списка книг, реализующих интерфейс IBook
            {
                new Роман("Война и мир"), // Добавление объекта Романа в список книг
                new Роман("Преступление и наказание"), // Добавление объекта Романа в список книг
                new Роман("Мастер и Маргарита"), // Добавление объекта Романа в список книг
                new Учебник("Математика"), // Добавление объекта Учебника в список книг
                new Учебник("Физика"), // Добавление объекта Учебника в список книг
                new Учебник("История") // Добавление объекта Учебника в список книг
            };

            int выбор;
            do // Цикл do-while для предоставления выбора книги
            {
                Console.WriteLine("Выберите книгу по номеру:"); // Выводит приглашение к выбору книги
                for (var i = 0; i < книги.Count; i++) // Цикл для вывода списка книг
                {
                    Console.WriteLine($"{i + 1}. {книги[i].GetType().Name}"); // Выводит порядковый номер и тип книги
                }

                выбор = int.Parse(Console.ReadLine()); // Чтение выбора пользователя
                if (выбор > 0 && выбор <= книги.Count) // Проверка корректности выбора
                {
                    ВыдатьКнигуПоиск(книги[выбор - 1]); // Вызов метода для выдачи выбранной книги
                }
                else
                {
                    Console.WriteLine("Неверный выбор."); // Вывод сообщения об ошибке выбора
                }
            } while (выбор != 0); // Повторять, пока выбор не равен 0
        }

        static void ВыдатьКнигуПоиск(IBook книга) // Метод для выдачи книги из списка
        {
            if (книга.Доступность()) // Проверка доступности книги
            {
                книга.ВыдатьКнигу(); // Выдача книги
            }
            else
            {
                Console.WriteLine("Книга недоступна."); // Вывод сообщения, что книга недоступна
            }
        }
    }
}