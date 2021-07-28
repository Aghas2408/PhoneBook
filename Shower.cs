using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    public static class Shower
    {
        public static void ShowPhoneBook()
        {
            foreach (var item in PhoneBook.contacts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
