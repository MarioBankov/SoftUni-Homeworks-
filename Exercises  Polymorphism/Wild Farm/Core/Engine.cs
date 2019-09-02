using System;
using System.Collections.Generic;
using System.Linq;
using Wild_Farm.Animals;
using Wild_Farm.Foods;
using Wild_Farm.Foods.Factory;

namespace Wild_Farm.Core
{
    public class Engine
    {
        private List<Animal> animals;
        private FoodFactory foodFactory;
        public Engine()
        {
            this.animals = new List<Animal>();
            this.foodFactory = new FoodFactory();
        }
        public void Run()
        {
            string command = Console.ReadLine();
            while (command!="End")
            {
                string foodInput = Console.ReadLine();
                Animal animal = GetAnimal(command);
                animals.Add(animal);
                Food food = GetFood(foodInput);
                Console.WriteLine(animal.AskFood());
                try
                {
                    animal.Feed(food);
                }
                catch (Exception ex )
                {

                    Console.WriteLine(ex.Message);
                }
                command = Console.ReadLine();
            }
            PrintOutput();
        }

        private void PrintOutput()
        {
            foreach (var item in animals)
            {
                Console.WriteLine(item );
            }
        }

        private Food GetFood(string foodInput)
        {
            string[] foodArg = foodInput.Split().ToArray();
            string foodType = foodArg[0];
            int quatity = int.Parse(foodArg[1]);

            Food food = foodFactory.ProduceFood(foodType, quatity);

            return food;
           
        }

        private Animal GetAnimal(string command)
        {
            string[] animalsArgs = command.Split().ToArray();
            string type = animalsArgs[0];
            string name = animalsArgs[1];
            double weight = double.Parse(animalsArgs[2]);
            Animal animal = null;
            if (type=="Owl")
            {
                double wingsize = double.Parse(animalsArgs[3]);
                animal = new Owl(name, weight, wingsize);
            }
            else if (type=="Hen")
            {
                double wingsize = double.Parse(animalsArgs[3]);
                animal = new Hen(name, weight, wingsize);
            }
            else if (type=="Mouse")
            {
                string region = animalsArgs[3];
                animal = new Mouse(name, weight, region);

            }
            else if (type=="Dog")
            {
                string region = animalsArgs[3];
                animal = new Dog(name, weight, region);  
            }
            else if (type=="Cat")
            {
                //Tiger Typcho 167.7 Asia Bengal
                string region = animalsArgs[3];
                string breed = animalsArgs[4];
                animal = new Cat(name, weight, region, breed);
            }
            else if (type =="Tiger")
            {
                string region = animalsArgs[3];
                string breed = animalsArgs[4];
                animal = new Tiger(name, weight, region, breed);
            }
            return animal;
        }
    }
}
