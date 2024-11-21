using System.Collections.Generic;
using System;
using System.Linq;
using System.Xml.Linq;

class Program
{
    /// <summary>
    /// Ваша задача — написать программу ,которая позволит понять, какие 10 слов
    /// чаще всего встречаются в тексте.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Console.WriteLine("Запускаем обработку текста...");
        try
        {
            string text = File.ReadAllText("../../../Assets/Text1.txt");
            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            char[] delimiters = new char[] { ' ', '\r', '\n', '–' };
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("\nОбработка текста завершена, считаем уникальные слова...");
            List<string> wordsList = new List<string>();
            foreach (string element in words)
            {
                wordsList.Add(element);
            }
            Console.WriteLine("\n10 cамых популярных слов в тексте: ");
            var result = wordsList.GroupBy(x => x).OrderByDescending(x => x.Count()).Take(10);
            foreach (var item in result)
            {
                Console.WriteLine(item.Key.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }
}