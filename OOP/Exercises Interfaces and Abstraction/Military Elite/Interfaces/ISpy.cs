using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit
{
   public  interface ISpy:ISoldier
    {
        int CodeNumber { get; }
    }
}
