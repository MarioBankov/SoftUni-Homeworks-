using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command=="end")
                {
                    Console.WriteLine(string.Join(" ",number));
                    break;
                }
                string[] tokens = command.Split();
                if (tokens[0]=="Delete")
                {
                    number.RemoveAll(x => x ==int.Parse(tokens[1]));
                }
                if (tokens[0]=="Insert")
                {
                    number.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                }

            }
        }
    }
}
