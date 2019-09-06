    using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int stundentCount = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<double>>();
            for (int i = 0; i < stundentCount; i++)
            {
                string[] entry = Console.ReadLine().Split();
                string name = entry.First();
                double grade = double.Parse(entry.Last());
                if (dict.ContainsKey(name)==false)
                {
                    dict.Add(name, new List<double>());
                }
                dict[name].Add(grade);
            }
            foreach (var item in dict)
            {
                var a = item.Value;
              var b= a.Select(x =>$"{x:f2}");
                Console.WriteLine("{0} -> {1:f2} (avg: {2:F2})",item.Key,string.Join(" ",b),item.Value.Average());
            }
        }
    }
}
