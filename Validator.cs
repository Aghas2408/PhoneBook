using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    public static class Validator
    {
        public static void ValidatePhoneBook()
        {
            Console.WriteLine();
            Console.WriteLine("Validations:");
            var j = 0;
            foreach (var item in ConsoleHost.contacts)
            {
                bool canOutput = false;
                string s = "Line:" + (j + 1).ToString();
                if (item.Phone.Length != 9)
                {
                    s += " Phone number should be with 9 Digits.";
                    canOutput = true;
                }
                if (item.Seperator != ":" && item.Seperator != "-")
                {
                    s += " The separator should be `:` or `-`.";
                    canOutput = true;
                }
                if (canOutput)
                {
                    Console.WriteLine(s);
                }
                j++;
            }
        }
    }
}
