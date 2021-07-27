using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public static class Colors
    {
        public static List<string> drawColors = new List<string>()
        {
            "White",
            "Blue",
            "Red",
            "Green",
            "Azure",
            "Gray",
            "Gold",
            "Lime",
            "Olive",
            "Orange",
            "Purple",
            "Silver"
        };

        public static void DisplayColors()
        {
            Console.WriteLine("What Color do you like to use for shape ?");
            Console.WriteLine("You can choose one of these");
            foreach (string s in drawColors)
            {
                Console.Write(s + ", ");
            }
            Console.WriteLine();
        }
    }
}
