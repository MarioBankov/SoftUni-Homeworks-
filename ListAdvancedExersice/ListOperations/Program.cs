using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string data = Console.ReadLine();
                if (data=="End")
                {
                    break;
                }
                string command = data.Split()[0];
                if (command=="Add")
                {
                    numbers.Add(int.Parse(data.Split()[1]));
                }
                else if (command=="Insert")
                {
                    int number = int.Parse(data.Split()[1]);
                    int index = int.Parse(data.Split()[2]);
                    if ( index>=0&&index<numbers.Count)
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
                    int index = int.Parse(data.Split()[1]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command == "Shift")
                {
                    string side = data.Split()[1];
                     int count = int.Parse(data.Split()[2]);
                    if (side=="left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            // firt number become last (count) times 
                            //      5 1 2 3 4 5
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }

                }


            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
