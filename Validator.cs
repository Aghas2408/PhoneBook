using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    public static class Validator
    {
        public const int PhoneMaxLength = 9;
        public static readonly string[] Seperators = { ":", "-" };

        public static void ValidatePhoneBook(PhoneBook phoneBook)
        {
            Console.WriteLine();
            Console.WriteLine("Validations:");
            var j = 1;
            foreach (var item in phoneBook.contacts)
            {
                bool contactContainErrors = false;
                StringBuilder s = new StringBuilder("Line:" + j);
                if (item.Phone.Length != PhoneMaxLength)
                {
                    s.Append(" Phone number should be with 9 Digits.");
                    contactContainErrors = true;
                }
                if (!Array.Exists(Seperators, element => element == item.Seperator))
                {
                    for (var i = 0; i < Seperators.Length - 1; i++)
                    {
                        s.Append(" The separator should be '" + Seperators[i] + "' or '" + Seperators[i + 1] + "' .");
                    }
                    contactContainErrors = true;
                }
                if (contactContainErrors)
                {
                    Console.WriteLine(s);
                }
                j++;
            }
        }
    }
}
