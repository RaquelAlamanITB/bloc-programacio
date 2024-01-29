using System;

namespace oop
{
    public class Person
    {
        private string name;
        private string surname;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Surname {
            get { return surname; }
            set { surname = value; }
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public virtual string GetFullName()
        {
            return Surname + ", " + Name;
        }
    }
}
