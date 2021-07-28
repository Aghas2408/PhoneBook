using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    public static class Shower
    {
        public static void ShowPhoneBook(PhoneBook phoneBook)
        {
            foreach (var item in phoneBook.contacts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
