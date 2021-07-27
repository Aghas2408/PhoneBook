using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    static class Validator
    {
        public static bool ValidateFirstInput(string s)
        {
            foreach(var i in ConsoleHost.shapes)
            {
                if (i.ShapeName == s)
                    return true;
            }
            return false;
        }
        public static bool ValidateColorInput(string s)
        {
            return Colors.drawColors.Contains(s);
        }
    }
}
