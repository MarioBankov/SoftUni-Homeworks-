using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01P
{
    class Program
    {
        Dictionary<string,List<string>> dic = new Dictionary<string, List<string>>();
        static void Main(string[] args)
        {
            while (true)
            {


                Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
                string input = Console.ReadLine();
                string[] words = Regex.Split(input, @"\| ");

                for (int i = 0; i < words.Length; i++)
                {
                    string[] elements = Regex.Split(words[i], @"\: ");
                    if (!dic.ContainsKey(elements[0]))
                    {
                        dic.Add(elements[0], new List<string>());
                        dic[elements[0]].Add(elements[1]);
                    }
                    else
                    {
                        dic[elements[0]].Add(elements[1]);
                    }
                }
                string words1 = Console.ReadLine();
                string[] words12 = Regex.Split(words1, @"\ | ");
               
                string lastcommand = Console.ReadLine();
                if (lastcommand == "End")
                {
                    foreach (var item in words12)
                    {
                        if (dic.ContainsKey(item))
                        {
                            Console.WriteLine(item);
                            foreach (var itemm in dic[item].OrderByDescending(x => x.Length))
                            {
                                Console.WriteLine(" -{0}", itemm);
                            }
                        }
                    }
                    break;
                }
                else
                {
                    foreach (var item in dic.OrderBy(x => x.Key))
                    {
                        Console.Write("{0} ", item.Key);
                    }
                   break;
                }
            }
        }
    }
}