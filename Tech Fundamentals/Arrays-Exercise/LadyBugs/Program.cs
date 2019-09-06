using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fildSize = int.Parse(Console.ReadLine());
            int[] indexes = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int[] array = new int[fildSize];
            for (int i = 0; i < indexes.Length; i++)
            {
                if (indexes[i] >= 0 && indexes[i] < array.Length)
                {
                    array[indexes[i]] = 1;
                }

            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] tokens = input.Split();
                int bug = int.Parse(tokens[0]);
                string direction = tokens[1];
                int lenght = int.Parse(tokens[2]);

                bool IsInside = bug + lenght >= 0 && bug + lenght < array.Length;


                if (array[bug] == 1)
                {
                    if (direction == "right")
                    {
                        if (IsInside && array[bug + lenght] == 0)
                        {
                            array[bug] = 0;
                            array[bug + lenght] = 1;
                        }
                        else if (IsInside && array[bug+lenght]==1)
                        {
                            while (bug + lenght >= 0 && bug + lenght < array.Length && array[bug + lenght] == 1)
                            {
                                lenght += lenght;
                                if (bug + lenght >= 0 && bug + lenght < array.Length && array[bug + lenght] == 0)
                                {
                                    array[bug + lenght] = 1;
                                    array[bug] = 0;
                                    break;
                                }
                                else
                                {
                                    array[bug] = 0;
                                }
                            }
                        }
                        else if (IsInside == false)
                        {
                            array[bug] = 0;
                        }
                    }
                    else
                    {
                        bool IsInside1 = bug - lenght >= 0 && bug - lenght < array.Length;
                        if (IsInside1 && array[bug - lenght] == 0)
                        {
                            array[bug] = 0;
                            array[bug - lenght] = 1;
                        }
                        else if (IsInside1 && array[bug - lenght] == 1)
                        {
                            while (bug - lenght >= 0 && bug - lenght < array.Length && array[bug - lenght] == 1)
                            {
                                lenght -= lenght;
                                if (bug - lenght >= 0 && bug - lenght < array.Length && array[bug - lenght] == 0)
                                {
                                    array[bug - lenght] = 1;
                                    array[bug] = 0;
                                    break;
                                }
                                else
                                {
                                    array[bug] = 0;
                                }
                            }
                        }
                        else if (IsInside == false)
                        {
                            array[bug] = 0;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", array));
        }

    }
}

