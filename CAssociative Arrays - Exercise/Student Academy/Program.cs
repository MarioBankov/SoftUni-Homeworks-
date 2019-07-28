using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if ( dic.ContainsKey(name)==false)
                {
                    dic.Add(name, new List<double>());
                    dic[name].Add(grade);
                }
                else
                {
                    dic[name].Add(grade);
                }
            }
           
            foreach (var item in dic.OrderByDescending(x=>x.Value.Average()))
            {
                if (item.Value.Average()<4.50)
                {
                    continue;
                }
                Console.WriteLine("{0} -> {1:f2}",item.Key,item.Value.Average());
            }
        }
    }
}
