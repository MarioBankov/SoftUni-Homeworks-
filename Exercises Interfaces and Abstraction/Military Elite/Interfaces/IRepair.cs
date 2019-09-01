using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit
{
    public interface IRepair
    {
        string PartName { get; }
        int HoursWorked { get; }
    }
}
