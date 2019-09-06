using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowWhite
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var dwarfs = new Dictionary<string,int>();
          
            while (true)
            {
                List<string> input = Console.ReadLine()
                    .Split(new char[] { ' ','<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (input[0] == "Once")
                {
                    break;
                }
                string name = "("+input[1]+")"+" "+input[0];
                int str = int.Parse(input[2]);
               
                if (!dwarfs.ContainsKey(name))
                {
                    dwarfs.Add(name, str);
                }
                else
                {
                    if (dwarfs[name]<str)
                    {
                        dwarfs[name] = str;
                    }
                }

                
               
            }
            foreach (var item in dwarfs.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} <-> {1}", item.Key, item.Value);
            }
        }
    }
}
