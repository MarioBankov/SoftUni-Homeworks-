using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new HashSet<string>();
            while (true)
            {
                string data = Console.ReadLine();
                if (data.ToLower() =="end")
                {
                    break;
                }
                string[] entry = data.Split(", ");
                if (entry.First()=="IN")
                {
                    cars.Add(entry.Last());
                }
                else
                {
                    cars.Remove(entry.Last());
                }
            }
            if (cars.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in cars)
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }
}
