using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    static class Validator
    {
        public static List<string> shapes = new List<string>()
        {
            "rectangle",
            "triangle",
        };
        public static bool ValidateFirstInput(string s)
        {
            return shapes.Contains(s.ToLower());
        }
        public static bool ValidateColorInput(string s)
        {
            return Colors.drawColors.Contains(s);
        }
    }
}
