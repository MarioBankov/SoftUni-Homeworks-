using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
           var dic = new SortedDictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!dic.ContainsKey(numbers[i]))
                {
                    dic.Add(numbers[i], 1);
                }
                else
                {
                    dic[numbers[i]]++;
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine("{0}->{1}",item.Key,item.Value);
            }
        }
    }
}
