using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = w => w[0] == w.ToUpper()[0];
            Console.WriteLine(string.Join(Environment.NewLine,Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Where(checker)));
        }
    }
}
