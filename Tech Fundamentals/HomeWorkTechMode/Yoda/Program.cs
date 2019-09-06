    using System;

    namespace Yoda
    {
        class Program
        {
            static void Main(string[] args)
            {
                double money = double.Parse(Console.ReadLine());
                int students = int.Parse(Console.ReadLine());
                double sabrePrice = double.Parse(Console.ReadLine());
                double robePrice = double.Parse(Console.ReadLine());
                double beltPrice = double.Parse(Console.ReadLine());


                var sabrecount = (int)Math.Ceiling(students + (students * 0.10));

                int count = 0;
                int math = students;
                while (math - 6 >= 0)
                {
                    math -= 6;
                    count++;
                }
                double total = (sabrePrice * sabrecount) + (robePrice * students) + (beltPrice * (students - count));
                if (money >= total)
                {
                    Console.WriteLine("The money is enough - it would cost {0:f2}lv.", total);
                }
                else
                {

                    Console.WriteLine("Ivan Cho will need {0:f2}lv more.", total - money);
                }







            }
        }
    }
