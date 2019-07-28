using System;
using System.Collections.Generic;
using System.Linq;

namespace _8Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            while (true)
            {
                string data = Console.ReadLine();
                if (data=="3:1")
                {
                    break;
                }
                string command = data.Split()[0];
                if (command=="merge")
                {

                    int startIndex = int.Parse(data.Split()[1]);
                    int endIndex = int.Parse(data.Split()[2]);
                    if (startIndex<0 || startIndex>list.Count-1)
                    {
                        startIndex = 0;
                    }
                    if (endIndex>list.Count-1 || endIndex<0)
                    {
                        endIndex = list.Count - 1;
                    }
                    Merge(list, startIndex, endIndex);
                }
                else
                {
                    int index = int.Parse(data.Split()[1]);
                    int partitions = int.Parse(data.Split()[2]);
                    Divide(list, index, partitions);
                }
            }
            Console.WriteLine(string.Join(" ",list));
        }

        private static void Divide(List<string> list, int index, int partitions)
        {
            string element = list[index];
            list.RemoveAt(index);
            string result = string.Empty;
            int length = element.Length / partitions;
            if (element.Length%partitions==0)   
            {
                for (int i = 0; i < partitions; i++)
                {
                  list.Insert( index+i, element.Substring(0, length));
                   element= element.Remove(0, length);
                }
            }
            else
            {
                for (int i = 0; i < partitions; i++)
                {   
                    if (i==partitions-1)
                    {
                        list.Insert(index + i, element.Substring(0, element.Length));
                    }
                    else
                    {
                        list.Insert(index + i, element.Substring(0, length));
                        element = element.Remove(0, length);
                    }
                }
            }
           
        }

        private static void Merge(List<string> list, int startIndex, int endIndex)
        {
            string temp = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                temp += list[i];
            }
            list.RemoveRange(startIndex, endIndex - startIndex+1); 
            list.Insert(startIndex, temp);
        }
    }
}
