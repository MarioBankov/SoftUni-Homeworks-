using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]<0)
                {
                    numbers.RemoveAt(i);
                    i = -1;
                }
            }
            if (numbers.Count==0)
            {
                Console.WriteLine("empty");
            }

            numbers.Reverse();
            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
