using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var a = text.Where(x => char.IsDigit(x));
            var b = text.Where(x => char.IsLetter(x));
            var c = text.Where(x => !char.IsDigit(x) && !char.IsLetter(x));
            Console.WriteLine(string.Join("",a));
            Console.WriteLine(string.Join("", b));
            Console.WriteLine(string.Join("", c));
        }
    }
}
