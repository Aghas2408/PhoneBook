using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Interfaces;

namespace task2
{
    class Triangle : ITriangle, IMovableTriangle
	{
        public void drawTriangle(int w, int h)
        {
			Console.SetCursorPosition(w, h);
			for (int i = 0; i < 10; i++)
			{

				for (int j = 0; j <(w  - i); j++)
					Console.Write(" ");
				
				for (int k = 1; k < i * 2; k++)
					Console.Write("*");
				
				Console.WriteLine();
			}

		}

        public void moveTriangle()
        {
            while (true)
            {
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.W)
                {

                    if (ConsoleHost.top - 1 >= 0)
                    {
                        ConsoleHost.top -= 1;
                        Console.Clear();
                        drawTriangle(ConsoleHost.left, ConsoleHost.top);
                    }

                }
                if (input.Key == ConsoleKey.S)
                {
                    if (ConsoleHost.top + 1 <= Console.BufferHeight)
                    {
                        ConsoleHost.top += 1;
                        Console.Clear();
                        drawTriangle(ConsoleHost.left, ConsoleHost.top);
                    }
                }
                if (input.Key == ConsoleKey.A)
                {
                    if (ConsoleHost.left - 5 >= 0)
                    {
                        ConsoleHost.left -= 1;
                        Console.Clear();
                        drawTriangle(ConsoleHost.left, ConsoleHost.top);
                    }
                }
                if (input.Key == ConsoleKey.D)
                {
                    if (ConsoleHost.left + 5 <= Console.BufferWidth)
                    {
                        ConsoleHost.left += 1;
                        Console.Clear();
                        drawTriangle(ConsoleHost.left, ConsoleHost.top);
                    }
                }
            }
        }
    }
}
