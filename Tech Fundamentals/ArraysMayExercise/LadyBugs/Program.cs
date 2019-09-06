using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] fild = new int[size];

            for (int i = 0; i < indexes.Length; i++)
            {
                if (indexes[i]>=0&& indexes[i]<fild.Length)
                {
                    fild[indexes[i]] = 1;
                }
                
            }

            while (true)
            {
                string data = Console.ReadLine();
                if (data == "end")
                {
                    break;
                }
                string[] commands = data.Split();
                int index = int.Parse(commands[0]);
                string direction = commands[1];
                int distance = int.Parse(commands[2]);

                bool isIndexInRange = index >= 0 && index < fild.Length;
                if (isIndexInRange && direction == "right" && fild[index] == 1)
                {
                    fild[index] = 0;
                    while (true)
                    {
                        if (index + distance >= 0 && index + distance < fild.Length)
                        {
                            index += distance;
                        }
                        else
                        {
                            break;
                        }
                        if (fild[index] == 0)
                        {
                            fild[index] = 1;
                            break;
                        }
                    }
                }
                else if (isIndexInRange && direction == "left" && fild[index] == 1)
                {
                    fild[index] = 0;
                    while (true)
                    {

                        if (index - distance >= 0 && index - distance < fild.Length)
                        {
                            index -= distance;
                        }
                        else
                        {
                            break;
                        }
                        if (fild[index] == 0)
                        {
                            fild[index] = 1;
                            break;
                        }
                    }

                }

            }
            Console.WriteLine(string.Join(" ", fild));

        }
    }
}

