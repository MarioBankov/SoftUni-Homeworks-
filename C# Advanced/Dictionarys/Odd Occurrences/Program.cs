using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            var dic = new Dictionary<string, int>();

            foreach (var item in words)
            {
                string word = item.ToLower();
                if (!dic.ContainsKey(word))
                {
                    dic.Add(word, 1);
                }
                else
                {
                    dic[word]++;
                }
            }
            foreach (var item in dic)
            {
                if (item.Value%2==1)
                {
                    Console.Write(item.Key+" ");
                }
            }
            Console.WriteLine();
        }
    }
}
