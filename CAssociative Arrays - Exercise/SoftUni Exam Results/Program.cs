using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, Dictionary<string, int>>();
            var sub = new Dictionary<string, int>();

            while (true)
            {
                string data = Console.ReadLine();
                if (data=="exam finished")
                {
                    break;
                }
                string[] info = data.Split("-");
                if (info.Last()=="banned")
                {
                    if (dic.ContainsKey(info.First()))
                    {
                        dic.Remove(info.First());
                    }
                }
                else
                {
                    string name = info[0];
                    string language = info[1];
                    int points = int.Parse(info[2]);
                    if (sub.ContainsKey(language)==false)
                    {
                        sub.Add(language, 0);
                    }
                    sub[language] += 1;
                    if (dic.ContainsKey(name)&& dic[name].ContainsKey(language))
                    {
                        if (dic[name][language]<points)
                        {
                            dic[name][language] = points;
                        }
                    }
                    else if (dic.ContainsKey(name) && dic[name].ContainsKey(language)==false)
                    {
                        dic[name].Add(language, points);
                    }
                    else
                    {
                        dic.Add(name, new Dictionary<string, int>());
                        dic[name].Add(language, points);
                    }
                }
            }
            
            dic =  dic.OrderByDescending(x => x.Value.Values.Max()).ThenBy(n=>n.Key).ToDictionary(x => x.Key,
                                         x => x.Value.OrderByDescending(y => y.Value).ToDictionary(y => y.Key, y => y.Value));
            Console.WriteLine("Results:");
            foreach (var item in dic)
            {
                
                Console.WriteLine("{0} | {1}", item.Key, item.Value.Values.Max());
            }
            Console.WriteLine("Submissions: ");
            foreach (var item in sub.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine("{0} - {1}",item.Key,item.Value);
            }
        }
    }
}
