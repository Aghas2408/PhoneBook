using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    public static class Converter
    {
        private static readonly int LineLengthWhenLineEmpty = 1;
        private static readonly int LineLengthWhenSurNameEmpty = 5;
        private static readonly int LineLengthWhenSurNameNotEmpty = 4;

        public static Contact[] LinesToContacts(int contactsArrayLength, string[] arr)
        {
            var contactsArray = new Contact[contactsArrayLength];
            for (int i = 0; i < contactsArray.Length; i++)
            {
                Contact obj = new Contact();
                var splitedLine = arr[i].Split(' ');
                int j = 0;
                if (splitedLine.Length == LineLengthWhenLineEmpty)
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
                else if (splitedLine.Length == LineLengthWhenSurNameNotEmpty)
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
