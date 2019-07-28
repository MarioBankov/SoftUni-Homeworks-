using System;
using System.Collections.Generic;
using System.Linq;

namespace Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> street = Console.ReadLine().Split('@').Select(int.Parse).ToList();
            int lastPosition = 0;
            while (true)
            {

                string data = Console.ReadLine();
                if (data== "Merry Xmas!")
                {
                    break;
                }
                int index = int.Parse(data.Split()[1]);
                index = lastPosition + index;
               
                while (index>street.Count-1)
                {
                    index -= street.Count ;
                }
                if (street[index] <= 0)
                {
                    Console.WriteLine("House {0} will have a Merry Christmas.", index);

                }
                street[index] -= 2;
                
                lastPosition = index;
            }

            // for (int i = 0; i < street.Count; i++)
            // {
            //     if (street[i]<=0)
            //     {
            //         street.RemoveAt(i);
            //         i = -1;
            //     }
            //     
            // }
           street= street.Where(x => x != 0).ToList(); 
          
            Console.WriteLine("Santa's last position was {0}.",lastPosition);
            if (street.Count==0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine("Santa has failed {0} houses.",street.Count);
            }
        }
    }
}
