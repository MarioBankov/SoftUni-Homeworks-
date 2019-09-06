using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //“<Model><FuelAmount><FuelConsumptionFor1km>”.
                string[] data = Console.ReadLine().Split();
                Car car = new Car(data[0], double.Parse(data[1]), double.Parse(data[2]));
                cars.Add(car);
            }
            while (true)
            {
                string data = Console.ReadLine();
                if ( data =="End")
                {
                    break;
                }
                string[]arg = data.Split();
                string carmodel = arg[1];
                int km = int.Parse(arg[2]);
                if (cars.Any(x=>x.Model==carmodel))
                {
                    int index = cars.FindIndex(x => x.Model == carmodel);
                    cars[index].Drive(km);
                }
            }
            foreach (var item in cars)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
    class Car
    {
         public Car(string model,double fuelamount,double fuelconsumption)
        {
            this.Model = model;
            this.FuelAmaunt = fuelamount;
            this.FuelPerKm = fuelconsumption;
            this.TotalDistance = 0;

        }
        public string Model { get; set; }
        public double FuelAmaunt { get; set; }
        public double FuelPerKm { get; set; }
        public double TotalDistance { get; set; }

        public void Drive(int km)
        {
            if (km*this.FuelPerKm<=this.FuelAmaunt)
            {
                this.TotalDistance += km;
                this.FuelAmaunt -= km * this.FuelPerKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmaunt:F2} {this.TotalDistance}";
        }
    }
}
