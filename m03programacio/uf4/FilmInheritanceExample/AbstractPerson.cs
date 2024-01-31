using System;

namespace oop
{
    public abstract class AbstractPerson
    {
        public abstract string Name { get; set;  }
        public abstract string Surname { get; set; }
        public abstract string GetFullName();
    }
}
