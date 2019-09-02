using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Foods;

namespace Wild_Farm.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight,  string region) 
            : base(name, weight,region)
        {
        }

        protected override double WeightMultiplier => 0.10;

        protected override List<Type> PrefferedFoodTypes => new List<Type> { typeof(Vegetable), typeof(Fruit) };

        public override string AskFood()
        {
            return "Squeak";
        }
        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
