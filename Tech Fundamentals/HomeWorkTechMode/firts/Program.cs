using System;

namespace firts
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (type=="Students")
            {
                if (day=="Friday")
                {
                    price = 8.45;
                }
                else if (day=="Saturday")
                {
                    price = 9.80;

                }
                else if (day=="Sunday")
                {
                    price = 10.46;
                }
                if (number>=30)
                {
                    price = price - (price * 0.15);
                }
            }
            else if (type=="Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;

                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
                if (number>=100)
                {
                    number -= 10;
                }
            }
            else if (type=="Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;

                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
                if (number>=10&&number<=20)
                {
                    price = price - (price * 0.05);
                }
            }
            Console.WriteLine("Total price: {0:f2}",price*number);
        }

    }
}
