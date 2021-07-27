using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Interfaces;

namespace task2
{
    public class Triangle : IShape
    {
        private const int TriangleSize = 10;
        private const int MinDistanceFromRightSide = 10;
        private string shapeName = "triangle";
        public string ShapeName
        {
            get
            {
                return shapeName;
            }
        }
        public  void Draw(int w, int h)
        {
            Console.SetCursorPosition(w, h);
            for (int i = 0; i < TriangleSize; i++)
            {
                for (int j = 0; j < (w - i); j++)
                {
                    Console.Write(" ");
                }   
                for (int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public  void Move()
        {
            while (true)
            {
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.W || input.Key == ConsoleKey.UpArrow)
                {
                    if (ConsoleHost.top - 1 >= 0)
                    {
                        ConsoleHost.top -= 1;
                        Console.Clear();
                        Draw(ConsoleHost.left, ConsoleHost.top);
                    }
                }
                else if (input.Key == ConsoleKey.S || input.Key == ConsoleKey.DownArrow)
                {
                    if (ConsoleHost.top + 1 <= Console.WindowHeight)
                    {
                        ConsoleHost.top += 1;
                        Console.Clear();
                        Draw(ConsoleHost.left, ConsoleHost.top);
                    }
                }
                else if (input.Key == ConsoleKey.A || input.Key == ConsoleKey.LeftArrow)
                {
                    if (ConsoleHost.left - MinDistanceFromRightSide >= 0)
                    {
                        ConsoleHost.left -= 1;
                        Console.Clear();
                        Draw(ConsoleHost.left, ConsoleHost.top);
                    }
                }
                else if (input.Key == ConsoleKey.D || input.Key == ConsoleKey.RightArrow)
                {
                    if (ConsoleHost.left + MinDistanceFromRightSide < Console.WindowWidth)
                    {
                        ConsoleHost.left += 1;
                        Console.Clear();
                        Draw(ConsoleHost.left, ConsoleHost.top);
                    }
                }
            }
        }
    }
}
