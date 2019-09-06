using System;

namespace Pizza_Calories
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] pizzaName = Console.ReadLine().Split();
            string name = pizzaName[1];
            string[] dought = Console.ReadLine().Split();
            Dought d = null;
            try
            {

                 d = new Dought(dought[1], dought[2], double.Parse(dought[3]));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }
            Pizza p = null;
            try
            {
                 p = new Pizza(name, d);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            
            while (true)
            {
                string[] data = Console.ReadLine().Split();
                if (data[0]=="END")
                {
                    break;
                }
                Topping t = null;
                try
                {
                    t = new Topping(data[1], double.Parse(data[2]));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
                try
                {
                    p.AddToping(t);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
               
            }
            Console.WriteLine(p);
            
        }
    }
}
