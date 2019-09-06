using System;
using System.Collections.Generic;
using System.Linq;


namespace ListOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="End")
                {
                    break;

                }
                string[] tokens = input.Split();
                string command = tokens[0];
                if (command=="Add")
                {
                    int number = int.Parse(tokens[1]);
                    numbers.Add(number);
                }
                else if (command=="Insert")
                {
                    int index = int.Parse(tokens[2]);
                    int number = int.Parse(tokens[1]);
                    if (index>=0&&index<numbers.Count)
                    {
                        numbers.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command=="Remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (index >= 0 && index < numbers.Count) 
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command=="Shift")
                {
                    string direction = tokens[1];
                    int count = int.Parse(tokens[2]);
                    if (direction=="left")
                    {
                        
                        for (int i = 0; i < count; i++)
                        {
                            int replace = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(replace);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int replace = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, replace);
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
