using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split().ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "3:1")
                {
                    break;
                }
                string[] tokens = command.Split();
                string command1 = tokens[0];
                if (command1 == "merge")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    Chercker(startIndex, endIndex, data);
                    data = Merge(startIndex, endIndex, data);
                  
                    
                }
                else if (command1 == "divide")
                {
                    int index = int.Parse(tokens[1]);
                    int partitions = int.Parse(tokens[2]);
                    data = Devide(index, partitions, data);
                }
            }
            Console.WriteLine(string.Join(" ",data));
        }

        private static List<string> Devide(int index, int partitions, List<string> data)
        {
            List<string> words = new List<string>();
            string element = data[index];
            int lenght = element.Length / partitions;
            bool onemore = false;
            if (element.Length % partitions == 1)
            {
                onemore = true;
            }
            for (int i = 0; i < partitions; i++)
            {

                if (onemore)
                {
                    if (i == partitions - 1)
                    {
                        words.Add(element.Substring(i * lenght, lenght + 1));
                        break;
                    }
                }

                words.Add(element.Substring(i * lenght, lenght));

            }
            data.RemoveAt(index);
            for (int i = 0; i < words.Count; i++)
            {
                data.Insert(index + i, words[i]);
            }

            return data;
        }

        private static void Chercker(int startIndex, int endIndex,List<string> data)
        {
            if (startIndex <= 0)
            {
                startIndex = 0;
            }
            if (endIndex > data.Count - 1)
            {
                endIndex = data.Count - 1;

            }
        }

        private  static List<string> Merge(int startIndex, int endIndex, List<string> data)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                data[startIndex] = data[startIndex] + data[startIndex + 1];
                data.Remove(data[startIndex + 1]);
            }
            return data;
        }
    }
}
