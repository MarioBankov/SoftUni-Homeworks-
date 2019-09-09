using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public static  class Draw
    {
        private static int x = 48;
        private static int y = 2;

        static public void DrawScore(int score)
        {

            Console.SetCursorPosition(x, y);
            Console.Write(score);
        }
        static public void DrawLevel(int lv)
        {
            Console.SetCursorPosition(x - 7, y + 2);
            Console.Write(lv);
        }
    }
}
