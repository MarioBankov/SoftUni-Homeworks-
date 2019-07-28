using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBoxes
{
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    public class Box
    {
        
        //Serial Number, Item, Item Quantity and Price for a Box.
       public string SerialNumber { get; set; }
       public  Item item { get; set; }
       public int itemQuantity { get; set; }
       public double Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            List<Item> items = new List<Item>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="end")
                {
                    break;
                }
                string[] data = input.Split();
                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                double itemPrice = double.Parse(data[3]);
                var item = new Item
                {
                    Name = itemName,
                    Price = itemPrice

                };
                var box = new Box
                {
                    SerialNumber = serialNumber,
                    itemQuantity = itemQuantity,
                    Price = itemPrice * itemQuantity,
                    item = item,
                    
                };
                
                boxes.Add(box);
                items.Add(item);
            }
            foreach (var item in boxes.OrderByDescending(x=>x.Price))
            {
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine($"-- {item.item.Name} – ${item.item.Price:f2}: {item.itemQuantity}");
                Console.WriteLine($"-- ${item.Price:f2}");
            }
        }
    }
}
