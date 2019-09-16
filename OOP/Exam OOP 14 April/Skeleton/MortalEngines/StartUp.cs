using MortalEngines.Core;
using MortalEngines.Entities.Contracts;
using System.Collections.Generic;

namespace MortalEngines
{
    public class StartUp
    {
        public static void Main()
        {
            List<IPilot> pilots = new List<IPilot>();
            IList<IMachine> machines = new List<IMachine>();
            MachinesManager mg = new MachinesManager(pilots,machines);
            Engine engine = new Engine(mg);
            engine.Run();
        }
    }
}