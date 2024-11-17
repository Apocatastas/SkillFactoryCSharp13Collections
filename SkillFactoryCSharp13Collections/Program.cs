using System;
using System.Collections;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var months = new List<string>()
        {
            "Jan", "Feb", "Mar", "Apr", "May"
        };

        var missing = new ArrayList()
        {
            1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
        };

        GetMissing(months, missing);

        foreach (var month in months)
        {
            Console.WriteLine(month);
        }
            
        Console.ReadKey();
    }

    private static void GetMissing(List<string> months, ArrayList missing)
    {
        var missedArray = new string[7];
        missing.GetRange(4, 7).CopyTo(missedArray);
        months.AddRange(missedArray);
    }
}