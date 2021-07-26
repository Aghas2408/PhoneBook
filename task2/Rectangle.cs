using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Interfaces;

namespace task2
{
    class Rectangle : IRectangle, IMovableRectangle 
    {
        public void drawRectangle(int w, int h)
        {
            Console.SetCursorPosition(w,h);
            string s = "╔";
            string space = "";
            string first_space = "";
            for (int i = 0; i < 5; i++)
            {
                space += " ";
                s += "═";
            }

            for (int i = 0; i <w; i++)
            {
  
                first_space += " ";

            }
         
            s += "╗" + "\n";

            for (int i = 0; i < 5; i++)
                s += first_space + "║" + space + "║" + "\n";

            s +=  first_space + "╚";
            for (int i = 0; i < 5; i++)
                s += "═";

            s += "╝" + "\n";


            Console.Write(s);


        }

        public void moveRectangle()
        {
            while (true)
            {
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.W )
                {
                    
                    if(ConsoleHost.top-1 >= 0)
                    {
                        ConsoleHost.top -= 1;
                        Console.Clear();
                        drawRectangle(ConsoleHost.left, ConsoleHost.top);
                    }

                }
                if (input.Key == ConsoleKey.S)
                {
                    if (ConsoleHost.top + 1 <= Console.WindowHeight)
                    {
                        ConsoleHost.top++;
                        Console.Clear();
                        drawRectangle(ConsoleHost.left, ConsoleHost.top);
                    }
                }
                if (input.Key == ConsoleKey.A)
                {
                    if (ConsoleHost.left - 1 >= 0)
                    {
                        ConsoleHost.left--;
                        Console.Clear();
                        drawRectangle(ConsoleHost.left, ConsoleHost.top);
                    }
                }
                if (input.Key == ConsoleKey.D)
                {
                    if (ConsoleHost.left + 8 < Console.WindowWidth)
                    {
                        ConsoleHost.left ++;
                        Console.Clear();
                        drawRectangle(ConsoleHost.left, ConsoleHost.top);
                    }
                }
            }
          
        }
    }
}
