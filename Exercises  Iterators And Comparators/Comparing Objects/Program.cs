using System;
using System.Collections.Generic;

namespace Comparing_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            while (true)
            {
                string[] info = Console.ReadLine().Split();
                if (info[0]=="END")
                {
                    break;
                }
                Person person = new Person(info[0],int.Parse(info[1]),info[2]);
                list.Add(person);

            }
            int n = int.Parse(Console.ReadLine());
            if (n<0||n>=list.Count)
            {
                Console.WriteLine("No Matches");
                return;
            }
            int same = 0;
            int different = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[n].CompareTo(list[i])==0)
                {
                    same++;
                }
                else
                {
                    different++;
                }
            }
            Console.WriteLine($"{same} {different} {list.Count}");
        }
    }
}
