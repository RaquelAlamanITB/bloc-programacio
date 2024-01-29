using System;

namespace oop
{
    public abstract class AbstractPerson
    {
        protected string name;
        protected string surname;

        public abstract string Name { get; set;  }
        public abstract string Surname { get; set; }
        public abstract string GetFullName();
    }
}
