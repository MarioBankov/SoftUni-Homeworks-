using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]>a&&text[i]<b)
                {
                    sum += text[i];
                }
            }
            Console.WriteLine(sum);
            
        }
    }
}
