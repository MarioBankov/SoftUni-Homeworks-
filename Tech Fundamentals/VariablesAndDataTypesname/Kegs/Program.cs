using System;

namespace Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string bestKeg = string.Empty;
            double bestVolume = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;
                if (volume>bestVolume)
                {
                    bestVolume = volume;
                    bestKeg = model;
                }



            }
            Console.WriteLine(bestKeg);
        }
    }
}
