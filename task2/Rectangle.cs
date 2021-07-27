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
        private const string TopLeft = "╔";
        private const string TopRight = "╗";
        private const string BotLeft = "╚";
        private const string BotRight = "╝";
        private const string HorizontalElement = "═";
        private const string VerticalElement = "║";
        private const int RectangleSideSize = 5;
        private const int MinDistanceFromRightSide = 8;
        private string shapeName = "rectangle";

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
                string s = TopLeft;
                string space = "";
                string first_space = "";
                for (int i = 0; i < RectangleSideSize; i++)
                {
                    space += " ";
                    s += HorizontalElement;
                }
                for (int i = 0; i < x; i++)
                {
                    first_space += " ";
                }
                s += TopRight + "\n";
                for (int i = 0; i < RectangleSideSize; i++)
                {
                    s += first_space + VerticalElement + space + VerticalElement + "\n";
                }
                s += first_space + BotLeft;
                for (int i = 0; i < RectangleSideSize; i++)
                {
                    s += HorizontalElement;
                }
                s += BotRight + "\n";
                Console.Write(s);
            }
        }
    }
}
