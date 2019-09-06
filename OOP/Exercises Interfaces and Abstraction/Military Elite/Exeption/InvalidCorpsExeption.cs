using System;

namespace MilitaryElit
{
    public class InvalidCorpsExeption : Exception
    {
        private const string EXEPTION_MESSAGE = "Invalid Corps!";

        public InvalidCorpsExeption()
            :base(EXEPTION_MESSAGE)
        {

        }

        public InvalidCorpsExeption(string message) 
            : base(message)
        {
        }
    }
}
