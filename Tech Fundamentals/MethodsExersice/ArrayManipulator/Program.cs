using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            string index = GetIndex(input);

            if (StringMinusLastSymbol(input) == "exchange")
            {
                int index1 = int.Parse(index);
                if (index1 < 0 || index1 > array.Length)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    int[] sub = new int[array.Length];
                    for (int i = 0; i < array.Length; i++)
                    {
                        sub[i] = array[i];
                    }
                    for (int i = 0; i < array.Length - index1 - 1; i++)
                    {
                        array[i] = array[index1 + 1 + i];
                    }
                    for (int i = 0; i < index1 + 1; i++)
                    {
                        array[array.Length - index1 + i - 1] = sub[i];
                    }
                    foreach (var item in array)
                    {
                        Console.Write(item + " ");
                    }
                }

            }
            else if (input == "max even")
            {
                int evenMax = int.MinValue;
                int maxEven = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (array[i] > evenMax)
                        {
                            evenMax = array[i];
                            maxEven = i;
                        }
                    }
                }
                Console.WriteLine(maxEven);
            }
            else if (input == "min even")
            {
                int evenMin = int.MaxValue;
                int minEven = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (array[i] < evenMin)
                        {
                            evenMin = array[i];
                            minEven = i;
                        }
                    }
                }
                Console.WriteLine(minEven);
            }

            


        }
        static string StringMinusLastSymbol(string text)
        {
            string result = String.Empty;

            for (int i = 0; i < text.Length - 2; i++)
            {
                result += text[i];
            }
            return result;
        }
        static string GetIndex(string text)
        {
            string result = (text[text.Length - 1] + "");
            return result;

        }
        static void MaxEven(EventArgs args)
        {
      
        }
    }

}

