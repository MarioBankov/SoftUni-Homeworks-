using System;
using System.Collections.Generic;
using System.Text;
using SimpleSnake.GameObjects;

namespace SimpleSnake.Foods
{
    public class FoodAsterisk : Food
    {
        private const char foodSymbol = '*';
        private const int points = 1;
        public FoodAsterisk(Wall wall) 
            : base(wall, foodSymbol, points)
        {

        }
    }
}
