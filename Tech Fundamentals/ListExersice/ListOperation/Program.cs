using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
                }
                string[] tokens = command.Split();
                if (tokens[0] == "Add")
                {
                    numbers.Add(int.Parse(tokens[1]));
                }
                else if (tokens[0] == "Insert")
                {
                    numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                }
                else if (tokens[0] == "Remove")
                {
                    if (int.Parse(tokens[1]) > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(int.Parse(tokens[1]));
                    }

                }
                else if (tokens[0] == "Shift")
                {
                    if (tokens[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(tokens[2]); i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else if (tokens[1] == "right")
                    {
                        for (int i = 0; i < int.Parse(tokens[2]); i++)
                        {
                            numbers.Insert(0, numbers.Count);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                       
                    }

                    //3 5 12 95 32 1 8 
                    //8 3 5 12 95 32 1 
                    //3 5 12 95 32 1 8
                    //5 12 95 32 1 8 3


                }


            }
        }
    }
}
