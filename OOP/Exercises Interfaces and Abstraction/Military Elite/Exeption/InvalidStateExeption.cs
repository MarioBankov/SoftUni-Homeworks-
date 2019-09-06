using System;

namespace MilitaryElit
{
    public class InvalidStateExeption : Exception
    {
        private const string EXEPTION_MESSAGE = "Invalid State";
        public InvalidStateExeption()
            :base(EXEPTION_MESSAGE)
        {
        }

        public InvalidStateExeption(string message) : base(message)
        {
        }
    }
}
