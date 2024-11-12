using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // читаем весь файл с рабочего стола в строку текста
            string text = File.ReadAllText("../../../Resources/cdev_Text.txt");

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            // выводим количество
            Console.WriteLine(words.Length);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }
}