using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Animals
{
    public abstract class Bird : Animal
    {
      public  double WingSize { get; protected set; }

        protected Bird(string name, double weight, double wingSize) 
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }
        public override string ToString()
        {
            return base.ToString() + $"{WingSize}, {this.Weight}, {this.FoodEaten}]";
        }

    }
}
