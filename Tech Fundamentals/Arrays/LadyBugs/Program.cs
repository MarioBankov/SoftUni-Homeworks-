using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            //   int size = int.Parse(Console.ReadLine());
            //   int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            // 
            //   int[] array = new int[size];
            //   for (int j = 0; j < indexes.Length; j++)
            //   {
            //       if (indexes[j] < array.Length && indexes[j] >= 0)
            //       {
            //           int number = indexes[j];
            //           array[number] = 1;
            //       }
            // 
            //   }
            // 
            //   string[] command = new string[3];
            // 
            //   while (true)
            //   {
            //       string input = Console.ReadLine();
            //       if (input == "end")
            //       {
            //           break;
            //       }
            //
            //    command = input.Split().ToArray();
            //    int ladyBugIndex = int.Parse(command[0]);
            //    string direction = command[1];
            //    int length = int.Parse(command[2]);

            int[] array = { 1, 1, 1 };
                if (ladyBugIndex < array.Length && ladyBugIndex >= 0 && array[ladyBugIndex] == 1)
                {
                    if (direction == "right")
                    {
                        if (ladyBugIndex + length < array.Length && array[ladyBugIndex + length] == 0 ) 
                            
                        {
                            array[ladyBugIndex + length] = 1;
                            array[ladyBugIndex] = 0;
                            break;
                        }
                        else if (ladyBugIndex + length < array.Length && array[ladyBugIndex + length] == 1)
                        {
                            for (int i = array[ladyBugIndex + length]+1; i < array.Length; i++)
                            {
                                if (array[i]==1&&array[i]==array.Length-1)
                                {
                                    array[ladyBugIndex] = 0;
                                }
                                else
                                {
                                    array[i] = 1;
                                }
                            }
                        }




                    }
                    else if (direction == "left")
                    {
                        for (int j = array.Length; j > array.Length; j--)
                        {
                            if (ladyBugIndex - length - j <= array[0])
                            {
                                if (array[ladyBugIndex - length - j] == 0)
                                {
                                    array[ladyBugIndex - length - j] = 1;
                                    continue;
                                }
                                else if (array[ladyBugIndex - length - j] == 1 && j == array[0])
                                {
                                    array[ladyBugIndex] = 0;
                                }
                            }
                            else
                            {
                                array[ladyBugIndex] = 0;
                            }
                        }

                    }

                }


            }
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }

    }
}





