using System;

namespace DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < numberOfLines; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                message += (char)(symbol + key);

            }
            Console.WriteLine(message);
        }
    }
}
