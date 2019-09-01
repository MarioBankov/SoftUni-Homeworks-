using System;
using System.Collections.Generic;
using System.Text;
using Military_Elite.Enumerations;

namespace MilitaryElit
{
    public class Mission : IMission
    {
        public string CodeName { get; private set; }

        public State State { get; private set; }

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;

        }
        public void CompleteMission()
        {
            if (this.State==State.Finished)
            {
                throw new InvalidMissionComplitionExeption();
            }

            this.State = State.Finished;
        }
        public void StateParse(string state)
        {
            bool canParse = Enum.TryParse<State>(state, out State result);

            if (!canParse)
            {
                throw new InvalidStateExeption();
            }
            this.State = result;
        }
        public override string ToString()
        {
            return $"Code Name: <{CodeName}> State: <{State}>";
        }
    }
}
