using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] data = Console.ReadLine().Split(" -> ");
                if (data[0] == "End")
                {
                    break;
                }
                string company = data[0];
                string employee = data[1];
                if (dic.ContainsKey(company) == false)
                {
                    dic.Add(company, new List<string>());
                    dic[company].Add(employee);
                }
                else
                {
                    if (dic[company].Contains(employee) == false)
                    {
                        dic[company].Add(employee);
                    }
                }

            }
            foreach (var item in dic.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var employee in item.Value)
                {
                    Console.WriteLine("-- {0}",employee);
                }


            }
        }
    }
}
