using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Catalogue
{
    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }

    }
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

    }
    public class Catalog
    {
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars  { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Truck> truckList = new List<Truck>();
            List<Car> carList = new List<Car>();
            List<Catalog> catalogList = new List<Catalog>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="end")
                {
                    break;
                }
                // {type}/{brand}/{model}/{horse power / weight}
                string[] data = input.Split('/');
                

                if (data[0] == "Car")
                {
                    string brand = data[1];
                    string model = data[2];
                   int horsePower = int.Parse(data[3]);

                    var car = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower,
                    };
                    carList.Add(car);
                }
           
                else
                {
                    string brand = data[1];
                    string model = data[2];
                    int weight = int.Parse(data[3]);

                    var truck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight,
                    };
                    truckList.Add(truck);
                }

                var catalog = new Catalog
                {
                    Trucks = truckList,
                    Cars = carList,
                };
                catalogList.Add(catalog);
            }
            foreach (var item in catalogList)
            {
                var cars = item.Cars;
                var trucks = item.Trucks;
                Console.WriteLine("Cars:");
                foreach (var itemm in cars)
                {
                    Console.WriteLine($"{itemm.Brand}: {itemm.Model} - {itemm.HorsePower}hp");
                }
                Console.WriteLine("Trucks:");
                foreach (var itemmm in trucks)
                {
                    Console.WriteLine($"{itemmm.Brand}: {itemmm.Model} - {itemmm.Weight}kg.");
                }
            }
            Console.WriteLine("Cars:");
            foreach (var item in carList)
            {
                
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (var item in truckList)
            {
                
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg.");
            }
        }
    }
}
