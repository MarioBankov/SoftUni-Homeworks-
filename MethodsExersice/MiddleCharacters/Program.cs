using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(TakesMiddleSymbols(text));
        }
        static string TakesMiddleSymbols(string text)
        {
            string result = string.Empty;

            if (text.Length % 2 == 1)
            {
                result = text[text.Length / 2] + "";
            }
            else
            {
               
                result =  text[text.Length / 2-1] + "";
                result = result + text[text.Length / 2] + "";

            }
            return result;

        }
    }
}
