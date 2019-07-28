using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                string day = Console.ReadLine();

                if (char.IsDigit(day[0]) && day.Length>0)
                {
                    int day1 = int.Parse(day);


                    switch (day1)
                    {
                        case 1:
                            Console.WriteLine("Monday");
                            break;
                        case 2:
                            Console.WriteLine("Tuesday");
                            break;
                        case 3:
                            Console.WriteLine("Wednesday");
                            break;
                        case 4:
                            Console.WriteLine("Thursday");
                            break;
                        case 5:
                            Console.WriteLine("Friday");
                            break;
                        case 6:
                            Console.WriteLine("Saturday");
                            break;
                        case 7:
                            Console.WriteLine("Sunday");
                            break;
                        default:
                            Console.WriteLine("Invalid day!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please tipe a number between one and seven!");
                }

            }

        }
    }
}
