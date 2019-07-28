using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shedule = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="course start")
                {
                    break;
                }
                string[] tokens = input.Split(':');
                string command = tokens[0];
                if (command=="Add")
                {
                    string titel = tokens[1];
                    AddTitelToShedule(titel, shedule);
                }
                else if (command=="Insert")
                {
                    int index = int.Parse(tokens[2]);
                    string titel = tokens[1];
                    InsertTitel(index, titel, shedule);
                }
                else if (command=="Remove")
                {
                    string titel = tokens[1];
                    if (shedule.Contains(titel))
                    {
                        int index = shedule.IndexOf(titel);
                        if (shedule[index+1]==$"{titel}-Exercise")
                        {
                            shedule.RemoveAt(index + 1);
                        }
                        shedule.Remove(titel);
                    }
                    
                }
                else if (command=="Swap")
                {
                    string titel1 = tokens[1];
                    string titel2 = tokens[2];
                    Swap(titel1, titel2, shedule);
                }
                else if (command=="Exercise")
                {
                    string titel = tokens[1];
                    if (shedule.Contains(titel))
                    {
                        int index = shedule.IndexOf(titel);
                        if (shedule[index+1]!=$"{titel}-Exercise")
                        {
                            AddExersice(titel, shedule);
                        }
                       
                    }
                    else
                    {
                        shedule.Add(titel);
                        shedule.Add($"{titel}-Exercise");
                    }
                }
              
            }
            for (int i = 0; i < shedule.Count; i++)
            {
                Console.WriteLine("{0}.{1}",i+1,shedule[i]);
            }
        }

        private static void AddExersice(string titel, List<string> shedule)
        {
            int idex = shedule.IndexOf(titel);
            shedule.Insert(idex + 1, $"{titel}-Exercise");
                
        }

        private static void Swap(string titel1, string titel2, List<string> shedule)
        {
            int index1 = shedule.IndexOf(titel1);
            int index2 = shedule.IndexOf(titel2);
            string temp1 = shedule[index1];
            shedule[index1] = shedule[index2];
            shedule[index2] = temp1;

            if (shedule.Contains($"{titel2}-Exercise"))
            {
                int index11 = shedule.IndexOf(titel2);
                int indexExercise = shedule.IndexOf($"{titel2}-Exercise");
                shedule.RemoveAt(indexExercise);
                shedule.Insert(index11 + 1, $"{titel2}-Exercise");
            
            }
            else if (shedule.Contains($"{titel1}-Exercise"))
            {
                int index11 = shedule.IndexOf(titel1);
                int indexExercise = shedule.IndexOf($"{titel1}-Exercise");
                shedule.RemoveAt(indexExercise);
                shedule.Insert(index11 + 1, $"{titel1}-Exercise");
            }
        }

        private static void InsertTitel(int index, string titel, List<string> shedule)
        {
            if (!shedule.Contains(titel))
            {
                shedule.Insert(index, titel);
            }
        }

        private static void AddTitelToShedule(string titel, List<string> shedule)
        {
            if (!shedule.Contains(titel))
            {
                shedule.Add(titel);
            }
        }
    }
}
