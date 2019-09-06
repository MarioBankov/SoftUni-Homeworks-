using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElit
{
    public class Engine
    {
        private List<ISoldier> army;
        public Engine()
        {
            this.army = new List<ISoldier>();
        }
        public void Run()
        {
            while (true)
            {
                string[] data = Console.ReadLine().Split();
                if (data[0].ToLower() == "end")
                {
                    break;
                }
                string type = data[0];
                string id = data[1];
                string firstName = data[2];
                string lastName = data[3];
                decimal salary = decimal.Parse(data[4]);
                if (type == "Private")
                {
                    ISoldier soldiar = new Private(id, firstName, lastName, salary);

                    this.army.Add(soldiar);
                }
                else if (type== "LieutenantGeneral")
                {
                    LieutenantGeneral lieutenant = new LieutenantGeneral(id, firstName, lastName, salary);
                    string[] idPrivates = data.Skip(5).ToArray();
                    foreach (var item in idPrivates)
                    {
                        ISoldier @private = this.army.FirstOrDefault(x => x.Id == item);
                        lieutenant.AddPrivate(@private);
                    }
                    this.army.Add(lieutenant);
                }
                else if (type=="Engineer")
                {

                    string corps = data[5];
                    try
                    {
                        IEngineer e = new Engineer(id, firstName, lastName, salary, corps);
                        string[] repair = data.Skip(6).ToArray();
                        AddRepairs(e, repair);

                        this.army.Add(e);
                    }
                    catch (Exception ex)
                    {
                        
                    }
                    
                }
                else if (type=="Commando")
                {
                    string corps = data[5];
                    try
                    {
                        ICommando c = new Commando(id, firstName, lastName, salary, corps);
                        string[] missionsArgs = data.Skip(6).ToArray();
                        for (int i = 0; i < missionsArgs.Length; i+=2)
                        {
                            try
                            {
                                string codeNamme = missionsArgs[i];
                                string state = missionsArgs[i + 1];
                                IMission m = new Mission(codeNamme, state);
                                c.AddMissions(m);
                            }
                            catch (InvalidStateExeption ise)
                            {

                                continue;
                            }
                            
                        }
                        this.army.Add(c);
                    }
                    catch (InvalidCorpsExeption)
                    {

                    }
                    
                  
                }
                else if (type=="Spy")
                {
                    int codeNumber = (int)salary;
                    ISpy spy = new Spy(id, firstName, lastName, codeNumber);
                    this.army.Add(spy);
                }
            }
            PrintOutPut();
        }

        private void PrintOutPut()
        {
            foreach (var item in army)
            {
                Type type = item.GetType();
                Object actual = Convert.ChangeType(item, type);
                Console.WriteLine(actual.ToString());
            }
        }

        private static void AddRepairs(IEngineer e, string[] repair)
        {
            for (int i = 0; i < repair.Length; i += 2)
            {
                string partName = repair[i];
                int houres = int.Parse(repair[i + 1]);
                IRepair r = new Repair(partName, houres);
                e.AddRepair(r);
            }
        }
    }
}
