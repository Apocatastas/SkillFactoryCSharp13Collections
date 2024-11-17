using System;
using System.Collections;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var months = new[]
        {
            "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
        };

        var numbers = new[]
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
        };

        var monthList = new ArrayList();

        foreach (var index in numbers)
        {
            // добавляем в ArrayList строку месяца (начинаем с нулевого по индексу)
            monthList.Add(months[index - 1]);

            // добавляем его порядковый номер
            monthList.Add(index);
        }

        foreach (var value in monthList)
        {
            Console.WriteLine(value);
        };
            
        Console.ReadKey();
    }
}