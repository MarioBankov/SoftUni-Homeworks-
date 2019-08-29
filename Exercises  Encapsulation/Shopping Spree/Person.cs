using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Spree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;
        public Person(string name,decimal money)
        {
            this.Name = name;
            this.Money = money;
        }
        public string Name
        {
            get => name;
            set
            {
                if (value.Length == 0 || value[0] == ' ')
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public decimal Money
        {
            get => money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }
        public void Buy(Product p )
        {
            if (this.Money-p.Price>=0)
            {
                this.money -= p.Price;
                products.Add(p);
            }
        }
    }
}
