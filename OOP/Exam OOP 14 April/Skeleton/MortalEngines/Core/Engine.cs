using MortalEngines.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Core
{
    public class Engine : IEngine
    {
        private MachinesManager mg;

        public Engine(MachinesManager mg)
        {
            this.mg = mg;
        }
        public void Run()
        {
           
            
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Quit")
                {
                    break;
                }
                string[] commands = command.Split();

                try
                {
                    string result = CommandInterpretator(commands);
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
               
            }
        }

        private string CommandInterpretator(string[] commands)
        {
            string result = string.Empty;
            if (commands[0] == "HirePilot")
            {
                result= mg.HirePilot(commands[1]);
            }
            else if (commands[0] == "PilotReport")
            {
                result = mg.PilotReport(commands[1]);
            }
            else if (commands[0] == "ManufactureTank")
            {
                string name = commands[1];
                double attc = double.Parse(commands[2]);
                double deff = double.Parse(commands[3]);
                result = mg.ManufactureTank(name, attc, deff);
            }
            else if (commands[0] == "ManufactureFighter")
            {
                string name = commands[1];
                double attc = double.Parse(commands[2]);
                double deff = double.Parse(commands[3]);
                result = mg.ManufactureFighter(name, attc, deff);
            }
            else if (commands[0] == "MachineReport")
            {
                result =  mg.MachineReport(commands[1]);
            }
            else if (commands[0] == "AggressiveMode")
            {
                result = mg.ToggleFighterAggressiveMode(commands[1]);
            }
            else if (commands[1] == "DefenseMode")
            {
                result = mg.ToggleTankDefenseMode(commands[1]);
            }
            else if (commands[0] == "Engage")
            {
                string pilotName = commands[1];
                string machineName = commands[2];
                result = mg.EngageMachine(pilotName, machineName);
            }
            else if (commands[0] == "Attack")
            {
                result = mg.AttackMachines(commands[1], commands[2]);
            }
            return result;
        }

        private void CommandInterpreter() { }
    }
}
