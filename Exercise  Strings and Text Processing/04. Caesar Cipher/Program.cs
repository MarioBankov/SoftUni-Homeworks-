using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var a = text.Select(x => x + 3);
            foreach (var item in a)
            {
                Console.Write((char)item);
            }
        }
    }
}
