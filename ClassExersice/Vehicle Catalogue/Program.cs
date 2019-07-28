using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Catalogue
{
    public class Auto
    {
        public Auto(string type , string model , string color , int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set;}
        public string Color { get; set;}
        public int HorsePower { get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
           List<Auto> autos = new List<Auto>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="End")
                {
                    break;
                }
                string[] data = input.Split();
                string type = data[0];
                string  model = data[1];
                string  color = data[2];
                int horsePower = int.Parse(data[3]);
                var auto = new Auto(type, model, color, horsePower);
                autos.Add(auto);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Close the Catalogue")
                {
                    break;
                }

                int index = autos.FindIndex(x => x.Model == input);
                if (autos[index].Type=="car")
                {
                    Console.WriteLine("Type: Car");
                }
                else
                {
                    Console.WriteLine("Type: Truck");
                }
                
                Console.WriteLine("Model: {0}",autos[index].Model);
                Console.WriteLine("Color: {0}",autos[index].Color);
                Console.WriteLine("Horsepower: {0}",autos[index].HorsePower);
            }
            var cars = autos.Where(x => x.Type == "car").ToList();
            var trucks = autos.Where(x => x.Type == "truck").ToList();
            if (cars.Count > 0)
            {
                Console.WriteLine("Cars have average horsepower of: {0:f2}.", cars.Average(x => x.HorsePower));
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");

            }
            if (trucks.Count>0)
            {
                Console.WriteLine("Trucks have average horsepower of: {0:f2}.", trucks.Average(x => x.HorsePower));
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");

            }



        }
    }
}
