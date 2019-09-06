using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintVowelSum(text);
        }
        private static void PrintVowelSum(string text)
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u','A','E','I','O','U'};

            int total = text.Count(vowels.Contains);
            Console.WriteLine(total);
        }
    }
}
