using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Common
{
    public static class Validator
    {
        public static void ThrowsIfStringIsNull(string str, string message)
        {
            if (String.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentNullException(message);
            }
        }
        public static void ThrowsIfObjectIsNull(object obj, string message)
        {
            if (obj == null)
            {
                throw new NullReferenceException(message);
            }
        }


    }
}