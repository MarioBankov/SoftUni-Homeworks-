using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping_Spree
{
    public class Engine
    {
        private List<Product> products;
        private List<Person> persons;
        public void Run()
        {
            this.persons = new List<Person>();
            this.products = new List<Product>();


            ReadInputPerson();
            ReadInpitProducts();
            while (true)
            {
                string[] data = Console.ReadLine().Split();
                if (data[0]=="END")
                {
                    break;
                }
                string name = data[0];
                string product = data[1];
                Person buyer = persons.Where(p => p.Name == name).FirstOrDefault();
                Product toBuy = products.Where(p => p.Name == product).FirstOrDefault();
                buyer.Buy(toBuy);
            }

           
        }

        private void ReadInpitProducts()
        {
            string[] productsTonen = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < productsTonen.Length; i++)
            {
                Product p = new Product(productsTonen[i], decimal.Parse(productsTonen[i + 1]));
                products.Add(p);
            }
        }

        private  void ReadInputPerson()
        {
            string[] people = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < people.Length; i++)
            {
                Person p = new Person(people[i], decimal.Parse(people[i + 1]));
                persons.Add(p);
            }
        }

    }

}
