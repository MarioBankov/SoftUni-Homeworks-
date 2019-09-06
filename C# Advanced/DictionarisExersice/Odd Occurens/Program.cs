using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurens
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().ToLower().Split().ToList();
            var dic = new  Dictionary<string, int>();
            for (int i = 0; i < words.Count; i++)
            {
                if (dic.ContainsKey(words[i])==false)
                {
                    dic.Add(words[i], 0);
                }
                dic[words[i]] += 1;
            }
            var a = dic.Where(x => x.Value % 2 == 1);
            foreach (var item in a)
            {
               // if (item.Value%2==1)
               // {
                    Console.Write(item.Key + " ");
               // }
                
            }
        }
    }
}
