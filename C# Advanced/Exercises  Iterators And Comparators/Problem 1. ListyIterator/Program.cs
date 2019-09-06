using System;
using System.Linq;

namespace IteratorsAndComparatorsExercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListyIterator<string> collection = null;
            while (true)
            {
                try
                {
                    string[] command = Console.ReadLine().Split();
                    if (command[0] == "END")
                    {
                        break;
                    }
                    if (command[0] == "Create")
                    {
                        collection = new ListyIterator<string>(command.Skip(1).ToArray());
                    }
                    else if (command[0] == "HasNext")
                    {
                        Console.WriteLine(collection.HasNext());
                    }
                    else if (command[0] == "Move")
                    {
                        Console.WriteLine(collection.Move());
                    }
                    else if (command[0] == "Print")
                    {
                        collection.Print();
                    }
                    else if (command[0]=="PrintAll")
                    {
                        foreach (var item in collection)
                        {
                            Console.Write(item+" ");
                        }
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    
                }
                
            }
        }
    }
}
