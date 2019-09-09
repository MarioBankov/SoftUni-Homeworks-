using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class Point
    {
        public int LeftX { get; set; }
        public int TopY { get; set; }
        public Point(int left ,int top)
        {
            this.TopY = top;
            this.LeftX = left;
        }

        public void Draw(char symbol)
        {
            Console.SetCursorPosition(LeftX, TopY);
            Console.Write(symbol);
        }
        public void Draw(int left,int top,char symbol)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(symbol);
        }
        
    }
}
