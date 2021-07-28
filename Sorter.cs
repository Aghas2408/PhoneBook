using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    public delegate bool SortType(Contact cont1, Contact cont2);

    public static class Sorter
    {
        public static void SortPhoneBook(SortType del)
        {
            MergeSort(ConsoleHost.contacts, 0, ConsoleHost.contacts.Length - 1, del);
        }

        public static bool AscendingSortByName(Contact cont1, Contact cont2)
        {
            if (string.Compare(cont1.Name, cont2.Name) == 0 || string.Compare(cont1.Name, cont2.Name) == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AscendingSortBySurName(Contact cont1, Contact cont2)
        {
            if ((string.Compare(cont1.SurName, cont2.SurName) == 0 || string.Compare(cont1.SurName, cont2.SurName) == -1) &&
                (cont1.SurName != "") && cont2.SurName != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AscendingSortByPhone(Contact cont1, Contact cont2)
        {
            if (string.Compare(cont1.Phone.Substring(0, 3), cont2.Phone.Substring(0, 3)) == 0 || string.Compare(cont1.Phone.Substring(0, 3), cont2.Phone.Substring(0, 3)) == -1) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DescendingSortByPhone(Contact cont1, Contact cont2)
        {
            if (string.Compare(cont1.Phone.Substring(0, 3), cont2.Phone.Substring(0, 3)) == 0 || string.Compare(cont1.Phone.Substring(0, 3), cont2.Phone.Substring(0, 3)) == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool DescendingSortBySurName(Contact cont1, Contact cont2)
        {
            if ((string.Compare(cont1.SurName, cont2.SurName) == 0 || string.Compare(cont1.SurName, cont2.SurName) == -1)  &&
                (cont1.SurName != "" && cont2.SurName != ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool DescendingSortByName(Contact cont1, Contact cont2)
        {
            if (string.Compare(cont1.Name, cont2.Name) == 0 || string.Compare(cont1.Name, cont2.Name) == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void Merge(Contact[] input, int left, int middle, int right, SortType del)
        {
            Contact[] leftArray = new Contact[middle - left + 1];
            Contact[] rightArray = new Contact[right - middle];
            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);
            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (del(leftArray[i], rightArray[j]))
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }

        public static void MergeSort(Contact[] input, int left, int right, SortType del)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(input, left, middle, del);
                MergeSort(input, middle + 1, right, del);
                Merge(input, left, middle, right, del);
            }
        }
    }
}
