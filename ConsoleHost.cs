using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PhoneBook
{
    public static class ConsoleHost
    {
        public static void Run()
        {
            List<PhoneBook> phoneBooksList = new List<PhoneBook>();
            while (true)
            {
                Console.WriteLine("Find the files here");
                var pathName = @"" + Console.ReadLine();
                if (File.Exists(pathName))
                {
                    string[] lines = File.ReadAllLines(pathName).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                    PhoneBook phoneBook = new PhoneBook();
                    phoneBook.contactsArrayLength = lines.Length;
                    phoneBook.contacts = new Contact[phoneBook.contactsArrayLength];
                    phoneBook.contacts = Converter.LinesToContacts(phoneBook.contactsArrayLength, lines);
                    phoneBooksList.Add(phoneBook);
                }
                else if (pathName == "quite")
                {
                    break;
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            foreach (var phoneBook in phoneBooksList)
            {
                //"C:\Users\User\Desktop\PhoneBook\samples\Sample1.txt"
                Console.WriteLine("Please choose an ordering to sort: 'Ascending' or 'Descending'");
                var sortOrdering = Console.ReadLine();
                Console.WriteLine("Please choose criteria: 'Name', 'Surname' or 'PhoneNumberCode' ");
                var criteria = Console.ReadLine();
                if (sortOrdering.ToLower() == "ascending")
                {
                    if (criteria.ToLower() == "name")
                    {
                        PhoneBook.SortPhoneBook(phoneBook, Sorter.AscendingSortByName);
                    }
                    else if (criteria.ToLower() == "surname")
                    {
                        PhoneBook.SortPhoneBook(phoneBook, Sorter.AscendingSortBySurName);
                    }
                    else if (criteria.ToLower() == "phonenumbercode")
                    {
                        PhoneBook.SortPhoneBook(phoneBook, Sorter.AscendingSortByPhone);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input,Please try again");
                    }
                }
                else if (sortOrdering.ToLower() == "descending")
                {
                    if (criteria.ToLower() == "name")
                    {
                        PhoneBook.SortPhoneBook(phoneBook, (contact1, contact2) => !Sorter.AscendingSortByName(contact1, contact2));
                    }
                    else if (criteria.ToLower() == "surname")
                    {
                        PhoneBook.SortPhoneBook(phoneBook, (contact1, contact2) => !Sorter.AscendingSortBySurName(contact1, contact2));
                    }
                    else if (criteria.ToLower() == "phonenumbercode")
                    {
                        PhoneBook.SortPhoneBook(phoneBook, (contact1, contact2) => !Sorter.AscendingSortByPhone(contact1, contact2));
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input,Please try again");
                    }
                }
                Shower.ShowPhoneBook(phoneBook);
                Validator.ValidatePhoneBook(phoneBook);
            }
        }
    }
}
