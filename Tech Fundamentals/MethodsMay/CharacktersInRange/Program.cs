using System;

namespace CharacktersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            Print(start,end);
        }

        private static void Print(char start, char end)
        {
            if (start>end)
            {
                for (int i = end+1; i < start; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = start + 1; i < end; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            
        }
    }
}
