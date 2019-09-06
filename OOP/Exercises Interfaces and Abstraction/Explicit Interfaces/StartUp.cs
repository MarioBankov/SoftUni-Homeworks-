using Explicit_Interfaces.Interfaces;
using Explicit_Interfaces.Model;
using System;

namespace Explicit_Interfaces
{
    class StartUp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] data = Console.ReadLine().Split();
                if (data[0].ToLower()=="end")
                {
                    break;
                }
                IPerson  person = new Citizen(data[0],data[1],int.Parse(data[2]));
                IResident  resident = new Citizen(data[0],data[1],int.Parse(data[2]));

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());

            }
        }
    }
}
