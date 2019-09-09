using SimpleSnake.Foods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSnake.GameObjects
{
    public class Snake
    {
        private Queue<Point> snakeElements;
        private Food[] foods;
        private Wall wall;
        
        private int nextLeftX;
        private int nextTopY;
        private const char snakeSymbol = '\u25CF'; //U+25CF
        private int foodIndex;

        

        public Snake(Wall wall,Score score)
        {
            this.wall = wall;
            this.foods = new Food[3];
            this.snakeElements = new Queue<Point>();
            this.foodIndex = this.RandomFoodNumber;

            this.GetFoods();
            this.CreateSnake();
            this.Score = score;

        }
        public int RandomFoodNumber => new Random().Next(0, this.foods.Length);
        public Score Score { get; set; }

        private void CreateSnake()
        {
            for (int topY = 1; topY <= 6; topY++)
            {
                Point point = new Point(2, topY);
                this.snakeElements.Enqueue(point);
                point.Draw(snakeSymbol);
                
            }
            this.foods[this.foodIndex].SetRandomPosition(this.snakeElements);
        }
        
        public bool IsMoving(Point direction)
        {
            Point snakeHead = this.snakeElements.Last();
            this.GetNextPoint(direction, snakeHead);

            bool isPointOfSnake = this.snakeElements.Any(p => p.LeftX == this.nextLeftX && p.TopY == this.nextTopY);
            if (isPointOfSnake)
            {
                return false;
            }
            Point snakeNewHead = new Point(this.nextLeftX, this.nextTopY);
            if (this.wall.isPointOfWall(snakeNewHead))
            {
                return false;
            }
            this.snakeElements.Enqueue(snakeNewHead);
            snakeNewHead.Draw(snakeSymbol);

            if (this.foods[foodIndex].isFoodPoint(snakeNewHead))
            {
                this.Eat(direction, snakeHead);
            }

            Point snakeTail = this.snakeElements.Dequeue();
            snakeTail.Draw(' ');
            return true;
        }
        private void GetNextPoint(Point direction,Point snakeHead)
        {
            this.nextLeftX = snakeHead.LeftX + direction.LeftX;
            this.nextTopY = snakeHead.TopY + direction.TopY;
        }
        
        public void Eat(Point direction,Point currentSnakeHead)
        {
            int lenght = this.foods[foodIndex].FoodPoints;
            Score.PlayerScore += lenght * 100;
            for (int i = 0; i < lenght; i++)
            {
                this.snakeElements.Enqueue(new Point(this.nextLeftX, this.nextTopY));
                GetNextPoint(direction, currentSnakeHead); 
            }
            this.foodIndex = this.RandomFoodNumber;
            this.foods[foodIndex].SetRandomPosition(this.snakeElements);
        }
        
        private void GetFoods()
        {
            this.foods[0] = new FoodAsterisk(this.wall);
            this.foods[1] = new FoodDollar(this.wall);
            this.foods[2] = new FoodHesh(this.wall);
        }
    }
}
