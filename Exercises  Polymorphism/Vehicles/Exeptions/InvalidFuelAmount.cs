using System;

namespace Vehicles.Exeptions
{
    class InvalidFuelAmount : Exception
    {
        private const string EXEPTION_MESSAGE = "Cannot fit {0} fuel in the tank";
        public InvalidFuelAmount()
            :base(EXEPTION_MESSAGE)
        {
        }

        public InvalidFuelAmount(string message)
            : base(message)
        {
        }
    }
}
