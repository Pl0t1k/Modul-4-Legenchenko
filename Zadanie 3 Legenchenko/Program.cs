using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadanie_3_Legenchenko
{
    public interface IStudent
    {
        string Имя { get; set; }
        int Курс { get; set; }
        void УстановитьОценки(params double[] оценки);
        double ПолучитьСреднийБалл();
        void ПолучитьИнформациюОКурсе();
    }

    public class Студент : IStudent
    {
        public string Имя { get; set; }
        public int Курс { get; set; }
        private List<double> оценки;

        public Студент(string имя, int курс)
        {
            Имя = имя;
            Курс = курс;
            оценки = new List<double>();
        }

        public void УстановитьОценки(params double[] оценки)
        {
            this.оценки.AddRange(оценки);
        }

        public double ПолучитьСреднийБалл()
        {
            if (оценки.Count == 0)
            {
                return 0;
            }
            return оценки.Sum() / оценки.Count;
        }

        public void ПолучитьИнформациюОКурсе()
        {
            Console.WriteLine($"Студент {Имя} учится на {Курс} курсе.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем студентов разных курсов
            IStudent студент1 = new Студент("Иванов Иван", 1);
            IStudent студент2 = new Студент("Петрова Мария", 1);
            IStudent студент3 = new Студент("Сидоров Петр", 2);
            IStudent студент4 = new Студент("Смирнова Анна", 2);
            IStudent студент5 = new Студент("Кузнецов Дмитрий", 3);
            IStudent студент6 = new Студент("Васильева Елена", 3);

            // Устанавливаем оценки студентам
            студент1.УстановитьОценки(4.5, 3.7, 4.0);
            студент2.УстановитьОценки(3.8, 3.9, 4.2);
            студент3.УстановитьОценки(4.2, 4.0, 4.5);
            студент4.УстановитьОценки(4.1, 4.3, 4.4);
            студент5.УстановитьОценки(3.9, 3.8, 3.7);
            студент6.УстановитьОценки(4.0, 3.5, 3.9);

            // Список студентов разных курсов
            var students = new List<IStudent> { студент1, студент2, студент3, студент4, студент5, студент6 };

            // Запрашиваем информацию о курсе
            while (true)
            {
                Console.WriteLine("Введите номер курса для просмотра студентов (от 1 до 3) или 'exit' для выхода:");
                var input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    break;
                }
                if (int.TryParse(input, out int выбранныйКурс) && выбранныйКурс >= 1 && выбранныйКурс <= 3)
                {
                    var студентыНаКурсе = students.Where(s => s.Курс == выбранныйКурс).ToList();
                    Console.WriteLine($"Студенты на {выбранныйКурс} курсе:");
                    foreach (var student in студентыНаКурсе)
                    {
                        Console.WriteLine($"Имя: {student.Имя}, Средний балл: {student.ПолучитьСреднийБалл()}");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
                }
            }
        }
    }
}
