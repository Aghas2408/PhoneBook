using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    public static class Converter
    {
        public static void LinesToContacts(Contact[] contactsArray, string[] arr)
        {
            for (int i = 0; i < contactsArray.Length; i++)
            {
                Contact obj = new Contact();
                var splitedLine = arr[i].Split(' ');
                int j = 0;
                if (splitedLine.Length == 1)
                {
                    continue;
                }
                if (splitedLine.Length == 5)
                {
                    obj.Name = splitedLine[j++];
                    obj.SurName = splitedLine[j++];
                    j++;
                    obj.Seperator = splitedLine[j++];
                    obj.Phone = splitedLine[j];
                }
                else
                {
                    obj.Name = splitedLine[j++];
                    obj.SurName = splitedLine[j++];
                    obj.Seperator = splitedLine[j++];
                    obj.Phone = splitedLine[j];
                }
                contactsArray[i] = obj;
            }
        }
    }
}
