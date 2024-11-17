using System;
using System.Collections;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int res = 0;
        StringBuilder textRes = new StringBuilder();

        var elemList = new ArrayList()
           {
                13, 666, "var", "manowar", 16, 45, -13, "iron", " ", "maiden", 999, 71, 8

           };

        foreach (var item in elemList)
        {
            if (item is int)
            {
                res += (int)item;
            }
            else if (item is string s)
            {
                textRes.Append(item);
            }
        }

        var finalRes = new ArrayList() { res, textRes.ToString() };

        foreach (var item in finalRes)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }
}