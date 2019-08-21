using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Spaceship_Crafting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] chemicalLiquids = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] physicalItems = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(physicalItems);
            Queue<int> queue = new Queue<int>(chemicalLiquids);
            var dict = new SortedDictionary<string, int>();
            dict.Add("Glass", 0);
            dict.Add("Aluminium", 0);
            dict.Add("Lithium", 0);
            dict.Add("Carbon fiber", 0);
            while (stack.Count>0&&queue.Count>0)
            {
                int chemical = queue.Dequeue();
                int item = stack.Pop();
                if (chemical+item==25)
                {
                    if (dict.ContainsKey("Glass")==false)
                    {
                        dict.Add("Glass",0);
                    }
                    dict["Glass"]++;
                }
                else if (chemical+item==50)
                {
                    if (dict.ContainsKey("Aluminium") == false)
                    {
                        dict.Add("Aluminium", 0);
                    }
                    dict["Aluminium"]++;
                }
                else if (chemical+item==75)
                {
                    if (dict.ContainsKey("Lithium") == false)
                    {
                        dict.Add("Lithium", 0);
                    }
                    dict["Lithium"]++;
                }
                else if (chemical+item==100)
                {
                    if (dict.ContainsKey("Carbon fiber") == false)
                    {
                        dict.Add("Carbon fiber", 0);
                    }
                    dict["Carbon fiber"]++;
                }
                else
                {
                    item += 3;
                    stack.Push(item);
                }
            }
            var a = dict.Where(x => x.Value > 0).ToDictionary(x => x.Key, y => y.Value);
            if (a.Count>=4)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (queue.Count!=0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ",queue)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }
            if (stack.Count!=0)
            {
                Console.WriteLine($"Physical items left: {string.Join(", ",stack)}");
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


        }
    }
}
