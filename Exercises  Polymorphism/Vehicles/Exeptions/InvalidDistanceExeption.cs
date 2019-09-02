using System;

namespace Vehicles.Exeptions
{
    class InvalidDistanceExeption : Exception
    {
        private const  string EXEPTION_MESSAGE = "{0} needs refueling";

        public InvalidDistanceExeption()
            :base(EXEPTION_MESSAGE)
        {
        }

        public InvalidDistanceExeption(string message) : base(message)
        {
        }
    }
}
