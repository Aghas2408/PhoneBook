using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Interfaces;

namespace task2
{
    class ChangeConsoleColor : IChangeColor
    {
        public void ChangeColor(string inputColor)
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), inputColor, true);
        }
    }
}
