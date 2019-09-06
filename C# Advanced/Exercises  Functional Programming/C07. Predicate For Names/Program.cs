using System;
using System.Collections.Generic;
using System.Linq;

namespace C07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Predicate<string> checkLength = x => x.Length <= length;
            names = names.Where(x => checkLength(x)).ToList();
            Action<List<string>> Print = x => Console.WriteLine(string.Join(Environment.NewLine,x));
            Print(names);
        }
    }
}
