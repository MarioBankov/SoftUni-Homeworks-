using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Exeptions;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double airConditionarConsumption = 1.4;
        public Truck(double fuel, double consumption, double capacity) 
            : base(fuel, consumption+airConditionarConsumption, capacity)
        {
            
        }

        public override void Refuel(double quantity)
        {
            base.Refuel(quantity);
            this.FuelQuantity *=-0.05;
        }
    }

}
