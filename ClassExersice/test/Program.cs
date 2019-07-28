using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Toni->Toni is the best";
            string[] split = Regex.Split(text, @"\->");
            Console.WriteLine(string.Join(" ",split));
        }
    }
}
