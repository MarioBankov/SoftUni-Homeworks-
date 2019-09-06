using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Feed_The_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "Last Info")
                {
                    break;
                }
                string[] splitedData = data.Split(':');
                string command = splitedData.First();
                if (command=="Add")
                {
                    string name = splitedData[1];
                    int limit = int.Parse(splitedData[2]);
                    string area = splitedData[3];
                    if (animals.Any(x=>x.Name==name))
                    {
                        int index = animals.FindIndex(x => x.Name == name);
                        animals[index].FoodLimitP += limit;
                    }
                    else
                    {
                        Animal animal = new Animal(name,limit,area);
                        animals.Add(animal);
                    }
                }
                else if (command=="Feed")
                {
                    //"Feed:{animalName}:{food}:{area}":
                    string name = splitedData[1];
                    int food = int.Parse(splitedData[2]);
                    string area = splitedData[3];
                    if (animals.Any(x=>x.Name==name))
                    {
                        int index = animals.FindIndex(x => x.Name == name);
                        animals[index].FoodLimitP -= food;
                        if (animals[index].FoodLimitP<=0)
                        {
                            Console.WriteLine("{0} was successfully fed",animals[index].Name);
                            animals.RemoveAt(index);
                        }

                    }
                }
            }
            var dict = new Dictionary<string, int>();
            foreach (var item in animals)
            {
                if (dict.ContainsKey(item.Area) == false)
                {
                    dict.Add(item.Area, 0);
                }
                dict[item.Area]++;
            }
           animals= animals.OrderByDescending(x => x.FoodLimitP).ThenBy(x => x.Name).ToList();
            Console.WriteLine("Animals: ");
           
            foreach (var item in animals)
            {
                Console.WriteLine("{0} -> {1}g", item.Name, item.FoodLimitP);
               
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (var item in dict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
        }
    }
    class Animal
    {
        public Animal(string name,int limit,string area)
        {
            this.Name = name;
            this.Area = area;
            this.FoodLimitP = limit;
        }
        public string Name { get; set; }
        public string Area { get; set; }
        public int FoodLimitP { get; set; }
    }
}
