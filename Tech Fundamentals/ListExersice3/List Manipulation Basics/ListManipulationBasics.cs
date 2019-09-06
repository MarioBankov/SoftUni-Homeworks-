using System;
using System.Collections.Generic;
using System.Linq;
namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="end")
                {
                    break;
                }
                string[] token = input.Split();
                string command = token[0];
                if (command=="Add")
                {
                    int number = int.Parse(token[1]);
                    sequence.Add(number);
                }
                else if (command=="Remove")
                {
                    int number = int.Parse(token[1]);
                    sequence.Remove(number);
                }
                else if (command=="RemoveAt")
                {
                    int index = int.Parse(token[1]);
                    sequence.RemoveAt(index);
                }
                else if (command=="Insert")
                {
                    int number = int.Parse(token[1]);
                    int index = int.Parse(token[2]);
                    if (index>=0&&index<sequence.Count)
                    {
                        sequence.Insert(index, number);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",sequence));
        }
    }
}
