using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dic = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string syn = Console.ReadLine();

                if (!dic.ContainsKey(word))
                {
                    dic.Add(word, new List<string>());
                }
                dic[word].Add(syn);
            }
            foreach (var item in dic)
            {
                Console.WriteLine("{0}-{1}",item.Key,string.Join(",",item.Value));
            }

        }
    }
}
