using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PhoneBook
{
    public static class ConsoleHost
    {
        public static void Run()
        {
            Console.WriteLine("Find the files here");
            var pathName = @"" +  Console.ReadLine();       
            string[] lines = System.IO.File.ReadAllLines(pathName);
            string[,] wordsOfLines = new string[lines.Length,4];
            //"C:\Users\User\Desktop\PhoneBook\samples\Sample1.txt"
            Console.WriteLine("Please choose an ordering to sort: 'Ascending' or 'Descending'");
            var sortOrdering = Console.ReadLine();
            Console.WriteLine("Please choose criteria: 'Name', 'Surname' or 'PhoneNumberCode' ");
            var criteria = Console.ReadLine();
            Converter.LinesToWords(ref wordsOfLines,lines);
        }
    }
}
