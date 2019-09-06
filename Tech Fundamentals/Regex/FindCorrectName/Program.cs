using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindCorrectName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan Ivanov";
            string[] names = input.Split(new[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < names.Length; i+=2)
            {
                string name = names[i] + " " + names[i + 1];
                string regex = @"^[A-Z][a-z]+ [A-Z][a-z]+";
                if (Regex.IsMatch(name,regex))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
