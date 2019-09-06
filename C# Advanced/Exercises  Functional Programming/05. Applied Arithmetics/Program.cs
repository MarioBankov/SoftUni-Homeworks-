using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> add = x => x + 1;
            Func<int, int> subtract = x => x -1;
            Func<int, int> multiply = x => x * 2;
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (true)
            {
                string data = Console.ReadLine();
                if (data=="end")
                {
                    break;
                }
                else if (data=="add")
                {
                    numbers = numbers.Select(add).ToArray();
                }
                else if (data=="multiply")
                {
                  numbers= numbers.Select(multiply).ToArray();
                }
                else if (data=="subtract")
                {
                    numbers =numbers.Select(subtract).ToArray();
                }
                else if (data=="print")
                {
                    Console.WriteLine(string.Join(" ",numbers));
                }
            }
        }

       
    }
}
