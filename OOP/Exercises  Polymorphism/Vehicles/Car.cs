using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Exeptions;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double AirConditionarConstumption = 0.9;
        public Car(double fuel, double consumption, double capacity) 
            : base(fuel, consumption+AirConditionarConstumption, capacity)
        {
            
        }
        
    }
}
