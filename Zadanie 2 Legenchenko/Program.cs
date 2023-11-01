using System;

namespace Zadanie_2_Legenchenko
{
    // Создание интерфейса "Товар"
    public interface IProduct
    {
        decimal GetCost(); // Метод для определения стоимости товара
        int GetStock(); // Метод для определения остатка товара на складе
        void AddStock(int quantity); // Метод для добавления товара на склад
        void SetPrice(decimal price); // Метод для установки цены товара
    }

    // Реализация интерфейса "Товар" для класса "Шоколадка"
    public class Chocolate : IProduct
    {
        private string name;
        private decimal price;
        private int stock;

        public Chocolate(string name, decimal price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        public decimal GetCost()
        {
            return price * stock;
        }

        public int GetStock()
        {
            return stock;
        }

        public void AddStock(int quantity)
        {
            stock += quantity;
        }

        public void SetPrice(decimal newPrice)
        {
            price = newPrice;
        }
    }

    // Реализация интерфейса "Товар" для класса "Пирожок"
    public class Pie : IProduct
    {
        private string name;
        private decimal price;
        private int stock;

        public Pie(string name, decimal price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        public decimal GetCost()
        {
            return price * stock;
        }

        public int GetStock()
        {
            return stock;
        }

        public void AddStock(int quantity)
        {
            stock += quantity;
        }

        public void SetPrice(decimal newPrice)
        {
            price = newPrice;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример использования интерфейсов и классов
            Chocolate chocolate = new Chocolate("Аленка", 25.50m, 20);
            Console.WriteLine("Цена шоколада: " + chocolate.GetCost());
            Console.WriteLine("Шоколада осталось " + chocolate.GetStock());
            chocolate.AddStock(10);
            chocolate.SetPrice(29.99m);
            Console.WriteLine("Новая цена шоколада: " + chocolate.GetCost());
            Console.WriteLine("Добавка шоколада к остатку: " + chocolate.GetStock());

            Pie pie = new Pie("Пирожок с вишней", 5.50m, 30);
            Console.WriteLine("Цена пирога: " + pie.GetCost());
            Console.WriteLine("Пирогов осталось: " + pie.GetStock());
            pie.AddStock(15);
            pie.SetPrice(6.99m);
            Console.WriteLine("Новая цена пирога: " + pie.GetCost());
            Console.WriteLine("Добавка пирогов к остатку: " + pie.GetStock());
        }
    }
}
