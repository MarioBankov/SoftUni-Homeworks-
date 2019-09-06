using System;
using System.Collections.Generic;
using System.Linq;

namespace WordSynoyms
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
                string synonym = Console.ReadLine();
                if (dic.ContainsKey(word)==false)
                {
                    dic.Add(word, new List<string>());
                    dic[word].Add(synonym);
                }
                else
                {
                    if (dic[word].Contains(synonym)==false)
                    {
                        dic[word].Add(synonym);
                    }
                    
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine("{0} - {1}",item.Key,string.Join(", ",item.Value));
                
            }
        }
    }
}
