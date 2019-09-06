using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories
{
    public class Dought
    {
        private double weight;
        private string flourtType;
        private string bakingTechnique;

        public Dought(string flourtType, string bakingTechnique, double weight)
        {
            this.Weight = weight;
            this.FlourType = flourtType;
            this.BakingTechnique = bakingTechnique;
        }
        public double Weight
        {
            get => weight;
            set
            {
                CheckValueWeight(value);
            }
        }
        public string FlourType
        {
            get => flourtType;
            set
            {
                CheckValueFlour(value);
            }
        }
        public string BakingTechnique
        {
            get => bakingTechnique;
            set
            {
                CheckValueBakeingTechnique(value);
            }
        }
        public double CaloriesPerGram
        {
            get => CalculateCaloriesPerGram();

        }

        private double CalculateCaloriesPerGram()
        {
            double dougeCalories = weight * 2;
            double flourMultyply;
            double bakeMultyply;
            if (flourtType == "white")
            {
                flourMultyply = 1.5;
            }
            else
            {
                flourMultyply = 1.0;
            }
            if (bakingTechnique == "crispy")
            {
                bakeMultyply = 0.9;
            }
            else if (bakingTechnique == "chewy")
            {
                bakeMultyply = 1.1;
            }
            else
            {
                bakeMultyply = 1.0;
            }
            var total = dougeCalories * flourMultyply * bakeMultyply;

            return total;
        }
        private void CheckValueWeight(double value)
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            weight = value;
        }
        private void CheckValueFlour(string value)
        {
            if (value.ToLower() == "white" || value.ToLower() == "wholegrain")
            {
                flourtType = value.ToLower();
            }
            else
            {
                throw new ArgumentException("Invalid type of dough.");
            }
        }
        private void CheckValueBakeingTechnique(string value)
        {
            if (value.ToLower() == "crispy" || value.ToLower() == "chewy" || value.ToLower() == "homemade")
            {
                bakingTechnique = value.ToLower();
            }
            else
            {
                throw new ArgumentException("Invalid type of dough.");
            }
        }



    }

}
