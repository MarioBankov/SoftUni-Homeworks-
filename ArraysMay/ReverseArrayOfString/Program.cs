using System;

namespace ReverseArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            string[] reversed = new string[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                reversed[i] = text[text.Length - 1 - i];
            }
            Console.WriteLine(string.Join(" ",reversed));
        }
    }
}
