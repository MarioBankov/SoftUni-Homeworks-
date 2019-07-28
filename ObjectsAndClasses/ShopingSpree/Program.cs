using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            for (int i = 0; i < input.Count; i++)
            {
                string name = input[i].Split('=').First();
                double money = double.Parse(input[i].Split('=').Last());
                Person person = new Person(name, money);
                people.Add(person);
            }
            List<string> line2 = Console.ReadLine().Split(new char[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < line2.Count; i++)
            {
                string name = line2[i].Split('=')[0];
                double price = double.Parse(line2[i].Split('=')[1]);
                Product product = new Product(name, price);
                products.Add(product);
            }
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "END")
                {
                    break;
                }
                string[] nameProduct = data.Split();
                string name = nameProduct[0];
                string product = nameProduct[1];

                if (people.Any(x => x.Name == name) && products.Any(x => x.Name == product))
                {
                    int productIndex = products.FindIndex(x => x.Name == product);
                    
                    var a = products[productIndex];
                    int peopleIndex = people.FindIndex(x => x.Name == name);
                    people[peopleIndex].Buy(products[productIndex]);
                }
            }
            foreach (var item in people)
            {
                if (item.Products.Count == 0)
                {
                    Console.WriteLine("{0} - Nothing bought", item.Name);
                }
                else
                {
                    Console.WriteLine("{0} - {1}", item.Name,item.PrintList());
                }
            }
           
        }
    }
    class Person
    {
        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<Product>();
        }
        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> Products { get; set; }

        public void Buy(Product product)
        {
            if (product.Price <= this.Money)
            {
                this.Money -= product.Price;
                this.Products.Add(product);
                Console.WriteLine("{0} bought {1}",this.Name,product.Name);
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }
        public  string PrintList()
        {
            string result = string.Empty;
            for (int i = 0; i < Products.Count; i++)
            {
                if (i==Products.Count-1)
                {
                    result += Products[i].Name;
                    break;
                }
                 result +=Products[i].Name+", ";
            }
            return result;
        }
    }
    class Product
    {
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }

    }
}
