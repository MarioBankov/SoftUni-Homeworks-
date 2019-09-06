using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var itemQuantity = new Dictionary<string, int>();
            var itemPrice = new Dictionary<string, double>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="buy")
                {
                    break;
                }
                string[] tokens = input.Split();
                string item = tokens[0];
                double price = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                if (!itemQuantity.ContainsKey(item))
                {
                    itemQuantity.Add(item, quantity);
                    itemPrice.Add(item, price);
                    
                }
                else
                {
                    itemQuantity[item] += quantity;
                    itemPrice[item] = price;
                }




            }
            foreach (var item in itemQuantity)
            {
                string product = item.Key;
                int quantity = item.Value;
                double price = itemPrice[product];
                Console.WriteLine("{0}->{1:f2}",product,price*quantity);
            }
        }
    }
}
