using System;
using System.Collections.Generic;
using System.Linq;

namespace Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> paintings = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string data = Console.ReadLine();
                if (data=="END")
                {
                    break;
                }
                string[] commands = data.Split();
                string command = commands[0];
                if (command=="Change")
                {
                    int number1 = int.Parse(commands[1]);
                    int number2 = int.Parse(commands[2]);
                    if (paintings.Contains(number1))
                    {
                        if (paintings.Contains(number1))
                        {
                            int index = paintings.IndexOf(number1);
                            paintings[index] = number2;
                        }
                    }
                }
                else if (command=="Hide")
                {
                    int number = int.Parse(commands[1]);
                    if (paintings.Contains(number))
                    {
                        paintings.Remove(number);

                    }
                }
                else if (command=="Switch")
                {
                    int number1 = int.Parse(commands[1]);
                    int number2 = int.Parse(commands[2]);
                    if (paintings.Contains(number1)&&paintings.Contains(number2))
                    {
                        int index1 = paintings.IndexOf(number1);
                        int index2 = paintings.IndexOf(number2);
                        paintings[index1] = number2;
                        paintings[index2] = number1;
                    }
                }
                else if (command=="Insert")
                {
                    int index = int.Parse(commands[1]);
                    int number = int.Parse(commands[2]);
                    if (index+1>0&&index+1<paintings.Count-1)
                    {
                        paintings.Insert(index + 1, number);
                    }
                }
                else if (command=="Reverse")
                {
                    paintings.Reverse();
                }
            }
            Console.WriteLine(string.Join(" ",paintings));
        }
        
    }
}
