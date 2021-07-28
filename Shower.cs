using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    public static class Shower
    {
        public static void ShowPhoneBook()
        {
            foreach (var item in ConsoleHost.contacts)
            {
                Console.WriteLine("{0} {1} {2} {3}",item.Name,item.SurName,item.Seperator,item.Phone);
            }
        }
    }
}
