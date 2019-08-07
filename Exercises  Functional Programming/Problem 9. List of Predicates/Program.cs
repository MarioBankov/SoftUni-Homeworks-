using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_9._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> numbers = Enumerable.Range(1, number).ToList();
            HashSet<int> predicates1 = Console.ReadLine().Split().Select(int.Parse).ToHashSet();
            List<Predicate<int>> predicates = new List<Predicate<int>>();
            foreach (var item in predicates1)
            {
                Predicate<int> a = x => x % item == 0;
                predicates.Add(a);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                bool print = true;
                for (int j = 0; j < predicates.Count; j++)
                {
                    if (!predicates[j](numbers[i]))
                    {
                        print = false;
                        break;
                    }
                }
                if (print)
                {
                    Console.Write(numbers[i] + " ");
                }
                
            }
           
        }
    }
}
