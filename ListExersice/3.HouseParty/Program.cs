using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> isGoing = new List<string>();
            List<string> notGoing = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split();
                if (tokens[2]=="going!")
                {
                    if (isGoing.Contains(tokens[0])==true)
                    {
                        Console.WriteLine("{0} is already in the list!.",tokens[0]);
                    }
                    else
                    {
                        isGoing.Add(tokens[0]);
                        Console.WriteLine(tokens[0]);
                    }
                   
                }
                else if (tokens[2]=="not")
                {
                    if (isGoing.Contains(tokens[0])==true)
                    {
                        Console.WriteLine("{0} is not in the list!.",tokens[0]);
                    }
                    else
                    {
                        isGoing.Remove(tokens[0]);
                    }
                }
            
            }
        }
    }
}
