using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            Random rng = new Random();
            for (int i = 0; i < words.Count; i++)
            {
                var ri = rng.Next(0, words.Count);
                var tempValue = words[i];
                words[i] = words[ri];
                words[ri] = tempValue;
            }
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
