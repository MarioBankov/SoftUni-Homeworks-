using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            double sumSecond = 0;
            double sumFirst = 0;
            for (int i = 0; i < numbers.Count/2; i++)
            {
                if (numbers[i]!=0)
                {
                    sumFirst += numbers[i];
                }
                else
                {
                    sumFirst = sumFirst * 0.8;
                }
            }
            for (int i = numbers.Count-1; i > numbers.Count / 2; i--)
            {
                if (numbers[i] != 0)
                {
                    sumSecond += numbers[i];
                }
                else
                {
                    sumSecond = sumSecond * 0.8;
                }
            }
            if (sumFirst>sumSecond)
            {
                Console.WriteLine("The winner is right with total time: {0}",sumSecond);
            }
            else
            {
                Console.WriteLine("The winner is left with total time: {0}", sumFirst);
            }
        }
    }
}
