using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();
            List<char> result = new List<char>();
            for (int i = 0; i < numbers.Count; i++)
            {
                int index = 0;
                while (numbers[i] != 0)
                {
                    index += numbers[i] % 10;
                    numbers[i] /= 10;
                }
                while (index > text.Length-1 )  // 55 2 3 4 5  index 10 
                {
                    index -= text.Length;
                }
                result.Add(text[index]);
               text =  text.Remove(index, 1);
                
            }
            Console.WriteLine(string.Join("",result));

        }
    }
}
