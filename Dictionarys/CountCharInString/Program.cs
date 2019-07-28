using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCharInString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            var dic = new Dictionary<char, int>();
            for (int i = 0; i < words.Count; i++)
            {
                string currentWord = words[i];
                for (int j = 0; j < currentWord.Length; j++)
                {
                    if (!dic.ContainsKey(currentWord[j]))
                    {
                        dic.Add(currentWord[j], 0);
                    }
                   
                        dic[currentWord[j]]++;
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine("{0}->{1}",item.Key,item.Value);
            }
        }
    }
}
