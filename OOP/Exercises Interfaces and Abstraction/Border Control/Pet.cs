using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    class Pet : IBirthday
    {
        public string Name { get; private set; }
        public string Birthday { get; private set; }
        public Pet(string name , string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }
    }
}
