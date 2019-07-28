using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList().Where(x => x.Length % 2 == 1).ToList();
            Console.WriteLine(string.Join(" ",words));
        }
    }
}
