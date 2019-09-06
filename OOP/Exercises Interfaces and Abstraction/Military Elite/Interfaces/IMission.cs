using Military_Elite.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit
{
    public interface IMission
    {
        string CodeName { get; }

        State State { get; }

        void CompleteMission();
    }
}
