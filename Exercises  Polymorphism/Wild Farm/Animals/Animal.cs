using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Foods;
using Wild_Farm;
using Wild_Farm.Exeptions;

namespace Wild_Farm.Animals
{
    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; protected set; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }
        protected abstract double WeightMultiplier { get; }

        protected abstract List<Type> PrefferedFoodTypes { get; }
        public abstract string AskFood();


        public virtual void Feed(Food food)
        {
            if (!this.PrefferedFoodTypes.Contains(food.GetType()))
            {
                throw new InvalidOperationException
                    (string.Format(ExeptionMessages.InvalidFoodExeption, GetType().Name, food.GetType().Name));
            }
            this.Weight += food.Quantity * this.WeightMultiplier;
            this.FoodEaten += food.Quantity;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
