using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            GetClosest(x1, y1, x2, y2);
        }

        private static void GetClosest(double x1, double y1, double x2, double y2)
        {
            double hipotenuza1 = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            double hipotenuza2 = Math.Pow(x2, 2) + Math.Pow(y2, 2);
            if (hipotenuza1 <= hipotenuza2)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else 
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
        }
    }
}
