using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int power = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    power = int.Parse(text[i + 1].ToString())+power;
                    while (power!=0&&i+1<text.Length)
                    {
                        if (text[i+1]=='>')
                        {
                            break;
                        }
                        text = text.Remove(i + 1, 1);
                        power--;
                    }
                }

            }
            Console.WriteLine(text);
        }
    }
}
