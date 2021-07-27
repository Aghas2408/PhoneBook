using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    public static class Converter
    {
        public static void LinesToWords(ref string[,] juggarr, string[] arr)
        {
            int rows = juggarr.GetUpperBound(0) + 1;
            //int columns = juggarr.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                var splitedLine = arr[i].Split(' ');
                int j = 0;
                if (splitedLine.Length == 5 )
                {
                    juggarr[i, 0] = splitedLine[j++];
                    juggarr[i, 1] = splitedLine[j++];
                    j++;
                    juggarr[i, 2] = splitedLine[j++];
                    juggarr[i, 3] = splitedLine[j];
                }
                else
                {
                    foreach (var item in splitedLine)
                    {
                        juggarr[i, j] = item;
                        j++;
                    }
                }
            }
        }
    }
}
