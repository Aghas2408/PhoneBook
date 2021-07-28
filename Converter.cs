using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    public static class Converter
    {
        private static int LineLengthWhenSurNameEmpty = 5;

        public static Contact[] LinesToContacts(string[] arr)
        {
            var contactsArray = new Contact[ConsoleHost.contacsArrayLength];
            for (int i = 0; i < contactsArray.Length; i++)
            {
                Contact obj = new Contact();
                var splitedLine = arr[i].Split(' ');
                int j = 0;
                if (splitedLine.Length == 1)
                {
                    continue;
                }
                if (splitedLine.Length == LineLengthWhenSurNameEmpty)
                {
                    obj.Name = splitedLine[j++];
                    obj.SurName = splitedLine[j++];
                    j++;
                    obj.Seperator = splitedLine[j++];
                    obj.Phone = splitedLine[j];
                }
                else if (splitedLine.Length == 4)
                {
                    obj.Name = splitedLine[j++];
                    obj.SurName = splitedLine[j++];
                    obj.Seperator = splitedLine[j++];
                    obj.Phone = splitedLine[j];
                }
                contactsArray[i] = obj;
            }
            return contactsArray;
        }
    }
}
