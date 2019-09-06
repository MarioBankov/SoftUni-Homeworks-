using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Foods.Factory
{
    public class FoodFactory
    {
        public Food ProduceFood(string type ,int quantity)
        {
            Food food = null;
            if (type =="Vegetable")
            {
                food = new Vegetable(quantity);
            }
            else if (type =="Fruid")
            {
                food = new Fruit(quantity);
            }
            else if (type=="Meat")
            {
                food = new Meat(quantity);
            }
            else if (type =="Seeds")
            {
                food = new Seeds(quantity);
            }
            else
            {
                throw new AccessViolationException("InvalidFoodType");
            }
            return food;
        }
    }
}
