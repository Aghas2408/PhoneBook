using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
   
    public static class ConsoleHost
    {
        const int FromCenterToLeft = 5;
        const int FromCenterToTop = 5;
        public static int left = Console.WindowWidth / 2 - FromCenterToLeft;
        public static int top  = Console.WindowHeight / 2 - FromCenterToTop;
       
        public static void Run()
        {
            const string  ShapeName = "rectangle";
            Console.WriteLine("Hello, What shape do you want to Draw");
            var input = Console.ReadLine();
            if (Validator.validateFirstInput(input))
            {

                Colors.DisplayColors();
                var inputColor = Console.ReadLine();
                if (Validator.validateColorInput(inputColor))
                {
                    Console.Clear();
                    ChangeConsoleColor obj = new ChangeConsoleColor();
                    obj.ChangeColor(inputColor);
                    if (input.ToLower() == ShapeName)
                    {
                        Rectangle ob = new Rectangle();
                        ob.Draw(left,top);
                        ob.Move();
                    }
                    else
                    {
                        left += FromCenterToLeft;
                        top += FromCenterToTop;
                        Triangle ob = new Triangle();
                        ob.Draw(left, top);
                        ob.Move();
                    }


                }
                else
                    Console.WriteLine("Invalid Color, Please try again");
            }
            else
            {
                Console.WriteLine("Invalid Shape, Please try again");
            }
        }
    }
}
