using System;

namespace MiddleChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string midChar = GetMidChars(text);
            Console.WriteLine(midChar);
        }

        private static string GetMidChars(string text)
        {
            if (text.Length%2==1)
            {
                return text[text.Length / 2].ToString();
            }
            else
            {
                return text[text.Length / 2 - 1] + text[text.Length / 2].ToString();
            }
        }
    }
}
