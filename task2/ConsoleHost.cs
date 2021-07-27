using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public static class ConsoleHost
    {
        private const int FromCenterToLeft = 5;
        private const int FromCenterToTop = 5;
        public static int left = Console.WindowWidth / 2 - FromCenterToLeft;
        public static int top = Console.WindowHeight / 2 - FromCenterToTop;
        public static Shape[] shapes = new Shape[] { new Rectangle(), new Triangle() };

        public static void Run()
        {
            Console.WriteLine("Hello, What shape do you want to Draw");
            var input = Console.ReadLine();
            if (Validator.ValidateFirstInput(input))
            {
                Colors.DisplayColors();
                var inputColor = Console.ReadLine();
                if (Validator.ValidateColorInput(inputColor))
                {
                    Console.Clear();
                    ChangeConsoleColor colorChange = new ChangeConsoleColor();
                    colorChange.ChangeColor(inputColor);
                    var shape = shapes.Where(i => i.ShapeName == input).FirstOrDefault();
                    shape.Draw(left, top);
                    shape.Move();
                }
                else
                {
                    Console.WriteLine("Invalid Color, Please try again");
                }
            }
            else
            {
                Console.WriteLine("Invalid Shape, Please try again");
            }
        }
    }
}
