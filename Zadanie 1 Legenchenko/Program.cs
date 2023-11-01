using System;

namespace Zadanie_1_Legenchenko
{
    interface IFigure
    {
        double CalculateArea();
        double CalculatePerimeter();
    }

    class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    class Rectangle : IFigure
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalculateArea()
        {
            return length * width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (length + width);
        }
    }

    class Triangle : IFigure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double CalculateArea()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public double CalculatePerimeter()
        {
            return sideA + sideB + sideC;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите фигуру для измерения: ");
                Console.WriteLine("1. Круг");
                Console.WriteLine("2. Прямоугольник");
                Console.WriteLine("3. Треугольник");
                Console.WriteLine("4. Завершить приложение");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 4)
                {
                    break; // Завершение приложения
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите радиус круга: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Circle circle = new Circle(radius);
                        Console.WriteLine("Площадь круга: " + circle.CalculateArea());
                        Console.WriteLine("Периметр круга: " + circle.CalculatePerimeter());
                        break;

                    case 2:
                        Console.WriteLine("Введите длину прямоугольника: ");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите ширину прямоугольника: ");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Rectangle rectangle = new Rectangle(length, width);
                        Console.WriteLine("Площадь прямоугольника: " + rectangle.CalculateArea());
                        Console.WriteLine("Периметр прямоугольника: " + rectangle.CalculatePerimeter());
                        break;

                    case 3:
                        Console.WriteLine("Введите сторону A треугольника: ");
                        double sideA = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите сторону B треугольника: ");
                        double sideB = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите сторону C треугольника: ");
                        double sideC = Convert.ToDouble(Console.ReadLine());
                        Triangle triangle = new Triangle(sideA, sideB, sideC);
                        Console.WriteLine("Площадь треугольника: " + triangle.CalculateArea());
                        Console.WriteLine("Периметр треугольника: " + triangle.CalculatePerimeter());
                        break;

                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
        }
    }
}
