using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command=="end")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
                }
                string[] tokens = command.Split();
                if (tokens[0]=="Add")
                {
                    numbers.Insert(numbers.Count, int.Parse(tokens[1]));
                }
                else if (tokens[0]=="Remove")
                {
                    numbers.Remove(int.Parse(tokens[1]));
                }
                else if (tokens[0]=="RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(tokens[1]));
                }
                else if (tokens[0]=="Insert")
                {
                    numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1])); 
                }
                
            }
        }
    }
}
