using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Summer_Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            //First you will receive a sequence of integers, representing the number of ingredients in a single basket. 
            int[] ingredients = Console.ReadLine().Split().Select(Int32.Parse).Where(x=>x!=0).ToArray();
            //After that you will be given another sequence of integers - the freshness level of the ingredients.
            int[] freshnessLevel = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            Queue<int> queue = new Queue<int>(ingredients);
            Stack<int> stack = new Stack<int>(freshnessLevel);
            var dic = new Dictionary<string, int>();
            dic.Add("Mimosa", 0);
            dic.Add("Daiquiri", 0);
            dic.Add("Sunshine", 0);
            dic.Add("Mojito", 0);
            // 20 0 6 19 Q
            // 12 12  S
            while (stack.Count>0&&queue.Count>0)
            {
                int ingredient = queue.Dequeue();
                int freshLv = stack.Pop();
                if (ingredient * freshLv == 150)
                {
                    dic["Mimosa"]++;
                }
                else if (ingredient * freshLv == 250)
                {
                    dic["Daiquiri"]++;

                }
                else if (ingredient * freshLv == 300)
                {
                    dic["Sunshine"]++;
                }
                else if (ingredient * freshLv == 400)
                {
                    dic["Mojito"]++;
                }
                else
                {
                    ingredient += 5;
                    queue.Enqueue(ingredient);
                }
            }

            var a = dic.Where(x => x.Value > 0);
            if (a.Count()==4)
            {
                Console.WriteLine("It's party time! The cocktails are ready!");
            }
            else
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
            }
            if (queue.Count!=0)
            {
                Console.WriteLine("Ingredients left: {0}",queue.Sum());
            }

            foreach (var item in a.OrderBy(x=>x.Key))
            {
                Console.WriteLine($" # {item.Key} --> {item.Value}");
            }


        }
    }
}
