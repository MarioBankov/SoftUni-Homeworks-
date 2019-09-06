using System;
using System.Collections.Generic;
using System.Linq;

namespace CrossRoads
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            Stack<string> stack = new Stack<string>();
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            bool allCarsPassSafe = true;
            int counter = 0;
            while (true)
            {
               
                string data = Console.ReadLine();
                if (data == "END")
                {
                    break;
                }
                if (data == "green")
                {
                    int greenL = greenLightDuration;
                   
                    while (greenL > 0 && queue.Count != 0)
                    {
                        string car = queue.Dequeue();
                        int carlengh = car.Length;
                        if (greenL - carlengh >= 0)
                        {
                            counter++;
                            greenL -= car.Length;
                        }
                        
                        else
                        {
                            
                            carlengh = carlengh - greenL; //mmer
                            
                            if (freeWindow>=carlengh)
                            {
                                counter++;
                               break;
                            }
                            int index =  greenL+freeWindow;
                            allCarsPassSafe = false;
                            Console.WriteLine("A crash happened!");  //Hammer
                            Console.WriteLine("{0} was hit at {1}.", car, car[index]);
                            break;
                        }

                    }
                    if (allCarsPassSafe == false)
                    {
                        break;
                    }
                }
                else
                {
                    queue.Enqueue(data);
                }
            }
            if (allCarsPassSafe)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine("{0} total cars passed the crossroads.", counter);
            }
        }
    }
}


