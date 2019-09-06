using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Trojan_Invasion
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> platesList = Console.ReadLine().Split().Select(int.Parse).ToList();
            Queue<int> platesQueue= new Queue<int>(platesList);
            Stack<int> warriorsStack = new Stack<int>();
            for (int i = 1; i <= n; i++)
            {
                List<int> warriorsList = Console.ReadLine().Split().Select(int.Parse).ToList();
                AddWarriors(warriorsStack, warriorsList);
                if (i%3==0)
                {
                    List<int> additionalPlate = Console.ReadLine().Split().Select(int.Parse).ToList();
                    for (int j = 0; j < additionalPlate.Count; j++)
                    {
                        platesList.Add(additionalPlate[j]);
                    }
                }
                while (warriorsStack.Count>0&&platesList.Count>0)
                {
                    int currentWarrior = warriorsStack.Pop();
                    int currentPlate = platesList[0];
                    if(currentWarrior>currentPlate)
                    {
                        currentWarrior -= currentPlate;
                        warriorsStack.Push(currentWarrior);
                        platesList.RemoveAt(0);
                    }
                    else if (currentWarrior<currentPlate)
                    {
                        currentPlate -= currentWarrior;
                        platesList[0] = currentPlate;
                    }
                    else
                    {
                        platesList.RemoveAt(0);
                    }
                }
                if (platesList.Count==0)
                {
                    break;
                }
              
            }
            if (platesList.Count == 0)
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine("Warriors left: {0}", string.Join(", ", warriorsStack));
            }
            else
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine("Plates left: {0}",string.Join(", ",platesList));
            }

        }

        private static void AddWarriors(Stack<int> warriorsStack, List<int> warriorsList)
        {
            foreach (var item in warriorsList)
            {
                warriorsStack.Push(item);
            }
        }
    }
}
