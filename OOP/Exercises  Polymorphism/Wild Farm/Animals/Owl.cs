using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Foods;

namespace Wild_Farm.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight,double wingSize) 
            : base(name, weight,  wingSize)
        {

        }

        protected override double WeightMultiplier => 0.25;
        
        protected override List<Type> PrefferedFoodTypes => new List<Type> { typeof(Meat) };

        public override string AskFood()
        {
            return "Hoot Hoot";
        }
    }
}
