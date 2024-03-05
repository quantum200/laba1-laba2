using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string path = "C:\\Users\\ASUS\\OneDrive\\Рабочий стол\\кпи\\прога\\2semestr\\laba1\\zad1\\input.txt";
        string fileContent = File.ReadAllText(path);// Читаємо вміст файлу і зберігаємо його в змінну
        List<string> list = new List<string>(fileContent.Split(' '));// Розділяємо вміст файлу на слова і додаємо їх до списку
        for (int i = 0; i < list.Count; i++)// Переводимо всі слова до нижнього регістру
        {
            list[i] = list[i].ToLower();
        }
        for (int i = 0; i < list.Count; i++)// Видаляємо повторюючі слова
        {
            while (i != list.LastIndexOf(list[i].ToLower()))
            {
                list.RemoveAt(list.LastIndexOf(list[i].ToLower()));
            }
        }
        foreach (string word in list)// Виводимо унікальні слова на консоль
        {
            Console.WriteLine(word);
        }
        Console.ReadLine();
    }
}