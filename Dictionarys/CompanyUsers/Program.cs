using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var users =new  Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="End")
                {
                    break;
                }
                string[] tokens = input.Split();
                string companyName = tokens[0];
                string employeeId = tokens[2];

                if (users.ContainsKey(companyName)==false)
                {
                    users.Add(companyName, new List<string>());
                }
                if (users[companyName].Contains(employeeId)==false)
                {
                    users[companyName].Add(employeeId);
                }
                
            }
            foreach (var item in users.OrderBy(x=>x.Key))
            {
                Console.WriteLine("{0}",item.Key);
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine("-- {0}", item.Value[i]);
                }
                
                 

                
            }
        }
    }
}
