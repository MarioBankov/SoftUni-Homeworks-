using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit
{
    public interface IPrivate:ISoldier
    {
        decimal Salary { get; }
    }
}
