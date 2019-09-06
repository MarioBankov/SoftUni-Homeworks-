using System;

namespace Christmas_Spirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int ornament = 2;
            int tree = 5;
            int garlands = 3;
            int lights = 15;
            int price = 0;
            int spirit = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity += 2;
                }
                if (i%2==0)
                {
                    price += ornament*quantity;
                    spirit += 5;
                }
                if (i%3==0)
                {
                    price += tree * quantity;
                    price += garlands * quantity;
                    spirit += 13;
                }
                if (i % 5 == 0)
                {
                    price += lights * quantity;
                    spirit += 17;
                    if (i % 5 == 0 && i % 3 == 0)
                    {
                        spirit += 30;
                    }
                }
                if (i%10==0)
                {
                    spirit -= 20;
                    price += tree;
                    price += garlands;
                    price += lights;

                }
               
                if (days % 10 == 0 && i == days) 
                {
                    spirit -= 30;
                }

            }
            Console.WriteLine("Total cost: {0}",price);
            Console.WriteLine("Total spirit: {0}",spirit);
        }
    }
}
