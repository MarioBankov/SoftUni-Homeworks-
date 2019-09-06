using System;
using System.Collections.Generic;
using System.Linq;

namespace Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> cars = new List<Vehicle>();
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="End")
                {
                    break;
                }
                //{typeOfVehicle} {model} {color} {horsepower}
                string[] data = input.Split();
                Vehicle vehicle = new Vehicle(data[0], data[1], data[2], int.Parse(data[3]));
                cars.Add(vehicle);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input== "Close the Catalogue")
                {
                    break;
                }
                int index = cars.FindIndex(x => x.Model == input);
                Console.WriteLine(cars[index].ToString());
            }
            var onlyCars = cars.Where(x => x.Type == "car").ToList();
            var onlyTrucks = cars.Where(x => x.Type == "truck").ToList();
            if (onlyCars.Count!=0)
            {
                Console.WriteLine("Cars have average horsepower of: {0:F2}.",onlyCars.Select(x=>x.Horsepower).Sum()/(onlyCars.Count*1.00));
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (onlyTrucks.Count!=0)
            {
                Console.WriteLine("Trucks have average horsepower of: {0:f2}.", onlyTrucks.Select(x => x.Horsepower).Sum() / (onlyTrucks.Count * 1.00));
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }


        }
    }
    class Vehicle
    {
        public Vehicle(string type,string model,string color,int horsepower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;

        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            string type = this.Type;
            type =  type.First().ToString().ToUpper() + type.Substring(1);
            return $"Type: {type} \nModel: {this.Model}\nColor: {this.Color}\nHorsepower: {this.Horsepower}";
        }
    }
}
