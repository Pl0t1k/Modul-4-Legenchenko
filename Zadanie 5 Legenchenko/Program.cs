using System;

namespace Zadanie_5_Legenchenko
{
    // Интерфейс для рисования различных фигур
    public interface IDrawing
    {
        void DrawLine(int x1, int y1, int x2, int y2);
        void DrawCircle(int x, int y, int radius);
        void DrawRectangle(int x, int y, int width, int height);
    }

    // Класс, реализующий интерфейс рисования на холсте
    public class Canvas : IDrawing
    {
        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine($"Рисуем линию от ({x1}, {y1}) до ({x2}, {y2})");
            // здесь должна быть логика рисования линии на холсте
        }

        public void DrawCircle(int x, int y, int radius)
        {
            Console.WriteLine($"Рисуем круг с центром в точке ({x}, {y}) и радиусом {radius}");
            // здесь должна быть логика рисования круга на холсте
        }

        public void DrawRectangle(int x, int y, int width, int height)
        {
            Console.WriteLine($"Рисуем прямоугольник в точке ({x}, {y}) со сторонами {width} и {height}");
            // здесь должна быть логика рисования прямоугольника на холсте
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра класса Canvas
            Canvas canvas = new Canvas();

            Console.WriteLine("Выберите фигуру для рисования: ");
            Console.WriteLine("1. Линия");
            Console.WriteLine("2. Круг");
            Console.WriteLine("3. Прямоугольник");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите координаты для линии (x1 y1 x2 y2):");
                    var lineCoordinates = Console.ReadLine().Split(' ');
                    int x1 = Convert.ToInt32(lineCoordinates[0]);
                    int y1 = Convert.ToInt32(lineCoordinates[1]);
                    int x2 = Convert.ToInt32(lineCoordinates[2]);
                    int y2 = Convert.ToInt32(lineCoordinates[3]);
                    canvas.DrawLine(x1, y1, x2, y2);
                    break;
                case 2:
                    Console.WriteLine("Введите координаты для круга (x y radius):");
                    var circleCoordinates = Console.ReadLine().Split(' ');
                    int circleX = Convert.ToInt32(circleCoordinates[0]);
                    int circleY = Convert.ToInt32(circleCoordinates[1]);
                    int radius = Convert.ToInt32(circleCoordinates[2]);
                    canvas.DrawCircle(circleX, circleY, radius);
                    break;
                case 3:
                    Console.WriteLine("Введите координаты для прямоугольника (x y width height):");
                    var rectangleCoordinates = Console.ReadLine().Split(' ');
                    int rectX = Convert.ToInt32(rectangleCoordinates[0]);
                    int rectY = Convert.ToInt32(rectangleCoordinates[1]);
                    int rectWidth = Convert.ToInt32(rectangleCoordinates[2]);
                    int rectHeight = Convert.ToInt32(rectangleCoordinates[3]);
                    canvas.DrawRectangle(rectX, rectY, rectWidth, rectHeight);
                    break;
                default:
                    Console.WriteLine("Некорректный выбор.");
                    break;
            }
        }
    }
}
