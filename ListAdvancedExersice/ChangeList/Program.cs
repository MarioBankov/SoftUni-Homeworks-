using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string data = Console.ReadLine();
                if (data =="end")
                {
                    break;
                }
                string command = data.Split()[0];
                if (command=="Delete")
                {
                    int number = int.Parse(data.Split()[1]);
                    numbers = numbers.Where(x => x != number).ToList();
                }
                if (command=="Insert")
                {
                    int number = int.Parse(data.Split()[1]);
                    int index  = int.Parse(data.Split()[2]);
                    numbers.Insert(index, number);
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
