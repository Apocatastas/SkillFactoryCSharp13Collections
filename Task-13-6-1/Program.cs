using System.Collections.Generic;
using System.Diagnostics;
using System;
using System.Linq;


class Program
{
    /// <summary>
    /// Наша задача — сравнить производительность вставки в List<T> и LinkedList<T>.
    /// Для этого используйте уже знакомый вам StopWatch.
    /// На примере этого текста, выясните, какие будут различия между этими коллекциями.
    /// </summary>
    /// <param name="args"></param>

    static void Main(string[] args)
    {
        Console.WriteLine("Запускаем обработку текста...");
        try
        {
            string text = File.ReadAllText("../../../Assets/Text1.txt");
            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            List<string> normalList = new List<string>();
            LinkedList<string> linkedList = new LinkedList<string>();

            Console.WriteLine("\nВыбираем, что будем проверять - введите 1 если List, введите 2 если LinkedList");
            int answer = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    {
                        DoList(normalList, words);
                        break;
                    }
                case 2:
                    {
                        DoLinkedList(linkedList, words);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("\nВыбор не распознан");
                        break;
                    }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }

    static void DoList(List<string> normalList, string[] text)
    {
        foreach (string element in text)
        {
            normalList.Add(element);
        }
        Console.WriteLine("\nCHECKSUM: " + normalList.Count.ToString());
        var watchTwo = Stopwatch.StartNew();
        normalList.Insert(2, "numbertwo");
        Console.WriteLine($"\nВставка в List: {watchTwo.Elapsed.TotalMilliseconds}  мс");
        Console.WriteLine("\nCHECKSUM: " + normalList.Count.ToString());
    }

    static void DoLinkedList(LinkedList<string> linkedList, string[] text)
    {
        foreach (string element in text)
        {
            linkedList.AddLast(element);
        }
        Console.WriteLine("\nCHECKSUM: " + linkedList.Count.ToString());
        var watchTwo = Stopwatch.StartNew();
        linkedList.AddAfter(linkedList.First, "numbertwo");
        Console.WriteLine($"\nВставка в LinkedList: {watchTwo.Elapsed.TotalMilliseconds}  мс");
        Console.WriteLine("\nCHECKSUM: " + linkedList.Count.ToString());
    }
}
