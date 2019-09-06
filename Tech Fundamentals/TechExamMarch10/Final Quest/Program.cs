using System;
using System.Collections.Generic;
using System.Linq;

namespace Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            while (true)
            {
                string data = Console.ReadLine();
                if (data == "Stop")
                {
                    break;
                }
                string[] commands = data.Split();
                string command = commands[0];
                //Delete {index} – removes the word after the given index if it is valid.
                if (command == "Delete")
                {
                    int index = int.Parse(commands[1]);
                    if (index + 1 > 0 && index + 1 < words.Count)
                    {
                        words.RemoveAt(index + 1);
                    }
                }
                else if (command=="Swap")
                {
                    string word1 = commands[1];
                    string word2 = commands[2];
                    if (words.Contains(word1)&&words.Contains(word2))
                    {
                        int index1 = words.IndexOf(word1);
                        int index2 = words.IndexOf(word2);
                        words[index1] = word2;
                        words[index2] = word1;
                    }
                }
                else if (command=="Put")
                {
                    string word = commands[1];
                    int index = int.Parse(commands[2])-1;
                    if (index> 0 && index < words.Count+1) 
                    {
                        words.Insert(index , word);
                    }
                }
                else if (command=="Sort")
                {

                   words.Sort();
                   words.Reverse();
                }
                else if (command=="Replace")
                {
                    string word1 = commands[1];
                    string word2 = commands[2];
                    if (words.Contains(word2))
                    {
                        int index = words.IndexOf(word2);
                        words[index] = word1;
                    }
                }

            }
            Console.WriteLine(string.Join(" ",words));
        } ///1 2 3 4 5 6
    }
}
