using System;

class MainClass
{
    static void Main(string[] args)
    {
        int[] arr = new[] { 3, 7, 1, -9, 5 };
        int[] arr2 = new[] { 1, 2, 3, 4, 5, 6, 9 };

        Console.WriteLine(IsSorted(arr).ToString());
        Console.WriteLine(IsSorted(arr2).ToString());
        Console.ReadKey();
    }

    static bool IsSorted(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (!(array[i] <= array[i + 1]))
            {
                return false;
            }
        }
        return true;
    }
}