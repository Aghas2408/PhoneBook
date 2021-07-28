using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    public class Contact
    {
        private string name;
        private string surName;
        private string phone;
        private string seperator;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string SurName
        {
            get => surName;
            set => surName = value;
        }
        public string Phone
        {
            get => phone;
            set => phone = value;
        }
        public string Seperator
        {
            get => seperator;
            set => seperator = value;
        }
    }
}
