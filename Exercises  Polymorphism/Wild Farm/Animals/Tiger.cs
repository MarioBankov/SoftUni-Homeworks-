using System;
using System.Collections.Generic;
using Wild_Farm.Foods;

namespace Wild_Farm.Animals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string region, string breeed)
            : base(name, weight, region, breeed)
        {
        }

        protected override double WeightMultiplier => 1.00;

        protected override List<Type> PrefferedFoodTypes => new List<Type> { typeof(Meat) };
        public override string AskFood()
        {
            return "ROAR!!!";
        }
    }
}
