using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(code))
            {
                if (text.Contains(code))
                {
                  int index= text.IndexOf(code);
                 text =text.Remove(index,code.Length);
                }
            }
            Console.WriteLine(text);
          
        }
    }
}
