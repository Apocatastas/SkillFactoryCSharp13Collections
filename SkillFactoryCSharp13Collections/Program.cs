using System.Collections.Generic;
using SkillFactoryCSharp13Collections;

class Program
{
    private static Dictionary<string, Contact> PhoneBook = new Dictionary<String, Contact>()
    {
        ["Ozzy"] = new Contact(12345678900, "ozzy@black-sabbath.com"),
        ["Mike"] = new Contact(12345678901, "Mike@rolling-stones.com"),
    };

    /// <summary>
    /// Программа при запуске  должна :
    /// 1. Вывести существующие контакты с номерами телефонов(на старте должно храниться 2).
    /// 2. Добавить новый контакт.
    /// 3. Вывести обновлённый список.
    /// 4. Изменить у вновь добавленного контакта номер телефона.
    /// 5. Снова вывести весь список.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Console.WriteLine("Текущий список контактов: ");
        PrintContacts();
        PhoneBook.TryAdd("Lemmy", new Contact(12345678902, "lemmy@motorhead.com"));
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


