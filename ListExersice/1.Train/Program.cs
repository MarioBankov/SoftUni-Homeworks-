using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    
                    Console.WriteLine(string.Join(" ",train));
                    break;
                }

                string[] tokens = command.Split();
                if (tokens[0] == "Add")
                {
                    train.Add(int.Parse(tokens[1]));

                }
                else
                {


                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] <= maxCapacity - int.Parse(command))
                        {
                            train[i] += int.Parse(command);
                            break;
                        }
                    }
                }


            }
        }
    }
}
