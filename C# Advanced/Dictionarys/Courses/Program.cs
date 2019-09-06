using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            var dic = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] tokens = input.Split(':');


                string couse = tokens[0];
                string course = couse.Remove(couse.Length - 1, 1);

                string student = tokens[1];

                if (!dic.ContainsKey(course))
                {
                    dic.Add(course, new List<string>());
                }
                dic[course].Add(student);
                counter++;

            }
            foreach (var item in dic.OrderByDescending(x => x.Value.Count))
            {

                Console.WriteLine("{0}: {1}", item.Key, item.Value.Count);
                foreach (var itemm in item.Value.OrderBy(x=>x))
                {
                    Console.WriteLine("--{0}",itemm);
                }
            }

        }
    }
}
