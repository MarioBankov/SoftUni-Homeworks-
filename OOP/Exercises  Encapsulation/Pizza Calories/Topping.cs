using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories
{
    public class Topping
    {
        private string topingType;
        private double weight;
        public Topping(string topintType,double weight)
        {
            this.TopingType = topintType;
            this.Weight = weight;
        }
        public string TopingType
        {
            get => topingType;
            set
            {
                if (value.ToLower()=="meat"|| value.ToLower() == "veggies"|| value.ToLower() == "cheese"|| value.ToLower() == "sause")
                {
                    topingType = value.ToLower();
                }
                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }
        public double Weight
        {
            get => weight;
            set
            {
                if (value<1||value>50)
                {
                    throw new ArgumentException($"{topingType} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }
        public double Calories
        {
            get => CalculateCalories();
        }

        private double CalculateCalories()
        {
            double multyplyer = 0;
            if (topingType=="meat")
            {
                multyplyer = 1.2;
            }
            else if (topingType=="veggies")
            {
                multyplyer = 0.8;
            }
            else if (topingType=="cheese")
            {
                multyplyer = 1.1;
            }
            else if (topingType=="sause")
            {
                multyplyer=0.9;
            }
            return weight * 2 * multyplyer;
        }
    }
}
