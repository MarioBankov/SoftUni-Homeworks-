using System;

namespace MilitaryElit
{
    public class InvalidMissionComplitionExeption : Exception
    {
        private const string EXTEPTION_MESSAGE = "State of mission is alredy finished! ";
        public InvalidMissionComplitionExeption()
            :base(EXTEPTION_MESSAGE)
        {
        }

        public InvalidMissionComplitionExeption(string message) : base(message)
        {
        }
    }
}
