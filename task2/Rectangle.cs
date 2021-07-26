using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Interfaces;

namespace task2
{
    class Rectangle : IShape, IMovable
    {
        const string FirstCorner = "╔";
        const string SecondCorner = "╗";
        const string ThirdCorner = "╚";
        const string FourthCorner = "╝";
        const string HorizontalElement = "=";
        const string VerticalElement = "║";
        public void Draw(int w, int h)
        {
            Console.SetCursorPosition(w,h);
            string s = FirstCorner;
            string space = "";
            string first_space = "";
            for (int i = 0; i < 5; i++)
            {
                space += " ";
                s += HorizontalElement;
            }

            for (int i = 0; i <w; i++)
            {
  
                first_space += " ";

            }
         
            s += SecondCorner + "\n";

            for (int i = 0; i < 5; i++)
                s += first_space +VerticalElement + space + VerticalElement + "\n";

            s +=  first_space + ThirdCorner;
            for (int i = 0; i < 5; i++)
                s += "═";

            s += FourthCorner + "\n";


            Console.Write(s);


        }

        public void Move()
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
                        Draw(ConsoleHost.left, ConsoleHost.top);
                    }

                }
                if (input.Key == ConsoleKey.S)
                {
                    if (ConsoleHost.top + 1 <= Console.WindowHeight)
                    {
                        ConsoleHost.top++;
                        Console.Clear();
                        Draw(ConsoleHost.left, ConsoleHost.top);
                    }
                }
                if (input.Key == ConsoleKey.A)
                {
                    if (ConsoleHost.left - 1 >= 0)
                    {
                        ConsoleHost.left--;
                        Console.Clear();
                        Draw(ConsoleHost.left, ConsoleHost.top);
                    }
                }
                if (input.Key == ConsoleKey.D)
                {
                    if (ConsoleHost.left + 8 < Console.WindowWidth)
                    {
                        ConsoleHost.left ++;
                        Console.Clear();
                        Draw(ConsoleHost.left, ConsoleHost.top);
                    }
                }
            }
          
        }
    }
}
