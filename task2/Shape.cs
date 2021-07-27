using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public abstract class Shape : IDraw
    {
        public abstract  string ShapeName { get; }
        public abstract void Draw(int x, int y);

        public void Move()
        {
            while (true)
            {
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.W || input.Key == ConsoleKey.UpArrow)
                {
                    ConsoleHost.top -= 1;
                    Draw(ConsoleHost.left, ConsoleHost.top);
                }
                else if (input.Key == ConsoleKey.S || input.Key == ConsoleKey.DownArrow)
                {
                    ConsoleHost.top += 1;
                    Draw(ConsoleHost.left, ConsoleHost.top);
                }
                else if (input.Key == ConsoleKey.A || input.Key == ConsoleKey.LeftArrow)
                {
                    ConsoleHost.left -= 1;
                    Draw(ConsoleHost.left, ConsoleHost.top);
                }
                else if (input.Key == ConsoleKey.D || input.Key == ConsoleKey.RightArrow)
                {
                    ConsoleHost.left += 1;
                    Draw(ConsoleHost.left, ConsoleHost.top);
                }
            }
        }
    }
}
