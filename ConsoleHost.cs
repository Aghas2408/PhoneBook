using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PhoneBook
{
    public static class ConsoleHost
    {
        public static string sortOrdering;
        public static string criteria;
        public static Contact[] contacts;

        public static void Run()
        {
            Console.WriteLine("Find the files here");
            var pathName = @"" + Console.ReadLine();
            string[] lines = File.ReadAllLines(pathName).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray(); ; ;
            contacts = new Contact[lines.Length];
            //"C:\Users\User\Desktop\PhoneBook\samples\Sample1.txt"
            Console.WriteLine("Please choose an ordering to sort: 'Ascending' or 'Descending'");
            sortOrdering = Console.ReadLine();
            Console.WriteLine("Please choose criteria: 'Name', 'Surname' or 'PhoneNumberCode' ");
            criteria = Console.ReadLine();
            Converter.LinesToContacts(contacts, lines);
            if (sortOrdering.ToLower() == "ascending")
            {
                if (criteria.ToLower() == "name")
                {
                    Sorter.SortPhoneBook(Sorter.AscendingSortByName);
                }
                else if (criteria.ToLower() == "surname")
                {
                    Sorter.SortPhoneBook(Sorter.AscendingSortBySurName);
                }
                else if (criteria.ToLower() == "phonenumbercode")
                {
                    Sorter.SortPhoneBook(Sorter.AscendingSortByPhone);
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
                    Sorter.SortPhoneBook(Sorter.DescendingSortByName);
                }
                else if (criteria.ToLower() == "surname")
                {
                    Sorter.SortPhoneBook(Sorter.DescendingSortBySurName);
                }
                else if (criteria.ToLower() == "phonenumbercode")
                {
                    Sorter.SortPhoneBook(Sorter.DescendingSortByPhone);
                }
                else
                {
                    Console.WriteLine("Invalid Input,Please try again");
                }
            }
            Shower.ShowPhoneBook();
            Validator.ValidatePhoneBook();
        }
    }
}
