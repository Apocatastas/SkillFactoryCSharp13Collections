using System;
using System.Collections.Generic;

class Program
{
    public static Stack<string> words = new Stack<string>();

    static void Main(string[] args)
    {
        Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
        Console.WriteLine();

        while (true)
        {
            var input = Console.ReadLine();

            switch (input)
            {
                case "pop":
                    words.TryPop(out string popResult);
                    break;
                case "peek":
                    Console.WriteLine("Результат команды peek:" + words.TryPeek(out string peekResult) + " " +  peekResult);
                    break;
                default:
                    words.Push(input);
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("В стеке:");

            foreach (var word in words)
            {
                Console.WriteLine(" " + word);
            }
        }
    }
}

