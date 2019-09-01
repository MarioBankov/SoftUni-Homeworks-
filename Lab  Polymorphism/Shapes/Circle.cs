using System;
using System.Text;

namespace Shapes
{
    public class Circle:Shape
    {
        public int Radius { get; private set; }
        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override string Draw()
        {
            var sb = new StringBuilder();
            double r_in = Radius - 0.4;
            double r_out = Radius + 0.4;

            for (double y = Radius; y >= -Radius; --y)
            {
                for (double x = -Radius; x < r_out; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= r_in * r_in && value <= r_out * r_out)
                    {
                        sb.Append("*");
                    }
                    else if (value < r_in * r_in && value < r_out * r_out)
                    {
                        sb.Append("*");
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }
                sb.AppendLine();
            }

            return sb.ToString().TrimEnd();
        }
    }
}
