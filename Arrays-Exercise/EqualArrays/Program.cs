using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string result = string.Empty;
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i]!=second[i])
                {
                    result = $"Arrays are not identical. Found difference at {i} index";
                    break;
                }
              
            }
            if (result==string.Empty)
            {
                Console.WriteLine("Arrays are identical. Sum: {0}",first.Sum());
            }
            else
            {
                Console.WriteLine(result);
            }

        }
    }
}
