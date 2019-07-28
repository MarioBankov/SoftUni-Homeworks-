using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepatString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Repeat("text",3));
        }
        static string Repeat(string text, int count)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                result += text;
            }
            return result;
        }
    }
}
