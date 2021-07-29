using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    public class PhoneBook
    {
        public Contact[] contacts;
        public int contactsArrayLength;
        public static void SortPhoneBook(PhoneBook phoneBook, SortType del)
        {
            Sorter.MergeSort(phoneBook.contacts, 0, phoneBook.contacts.Length - 1, del);
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            foreach (var item in contacts)
            {
                s.Append(item + "\n");
            }
            return s.ToString();
        }
    }
}
