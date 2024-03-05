using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
class Program
{
    static void Main()
    {
        var input = new List<Dictionary<string, object>>// Створюємо список словників, де кожен словник містить пару "item"-"amount"
        {
            new Dictionary<string, object> {{"item", "item1"}, {"amount", 400}},
            new Dictionary<string, object> {{"item", "item2"}, {"amount", 300}},
            new Dictionary<string, object> {{"item", "item1"}, {"amount", 750}}
        };

        // Групуємо словники за "item" і створюємо новий словник, де ключем є "item", а значенням є сума "amount" для кожного "item"
        var result = input.GroupBy(dict => dict["item"].ToString())
                          .ToDictionary(group => group.Key, group => group.Sum(dict => Convert.ToInt32(dict["amount"])));

        var json = JsonConvert.SerializeObject(result, Formatting.Indented);// Серіалізуємо результат в JSON
        Console.WriteLine(json);
    }
}