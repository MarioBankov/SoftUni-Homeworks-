using System;

namespace Vehicles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] carArgs = Parser();
            string[] truckArgs = Parser();
            string[] busArgs = Parser();

            Vehicle car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]), double.Parse(carArgs[3]));
            Vehicle truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]), double.Parse(truckArgs[3]));
            Bus bus = new Bus(double.Parse(busArgs[1]), double.Parse(busArgs[2]), double.Parse(busArgs[3]));

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                try
                {
                    string[] data = Console.ReadLine().Split();

                    if (data[1] == "Car")
                    {
                        if (data[0] == "Drive")
                        {
                            Console.WriteLine(car.Drive(double.Parse(data[2])));
                        }
                        else
                        {
                            car.Refuel(double.Parse(data[2]));
                        }
                    }
                    else if (data[1] == "Truck")
                    {
                        if (data[0] == "Drive")
                        {
                            Console.WriteLine(truck.Drive(double.Parse(data[2])));
                        }
                        else
                        {
                            truck.Refuel(double.Parse(data[2]));
                        }
                    }
                    else if (data[1] == "Bus")
                    {
                        if (data[0] == "Drive")
                        {
                            Console.WriteLine(bus.Drive(double.Parse(data[2])));
                        }
                        else if (data[0] == "DriveEmpty")
                        {
                            Console.WriteLine(bus.DriveEmpty(double.Parse(data[2])), "Bus", double.Parse(data[2]));
                        }
                        else
                        {
                            bus.Refuel(double.Parse(data[2]));
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }

        private static string[] Parser()
        {
            return Console.ReadLine().Split();
        }
    }
}
