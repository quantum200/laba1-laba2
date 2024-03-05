using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        Dictionary<string, int> products = new Dictionary<string, int>() // Створюємо словник продуктів харчування
        {
            {"Молоко", 30},
            {"Хлiб", 20},
            {"Сир", 120},
            {"М'ясо", 200},
            {"Риба", 150},
            {"Яйця", 40}
        };

        var cheaper = products.Where(p => p.Value <= 100); // Розділяємо товари на дві цінові групи
        var expensive = products.Where(p => p.Value > 100); // Розділяємо товари на дві цінові групи

        Console.WriteLine("Перший товар дешевше 100 гривень: " + cheaper.First().Key);
        Console.WriteLine("Останнiй товар дорожче 100 гривень: " + expensive.Last().Key);
        Console.WriteLine("Кiлькiсть товарiв дешевше 100 гривень: " + cheaper.Count());
        Console.WriteLine("Сума цiн товарiв дорожче 100 гривень: " + expensive.Sum(p => p.Value));
        Console.WriteLine("Середня цiна товарiв дешевше 100 гривень: " + cheaper.Average(p => p.Value));
        Console.WriteLine("Максимальна цiна серед товарiв дорожче 100 гривень: " + expensive.Max(p => p.Value));
        Console.WriteLine("Мiнiмальна цiна серед товарiв дешевше 100 гривень: " + cheaper.Min(p => p.Value));
        Console.WriteLine("Сума цiн всiх товарiв: " + products.Aggregate(0, (total, next) => total + next.Value));
    }
}