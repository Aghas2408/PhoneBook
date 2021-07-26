using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Interfaces;

namespace task2
{
    public class Rectangle : Shape
    {
        private const string FirstCorner = "╔";
        private const string SecondCorner = "╗";
        private const string ThirdCorner = "╚";
        private const string FourthCorner = "╝";
        private const string HorizontalElement = "═";
        private const string VerticalElement = "║";
        private const int RectangleSideSize = 5;
        private const int MinDistanceFromRightSide = 7;
        public override void Draw(int w, int h)
        {
            Console.SetCursorPosition(w, h);
            string s = FirstCorner;
            string space = "";
            string first_space = "";
            for (int i = 0; i < RectangleSideSize; i++)
            {
                space += " ";
                s += HorizontalElement;
            }
            for (int i = 0; i < w; i++)
            {
                first_space += " ";
            }
            s += SecondCorner + "\n";
            for (int i = 0; i < RectangleSideSize; i++)
            {
                s += first_space + VerticalElement + space + VerticalElement + "\n";
            }
            s += first_space + ThirdCorner;
            for (int i = 0; i < RectangleSideSize; i++)
            {
                s += HorizontalElement;
            }
            s += FourthCorner + "\n";
            Console.Write(s);
        }

        public override void Move()
        {
            while (true)
            {
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.W || input.Key == ConsoleKey.UpArrow)
                {
                    if (ConsoleHost.top - 1 >= 0)
                    {
                        ConsoleHost.top--;
                        Console.Clear();
                        Draw(ConsoleHost.left, ConsoleHost.top);
                    }
                }
                else if (input.Key == ConsoleKey.S || input.Key == ConsoleKey.DownArrow)
                {
                    if (ConsoleHost.top + 1 <= Console.WindowHeight)
                    {
                        ConsoleHost.top++;
                        Console.Clear();
                        Draw(ConsoleHost.left, ConsoleHost.top);
                    }
                }
                else if (input.Key == ConsoleKey.A || input.Key == ConsoleKey.LeftArrow)
                {
                    if (ConsoleHost.left - 1 >= 0)
                    {
                        ConsoleHost.left--;
                        Console.Clear();
                        Draw(ConsoleHost.left, ConsoleHost.top);
                    }
                }
                else if (input.Key == ConsoleKey.D || input.Key == ConsoleKey.RightArrow)
                {
                    if (ConsoleHost.left + MinDistanceFromRightSide < Console.WindowWidth)
                    {
                        ConsoleHost.left++;
                        Console.Clear();
                        Draw(ConsoleHost.left, ConsoleHost.top);
                    }
                }
            }
        }
    }
}
