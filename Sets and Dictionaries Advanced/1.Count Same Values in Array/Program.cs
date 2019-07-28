using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<double, int>();
            double[] numberts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            for (int i = 0; i < numberts.Length; i++)
            {
                double number = numberts[i];
                if (dict.ContainsKey(number)==false)
                {
                    dict.Add(number, 0);
                }
                dict[number]++;
            }
            foreach (var number in dict)
            {
                Console.WriteLine("{0} - {1} times", number.Key,number.Value);
            }
        }
    }
}
