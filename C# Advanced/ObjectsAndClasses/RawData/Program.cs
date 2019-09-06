using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //:"<Model><EngineSpeed><EnginePower><CargoWeight><CargoType>
                string[] data = Console.ReadLine().Split();
                string model = data[0];
                int speed = int.Parse(data[1]);
                int power = int.Parse(data[2]);
                int weight = int.Parse(data[3]);
                string type = data[4];
                Engine engine = new Engine();
                engine.EnginePower = power;
                engine.EngineSpeed = speed;
                Cargo cargo = new Cargo();
                cargo.Weight = weight;
                cargo.Type = type;
                Car car = new Car(model,engine,cargo);
                cars.Add(car);
            }
            string cargoType = Console.ReadLine();
            if (cargoType== "fragile")
            {
                var fragileCars = cars.Where(x => x.Cargo.Type == "fragile").Where(a => a.Cargo.Weight < 1000).ToList();
                foreach (var item in fragileCars)
                {
                    Console.WriteLine(item.Model);
                }
            }
            else
            {
                var flamablecars = cars.Where(x => x.Cargo.Type == "flamable").Where(a => a.Engine.EnginePower > 250).ToList();
                foreach (var item in flamablecars)
                {
                    Console.WriteLine(item.Model);
                }
            }
        }
    }
    class Car
    {
        public Car(string model,Engine engine,Cargo cargo)
        {
            this.Model = model;
            this.Cargo = cargo;
            this.Engine = engine;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }
    class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
    class Cargo
    {
        public int Weight { get; set;}
        public string Type { get; set; }
    }

}
