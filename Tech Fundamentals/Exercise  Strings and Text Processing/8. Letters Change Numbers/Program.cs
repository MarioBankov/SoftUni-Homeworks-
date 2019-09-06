using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            decimal bestNumber = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string data = input[i];
                char firstLetter = data.First();
                char secondLetter = data.Last();
                string numberAsSting = string.Empty;
                data = data.Remove(0, 1);
                data = data.Remove(data.Length - 1, 1);
                decimal number = decimal.Parse(data);

                if (char.IsLower(firstLetter))
                {
                    number *= (char.ToUpper(firstLetter)-64) ;
                }
                else
                {
                    number /= (char.ToUpper(firstLetter) - 64);
                }

                if (char.IsLower(secondLetter))
                {
                    number += (char.ToUpper(secondLetter) - 64);
                }
                else
                {
                    number -= (char.ToUpper(secondLetter) - 64);
                }


                bestNumber += number;
            }
            Console.WriteLine("{0:F2}",bestNumber);
        }
    }
}
