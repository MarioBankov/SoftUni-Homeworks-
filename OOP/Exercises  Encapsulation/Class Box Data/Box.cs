using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Box_Data
{
   public  class Box
    {
        private double lenght;
        private double width;
        private double height;
        public Box(double lenght, double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Heigth = height;
        }
        public double Lenght
        {
            get => lenght;
            set
            {
                if (value<1)
                {
                    throw new ArgumentException("Lenght cannot be zero or negative.");
                }
                lenght = value;
            }
        }
        public double Width
        {
            get => width;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }
        public double Heigth
        {
            get => height;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Heigth cannot be zero or negative.");
                }
                height = value;
            }
        }
        //Lateral Surface Area = 2lh + 2wh
       // Surface Area = 2lw + 2lh + 2wh
       public double LiteralSurfaceArea()
        {
            return (2 * lenght * height) + (2 * width * height);
        }
        public double SurfaceArea()
        {
            return (2 * lenght * width) + (2 * lenght * height) + (2 * width * height);
        }
        public double Volume()
        {
            return lenght * height * width;
        }
    }
}
