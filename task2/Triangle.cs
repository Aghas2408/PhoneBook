using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Interfaces;

namespace task2
{
    public class Triangle : Shape
    {
        private const int TriangleSize = 10;
        private const int MinDistanceFromRightSide = 10;
        private string shapeName = "triangle";

        public override string ShapeName => shapeName;

        public override void Draw(int x, int y)
        {
            bool draw_top = false;
            bool draw_left = false;
            if (ConsoleHost.top - 1 >= 0 && ConsoleHost.top + 1 <= Console.WindowHeight)
            {
                draw_top = true;
            }
            if (ConsoleHost.left - 1 >= 0 && ConsoleHost.left + MinDistanceFromRightSide < Console.WindowWidth)
            {
                draw_left = true;
            }
            if (draw_top && draw_left)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                for (int i = 0; i < TriangleSize; i++)
                {
                    for (int j = 0; j < (x - i); j++)
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
        }
    }
}
