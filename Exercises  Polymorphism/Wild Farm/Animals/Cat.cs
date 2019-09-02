using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Foods;

namespace Wild_Farm.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string region, string breeed) 
            : base(name, weight,  region, breeed)
        {
        }

        protected override double WeightMultiplier => 0.30;

        protected override List<Type> PrefferedFoodTypes => new List<Type> { typeof(Meat), typeof(Vegetable) };

        public override string AskFood()
        {
            return "Meow";
        }
    }
}
