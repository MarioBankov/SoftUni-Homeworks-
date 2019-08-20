using System;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Cstack<string> Cstack = null;
            while (true)
            {
                try
                {
                    string[] command = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    if (command[0]=="END")
                    {
                        break;
                    }
                    if (command[0] == "Push")
                    {
                        Cstack = new Cstack<string>(command.Skip(1).ToList());
                    }
                    else if (command[0] == "Pop")
                    {
                        Cstack.Pop();
                    }
                }
                catch (Exception ex )
                {

                    Console.WriteLine(ex.Message);
                }
                
            }
            for (int i = 0; i < 2; i++)
            {
                foreach (var item in Cstack)
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }
}
