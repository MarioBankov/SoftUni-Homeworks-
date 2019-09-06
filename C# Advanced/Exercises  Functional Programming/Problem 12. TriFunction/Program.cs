using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Func<string, int, bool> IsLarger = (name, number) => name.Sum(x => x) >= number;

            Func<string[],Func<string, int, bool>, string> Filter = (allNames,function)
                => allNames.FirstOrDefault(selectetName => function(selectetName, n));

            string result = Filter(names, IsLarger);
            Console.WriteLine(result);
            
        }
    }
}
