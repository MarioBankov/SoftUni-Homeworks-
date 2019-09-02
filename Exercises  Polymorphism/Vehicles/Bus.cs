using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Exeptions;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double airConditionarConsumption = 1.4;
        public Bus(double fuel, double consumption, double capacity) 
            : base(fuel, consumption+airConditionarConsumption, capacity)
        {
            
        }
        
        public string DriveEmpty(double distance)
        {
            this.FuelConsumption = this.FuelConsumption - 1.4;
           return  this.Drive(distance);
            
            
        }
        
    }
}
