using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Exeptions;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        public double FuelQuantity
        {
            get => fuelQuantity;
            protected set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                this.fuelQuantity = value;
            }
        }
        public double FuelConsumption { get; protected set; }
        public double TankCapacity { get; protected set; }

        public Vehicle(double fuel, double consumption, double capacity)
        {
            this.TankCapacity = capacity;
            this.FuelQuantity = fuel;
            this.FuelConsumption = consumption;
        }

        public virtual string Drive(double distance)
        {

            string result = string.Empty;

            bool canTravelTheDistance = this.FuelQuantity >= this.FuelConsumption * distance;

            if (canTravelTheDistance)
            {
                this.FuelQuantity -= this.FuelConsumption * distance;

                result = $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                throw new InvalidDistanceExeption($"{this.GetType().Name} needs refueling");
            }

            return result;
        }

        public virtual void Refuel(double quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (this.fuelQuantity + quantity > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {quantity} fuel in the tank");
            }
            this.fuelQuantity += quantity;
        }

    }
}
