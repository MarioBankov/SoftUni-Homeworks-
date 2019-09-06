using System;
using System.Text.RegularExpressions;

namespace _1._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

           var  matches = regex.Matches(text);
            foreach (var item in matches)
            {
                Console.Write(item+" ");
            }
        }
    }
}
