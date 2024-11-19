using System.Collections.Generic;
using SkillFactoryCSharp13Collections;
using System.Diagnostics;

class Program
{
    private static SortedDictionary<string, Contact> PhoneBook = new SortedDictionary<String, Contact>()
    {
        ["Ozzy"] = new Contact(12345678900, "ozzy@black-sabbath.com"),
        ["Mike"] = new Contact(12345678901, "Mike@rolling-stones.com"),
    };

    static void Main(string[] args)
    {
        Console.WriteLine("Текущий список контактов: ");
        PrintContacts();
        var watchTwo = Stopwatch.StartNew();
        PhoneBook.TryAdd("Lemmy", new Contact(12345678902, "lemmy@motorhead.com"));
        Console.WriteLine($"Вставка в  словарь: {watchTwo.Elapsed.TotalMilliseconds}  мс");
        Console.WriteLine("Обновленный список контактов: ");
        PrintContacts();
        if (PhoneBook.TryGetValue("Lemmy", out Contact contact))
        {
            contact.PhoneNumber = 12345678903;
        }
        Console.WriteLine("Список после изменения: ");
        PrintContacts();
        Console.ReadKey();
    }

    public static void PrintContacts()
    {
        foreach (var contact in PhoneBook)
            Console.WriteLine(contact.Key + ": " + contact.Value.PhoneNumber);
        Console.WriteLine();
    }
}


