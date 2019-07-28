using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = string.Empty;
            for (int i = 0; i < text.Length-1; i++)
            {
                  char first   = text[i];
                char second = text[i + 1];
                if (first!=second )
                {
                    result += first;
                }
                if (i==text.Length-2&& first != second)
                {
                    result += second;
                }
                
            }
            Console.WriteLine(result);

        }
    }
}
