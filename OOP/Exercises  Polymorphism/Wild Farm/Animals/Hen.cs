using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Foods;

namespace Wild_Farm.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {

        }

        protected override double WeightMultiplier => 0.35;

        protected override List<Type> PrefferedFoodTypes => new List<Type>
        { typeof(Vegetable), typeof(Fruit), typeof(Meat), typeof(Seeds) };

        public override string AskFood()
        {
            return "Cluck";
        }
    }
}
