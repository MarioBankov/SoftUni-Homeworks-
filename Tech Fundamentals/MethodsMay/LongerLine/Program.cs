using System;
class Program
{
    static void Main(string[] args)
    {
        double point1X = double.Parse(Console.ReadLine());
        double point1Y = double.Parse(Console.ReadLine());
        double point2X = double.Parse(Console.ReadLine());
        double point2Y = double.Parse(Console.ReadLine());
        double point3x = double.Parse(Console.ReadLine());
        double point3Y = double.Parse(Console.ReadLine());
        double point4X = double.Parse(Console.ReadLine());
        double point4Y = double.Parse(Console.ReadLine());

        double firstLineLenth = GetLineLenth(point1X, point1Y, point2X, point2Y);
        double secondLineLenth = GetLineLenth(point3x, point3Y, point4X, point4Y);
        if (firstLineLenth>secondLineLenth)
        {
            PrintClosestPoint(point1X, point1Y, point2X, point2Y);
        }
        else
        {
            PrintClosestPoint(point3x, point3Y, point4X, point4Y);
        }
        

    }

    private static void PrintClosestPoint(double point1X, double point1Y, double point2X, double point2Y)
    {
        double firstPoint = Math.Pow(point1X, 2) + Math.Pow(point1Y, 2);
        double secondPoint = Math.Pow(point2X, 2) + Math.Pow(point2Y, 2);
        if (firstPoint<=secondPoint)
        {
            Console.WriteLine("({0}, {1})({2}, {3})",point1X,point1Y,point2X,point2Y);
        }
        else
        {
         Console.WriteLine("({0}, {1})({2}, {3})",  point2X, point2Y, point1X, point1Y);
        }
    }

    private static double GetLineLenth(double point1X, double point1Y, double point2X, double point2Y)
    {
       double lenth= Math.Sqrt( Math.Pow((point2X - point1X), 2) + Math.Pow((point2Y - point1Y), 2));
        return lenth;
    }
}