using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                
                if (input=="stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());
                if (!dic.ContainsKey(input))
                {
                    dic.Add(input, quantity);
                }
                else
                {
                    dic[input] += quantity;
                }

            }
            foreach (var item in dic)
            {
                Console.WriteLine("{0}->{1}",item.Key,item.Value);
            }
        }
    }
}
