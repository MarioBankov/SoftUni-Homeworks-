using System;
using System.Collections.Generic;
using System.Linq;

namespace SofuniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "course start")
                {
                    break;
                }
                string command = data.Split(':')[0];
                if (command == "Add")
                {
                    string lesson = data.Split(':')[1];
                    if (lessons.Contains(lesson) == false)
                    {
                        lessons.Add(lesson);
                    }
                }
                else if (command == "Insert")
                {
                    string lesson = data.Split(':')[1];
                    int index = int.Parse(data.Split(':')[2]);
                    if (lessons.Contains(lesson) == false && index >= 0 && index < lessons.Count)
                    {                                                  
                        Insert(lessons, lesson, index);
                    }

                }
                else if (command == "Remove")
                {
                    string lesson = data.Split(':')[1];
                    if (lessons.Contains(lesson))
                    {
                        Remove(lessons, lesson);
                    }
                    if (lessons.Contains(lesson+"-Exercise"))
                    {
                        Remove(lessons, lesson+"-Exercise");
                    }
                    

                }
                else if (command == "Swap")
                {
                    string lesson1 = data.Split(':')[1];
                    string lesson2 = data.Split(':')[2];
                   
                    if (lessons.Contains(lesson1) && lessons.Contains(lesson2))
                    {
                        Swap(lessons, lesson1, lesson2);
                    }
                    
                }
                else if (command == "Exercise")
                {
                    string lesson = data.Split(':')[1];
                    if (lessons.Contains(lesson))
                    {
                        if (lessons.Contains(lesson+"-Exercise"))
                        {
                            continue;
                        }
                        else
                        {
                            AddExercise(lessons, lesson);
                        }
                    }
                    else
                    {
                        lessons.Add(lesson);
                        lessons.Add(lesson + "-Exercise");
                    }
                    
                }
            }
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i+1}.{lessons[i]}");
            }

        }

        private static void AddExercise(List<string> lessons, string lesson)
        {
            int index = lessons.IndexOf(lesson);
            if (index + 1 > lessons.Count - 1)
            {
                lessons.Add($"{lesson}-Exercise");
            }
            else
            {
                lessons.Insert(index + 1, $"{lesson}-Exercise");
            }

        }

        private static void Swap(List<string> lessons, string lesson1, string lesson2)
        {
            int index1 = lessons.IndexOf(lesson1);
            int index2 = lessons.IndexOf(lesson2);

            lessons[index1] = lesson2;
            lessons[index2] = lesson1;
            if (lessons.Contains(lesson1+"-Exercise"))
            {
                Remove(lessons,lesson1 + "-Exercise");
                if (index2+1>lessons.Count-1)
                {
                    lessons.Add(lesson1 + "-Exercise");
                }
                else
                {
                    lessons.Insert(index2 + 1, lesson1 + "-Exercise");
                }
                
            }
            if (lessons.Contains(lesson2+"-Exercise"))
            {
                Remove(lessons, lesson2 + "-Exercise");
                if (index1+1>lessons.Count-1)
                {
                    lessons.Add(lesson2 + "-Exercise");
                }
                else
                {
                    lessons.Insert(index1 + 1, lesson2 + "-Exercise");
                }
               
            }

        }

        private static void Remove(List<string> lessons, string lesson)
        {
            lessons.Remove(lesson);
             lessons = lessons.Where(x => x != lesson).ToList();
        }

        private static void Insert(List<string> lessons, string lesson, int index)
        {
            lessons.Insert(index, lesson);
        }
    }
}
