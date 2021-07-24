using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
   
    public static class ConsoleHost
    {
        public static int left = Console.WindowWidth / 2 - 5;
        public static int top  = Console.WindowHeight / 2 - 5;
        public static void Run()
        {
          
            Console.WriteLine("Hello, What shape do you want to Draw");
            var input = Console.ReadLine();
            if (Validator.validateFirstInput(input))
            {
                
                Console.WriteLine("What Color do you like to use for shape ?");
                Console.WriteLine("You can choose one of these");
                Console.WriteLine(" White, Blue, Red, Green, Azure, Gray, Gold, Lime, Olive, Orange, Purple, Silver");
                var inputColor = Console.ReadLine();
                if (Validator.validateColorInput(inputColor))
                {
                    Console.Clear();
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), inputColor, true);
                    if (input.ToLower() == "rectangle")
                    {
                        Rectangle ob = new Rectangle();
                        ob.drawRectangle(left,top);
                        ob.moveRectangle();
                    }
                    else
                    {
                        left += 5;
                        top += 5;
                        Triangle ob = new Triangle();
                        ob.drawTriangle(left, top);
                        ob.moveTriangle();
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
