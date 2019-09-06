using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Foods;

namespace Wild_Farm.Animals
{
  public class Dog : Mammal
    {
        public Dog(string name, double weight,  string region)
            : base(name, weight, region)
        {
        }

        protected override double WeightMultiplier => 0.40;

        protected override List<Type> PrefferedFoodTypes => new List<Type> { typeof(Meat) };

        public override string AskFood()
        {
            return "Woof";
        }
        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
