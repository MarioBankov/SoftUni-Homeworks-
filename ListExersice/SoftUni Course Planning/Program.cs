using System;
using System.Collections.Generic;
using System.Linq;


namespace SoftUni_Course_Planning
{
    class Program
    {
     

        static void Main(string[] args)
        {

            List<string> text = Console.ReadLine().Split(',').ToList();



            while (true)
            {

                for (int i = 0; i < text.Count; i++)
                {
                    Console.Write(text[i]);
                }
                string input = Console.ReadLine();
                string[] tokens = input.Split(':');
                string command = tokens[0];
                if (command == "course start")
                {
                    break;
                }
                else if (command == "Add")        //                       ADD
                {
                    string lesson = tokens[1];
                    if (text.Contains(lesson) == false)
                    {
                        text.Add(lesson);
                    }
                }

                else if (tokens[0] == "Insert")   //                     INSERT
                {
                    string lesson = tokens[1];
                    int index = int.Parse(tokens[2]);

                    if (text.Contains(lesson) == false)
                    {
                        text.Insert(index, lesson);
                    }
                }
                else if (tokens[0] == "Remove")  //                      REMOVE
                {
                    string lesson = tokens[1];
                    if (text.Contains(lesson) == true)
                    {
                        text.Remove(tokens[1]);
                    }
                }
                else if (tokens[0] == "Swap") //                            SWAP
                {
                    string lessonOne = tokens[1];
                    string lessonTwo = tokens[2];
                    if (text.Contains(lessonOne) == true && text.Contains(lessonTwo) == true)
                    {
                        int indexOne = text.IndexOf(lessonOne);
                        int indexTwo = text.IndexOf(lessonTwo);

                        text.RemoveAt(indexOne);
                        text.Insert(indexOne, lessonTwo);
                        text.RemoveAt(indexTwo);
                        text.Insert(indexTwo, lessonOne);
                    }
                }
                else if (command == "Exersice")
                {
                    string lesson = tokens[1];
                    if (text.Contains(lesson))
                    {
                        int index = text.IndexOf(lesson);
                        text.Insert(index + 1, $"{lesson}-Exercise");
                    }
                    else
                    {
                        text.Add($"{lesson}-Exercise");
                    }

                }

            }
            for (int i = 0; i < text.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{text[i]}");
            }
        }
    }
}
