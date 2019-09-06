using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Phone : ICalling, IBrowsing
    {
        public string Model { get; private set; }
        public Phone(string model )
        {
            this.Model = model;
        }
        public string Browsing(string site )
        {

            if (site.Where(x=>char.IsDigit(x)).Count()==0)
            {
                return $"Browsing: {site}!";
            }
            else
            {
                return "Invalid URL!";
            }
            
        }

        public string Call(string number)
        {
            if (number.Where(x=>char.IsDigit(x)).Count()==number.Length)
            {
                return $"Calling... {number}";
            }
            else
            {
                return "Invalid number!";
            }
        }
    }
}
