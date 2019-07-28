    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace Train
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
                int capacity = int.Parse(Console.ReadLine());
                while (true)
                {
                    string data = Console.ReadLine();
                    if ( data =="end")
                    {
                        break;
                    }
                    if (data.Contains("Add"))
                    {
                        wagons.Add(int.Parse(data.Split()[1]));
                    }
                    else
                    {
                        for (int i = 0; i < wagons.Count; i++)
                        {
                            int pasengers = int.Parse(data.Split()[0]);
                            if (wagons[i] + pasengers <= capacity)
                            {
                                wagons[i] = wagons[i] + pasengers;
                                break;
                            }
                        }
                    }
                }
                Console.WriteLine(string.Join(" ",wagons));
            }
        }
    }
