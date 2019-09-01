using System;
using System.Collections.Generic;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<IBirthday> numbers = new List<IBirthday>();
            while (true)
            {
                string[] data = Console.ReadLine().Split();
                if (data[0].ToLower()=="end")
                {
                    break;
                }
                if (data[0]=="Robot")
                {
                    Robot r = new Robot(data[1], data[2]);
                    
                }
                else if (data[0]=="Pet")
                {
                    Pet p = new Pet(data[1], data[2]);
                    numbers.Add(p);
                }
                else if(data[0]=="Citizen")
                {
                    Citizens c = new Citizens(data[1], int.Parse(data[2]), data[3],data[4]);
                    numbers.Add(c);
                }

            }
            string check = Console.ReadLine();
            foreach (var item in numbers)
            {
                if (item.Birthday.EndsWith(check))
                {
                    Console.WriteLine(item.Birthday);
                }
            }
        }
    }
}
