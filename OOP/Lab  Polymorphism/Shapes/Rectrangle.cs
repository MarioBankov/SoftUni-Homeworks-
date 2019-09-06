using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectrangle:Shape
    {
      
        public Rectrangle(double height,double width)
        {
            this.Height = height;
            this.Width = width;
        }
        public double Height { get; private set; }
        public double Width { get; private set; }
        
        public override double CalculatePerimeter()
        {
            return 2 * (Height + Width);
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override string Draw()
        {
            var sb = new StringBuilder();
            sb.AppendLine(new string('*', (int)Width));
            for (int i = 0; i < Height-2; i++)
            {
                sb.AppendLine($"*{new string(' ', (int)Width - 2)}*");
            }
            sb.AppendLine(new string('*', (int)Width));
            return sb.ToString().TrimEnd();
        }


    }
}
