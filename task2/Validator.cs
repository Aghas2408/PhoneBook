using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    static class Validator
    {
       
        public static bool validateFirstInput(string s)
        {
            if (s.ToLower() == "rectangle" || s.ToLower() == "triangle")
                return true;
            else
                return false;
        }
        public static bool validateColorInput(string s)
        {
            if (Colors.drawColors.Contains(s))
                return true;
            else
                return false;
        }
    }
}
