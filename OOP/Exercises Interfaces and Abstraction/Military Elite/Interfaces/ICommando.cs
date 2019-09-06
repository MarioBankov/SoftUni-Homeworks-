using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit
{
    public interface ICommando:ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }
        void AddMissions(IMission mission);
    }
}
