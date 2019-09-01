using Military_Elite.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit
{
    public interface ISpecialisedSoldier:IPrivate
    {
        Corps Corps { get; }
    }
}
