using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class Wall : Point
    {
        private const char wallSymbol = '\u25A0';
        public Wall(int left, int top)
            : base(left, top)
        {
            this.InitializeWallBorders();
        }
        private void InitializeWallBorders()
        {
            this.SetHorizantalLine(0);
            this.SetHorizantalLine(this.TopY);
            this.SetVerticalLine(0);
            this.SetVerticalLine(this.LeftX - 1);
            this.SetScore();

        }

        private void SetHorizantalLine(int TopY)
        {
            for (int leftX = 0; leftX < this.LeftX; leftX++)
            {
                this.Draw(leftX, TopY, wallSymbol);
            }
        }
        private void SetVerticalLine(int LeftX)
        {
            for (int topY = 0; topY < this.TopY; topY++)
            {
                this.Draw(LeftX, topY, wallSymbol);
            }
        }

        private void SetScore()
        {
            Console.SetCursorPosition(this.LeftX+5, this.TopY-this.TopY+2);
            Console.WriteLine("Player Score: ");
            Console.SetCursorPosition(this.LeftX + 5, this.TopY - this.TopY + 4);
            Console.WriteLine("Level:");
        }
        public bool isPointOfWall(Point snake)
        {
            return snake.TopY == 0
                 || snake.LeftX == 0
                 || snake.LeftX == this.LeftX - 1
                 || snake.TopY == this.TopY; 
        }
    }
}
