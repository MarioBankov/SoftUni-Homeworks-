using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] data = Console.ReadLine().Split(" : ");
                if ( data[0] =="end")
                {
                    break;
                }

                string course = data[0];
                string student = data[1];
                if (dic.ContainsKey(course) == false)
                {
                    dic.Add(course, new List<string>());
                    dic[course].Add(student);
                }
                else
                {
                    if (dic[course].Contains(student)==false)
                    {
                        dic[course].Add(student);
                    }
                }
            }
            foreach (var item in dic.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine("{0}: {1}",item.Key,item.Value.Count);
                foreach (var student  in item.Value.OrderBy(x=>x))
                {
                    Console.WriteLine("-- {0}",string.Join("\n",student));
                }
            }
        }
    }
}
