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
            var shapename = ConsoleHost.shapes.Where(i => i.ShapeName == s).FirstOrDefault();
            return shapename != null;
        }

        public static bool ValidateColorInput(string s)
        {
            return Colors.drawColors.Contains(s);
        }
    }
}
