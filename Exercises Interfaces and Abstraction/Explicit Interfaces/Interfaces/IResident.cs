﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Explicit_Interfaces.Interfaces
{
    public interface IResident
    {
        string Name { get; }
        string Country { get; }

        string GetName();
    }
}
