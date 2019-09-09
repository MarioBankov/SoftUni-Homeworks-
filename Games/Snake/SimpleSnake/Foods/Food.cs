using SimpleSnake.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSnake.Foods
{

    public abstract class Food : Point
    {
        private Wall wall;
        private char foodSymbol;
        private Random random;

        public Food(Wall wall, char foodSymbol, int points)
        : base(wall.LeftX, wall.TopY)
        {
            this.wall = wall;
            this.FoodPoints = points;
            this.foodSymbol = foodSymbol;
            this.random = new Random();
        }

        public int FoodPoints { get; set; }

        public bool isFoodPoint(Point snakeHead)
        {
            return this.LeftX == snakeHead.LeftX && this.TopY == snakeHead.TopY;
        }
        public void SetRandomPosition(Queue<Point> snakeElements)
        {
            this.LeftX = this.random.Next(2, wall.LeftX - 1);
            this.TopY = this.random.Next(2, wall.TopY - 1);

            bool isPointOnSnake = snakeElements.Any(p => p.LeftX == LeftX && p.TopY == TopY);

            while (isPointOnSnake)
            {
                this.LeftX = this.random.Next(2, wall.LeftX - 2);
                this.TopY = this.random.Next(2, wall.TopY - 2);
                isPointOnSnake = snakeElements.Any(p => p.LeftX == LeftX && p.TopY == TopY);
            }

            Console.BackgroundColor = ConsoleColor.Red;
            this.Draw(foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;

        }
    }
}
