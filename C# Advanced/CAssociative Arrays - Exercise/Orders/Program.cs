using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            while ( true)
            {
                string[] data = Console.ReadLine().Split();
                if (data[0]=="buy")
                {
                    break;
                }
                string name = data[0];
                double price = double.Parse(data[1]);
                int  quantity = int.Parse(data[2]);
                Product a = new Product(name, price, quantity);
                if (list.Any(x=>x.Name==name)==false)
                {
                    list.Add(a);
                }
                else
                {
                    int index = list.FindIndex(x => x.Name == name);
                    if (list[index].Price!=price)
                    {
                        list[index].Price = price;
                    }
                        list[index].Quantity += quantity;
                    
                    
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
    class Product
    {
        public Product(string name , double price,int quantity)
        {
            Name = name;
            Quantity = quantity;
            Price = price;

        }
        public string Name  { get; set; }
        public double Price { get; set; }
        public  int Quantity { get; set; }

        public override string ToString()
        {
            return $"{this.Name} -> {Price * Quantity:f2}";
        }
    }
}
