using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Spree
{
    public class Product
    {
        private decimal price;
        private string name;
        public Product(string name,decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name
        {
            get => name;
            set
            {
                if (value.Length==0||value[0]==' ')
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;  
            }
        }
        public  decimal Price
        {
            get => price;
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                price = value;
            }
        }
    }
}
