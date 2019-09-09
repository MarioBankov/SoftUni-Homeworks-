using SimpleSnake.Enums;
using SimpleSnake.GameObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SimpleSnake.Core
{
    public class Engine
    {
        private Point[] pointsOfDirections;
        private Direction direction;
        private Snake snake;
        private Wall wall;
        private int currentLevel = 1;
        private int boost = 1;
        

        private double sleepTime;

        public Engine(Wall wall, Snake snake)
        {
            this.wall = wall;
            this.snake = snake;
            this.pointsOfDirections = new Point[4];
            this.sleepTime = 100; 
            
        }

        public void Run()
        {
            this.CreateDirections();

            while (true)
            {
                Score score = new Score();
                Draw.DrawScore(snake.Score.PlayerScore);
                Draw.DrawLevel(snake.Score.Level);
                if (Console.KeyAvailable)
                {
                    this.GetNextDirection();
                }
                bool isMoving = this.snake.IsMoving(this.pointsOfDirections[(int)this.direction]);


                if (!isMoving)
                {
                    this.AskUserForRestard();
                }
                if (snake.Score.Level== this.currentLevel)
                {
                    this.currentLevel++;
                    sleepTime -= 10;
                }
                

                Thread.Sleep((int)sleepTime); // slow down the game :)
                
                snake.Score.PlayerScore += boost;
            }
        }

        private void AskUserForRestard()
        {
            int leftX = this.wall.LeftX + 1;
            int topY = 3;
            Console.SetCursorPosition(leftX, topY);
            Console.Write("Would you like to coninue y/n");
            string input = Console.ReadLine();

            if (input=="y")
            {
                Console.Clear();
                StartUp.Main();
            }
            else if (input=="n")
            {
                this.StopGame();
            }
        }

        private void StopGame()
        {
            Console.SetCursorPosition(10, 10);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("GameOver");
            Console.BackgroundColor = ConsoleColor.White;
            Environment.Exit(0);
        }

        private void GetNextDirection()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            if (userInput.Key == ConsoleKey.LeftArrow)
            {
                if (this.direction!=Direction.Right)
                {
                    this.direction = Direction.Left;
                }
            }
            else if (userInput.Key==ConsoleKey.RightArrow)
            {
                if (this.direction!=Direction.Left)
                {
                    this.direction = Direction.Right;
                }
            }
            else if (userInput.Key==ConsoleKey.UpArrow)
            {
                if (this.direction!=Direction.Down)
                {
                    this.direction = Direction.Up;
                }
            }
            else if (userInput.Key==ConsoleKey.DownArrow)
            {
                if (direction!=Direction.Up)
                {
                    direction = Direction.Down;
                }
            }
            Console.CursorVisible = false;
        }
        private void CreateDirections()
        {
            this.pointsOfDirections[0] = new Point(1,0);
            this.pointsOfDirections[1] = new Point(-1,0);
            this.pointsOfDirections[2] = new Point(0,1);
            this.pointsOfDirections[3] = new Point(0,-1);
        }
    }
}
