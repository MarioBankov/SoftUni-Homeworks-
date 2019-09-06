using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]==' ')
                {
                    continue;
                }
                if (dic.ContainsKey(text[i])==false)
                {
                    dic.Add(text[i], 0);
                }
                dic[text[i]] += 1;
            }
            foreach (var item in dic)
            {
               
                Console.WriteLine("{0} -> {1}",item.Key,item.Value);
            }
        }
    }
}
