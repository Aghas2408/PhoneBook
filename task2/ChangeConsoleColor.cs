using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Interfaces;

namespace task2
{
    public class ChangeConsoleColor : IChangeColor
    {
        ConsoleColor col;
        public void ChangeColor(string inputColor)
        {
            if(Enum.TryParse(inputColor, true,out col))
            {
                if (Enum.IsDefined(typeof(ConsoleColor), col))
                {
                    Console.ForegroundColor = col;
                }
            }
        }
    }
}
