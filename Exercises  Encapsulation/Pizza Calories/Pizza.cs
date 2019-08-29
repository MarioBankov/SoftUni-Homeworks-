using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories
{
    public class Pizza
    {
        private  string name;
        private Dought dought;
        private List<Topping> topings;
        public Pizza(string name, Dought dought)
        {
            this.Name = name;
            topings = new List<Topping>();
            this.dought = dought;

        }
        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }
        public void AddToping(Topping t)
        {
            if (topings.Count < 10)
            {
                topings.Add(t);
            }
            else
            {
                throw new InvalidOperationException("Number of toppings should be in range[0..10].");
            }
        }
        public int NumberOfTopings { get => topings.Count; }
        public double TotalCalories
        {
            get => CalculateTotalCalories();
        }

        private double CalculateTotalCalories()
        {
            double total = 0;
            foreach (var item in topings)
            {
                total += item.Calories;
            }
            total += this.dought.CaloriesPerGram;
            return total;

        }
        public override string ToString()
        {
            return $"{this.name} - {this.TotalCalories:f2} Calories.";
        }
    }
}
