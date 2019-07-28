using System;
using System.Collections.Generic;
using System.Linq;

namespace Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, int>();
            while (true)
            {
                string data = Console.ReadLine();
                if (data=="stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());
                if (dic.ContainsKey(data)==false)
                {
                    dic.Add(data, quantity);
                }
                else
                {
                    dic[data] += quantity;
                }

            }
            foreach (var item in dic)
            {
                Console.WriteLine("{0} -> {1}",item.Key,item.Value);
            }
        }
    }
}
