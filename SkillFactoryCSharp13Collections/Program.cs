using System;
using System.Collections;
using System.Text;
using SkillFactoryCSharp13Collections;

class Program
{
    static void Main(string[] args)
    {
        var phoneBook = new List<Contact>();
        phoneBook.Add(new Contact("Игорь", 79990000000, "igor@example.com"));
        phoneBook.Add(new Contact("Андрей", 79990000001, "andrew@example.com"));

        AddUnique(new Contact("Игорь", 79990066601, "igor2@example.com"),phoneBook);

        foreach (var contact in phoneBook)
        {
            Console.WriteLine(contact.Name + ": " + contact.PhoneNumber);
        }

        Console.ReadKey();
    }

    private static void AddUnique(Contact newContact, List<Contact> phoneBook)
    {
        bool alreadyExists = false;
        foreach (var contact in phoneBook)
        {
            if (contact.Name == newContact.Name)
            {
                alreadyExists = true;
                break;
            }
        }

        if (!alreadyExists)
            phoneBook.Add(newContact);
        phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));
    }
}