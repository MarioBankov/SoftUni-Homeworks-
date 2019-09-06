using System;
using System.Linq;

namespace RoundingAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length; i++)
            {
                var number = double.Parse(input[i]);
              var rounded = Math.Round(double.Parse(input[i]), MidpointRounding.AwayFromZero);

                Console.WriteLine("{0} => {1}",number,rounded);
            }

           
            
        }

    }
}
