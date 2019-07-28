using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b     = double.Parse(Console.ReadLine());

            double area = GetRectangleArea(a, b);
            Console.WriteLine(area);
        }
        static double GetRectangleArea(double width, double height)
        {

            return width*height;
        }
    }
}
