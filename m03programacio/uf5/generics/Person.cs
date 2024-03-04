using System;

namespace generics
{
    public enum Gender
    {
        Male, Female, NotSpecified
    }
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public Person(string name, string lastName, Gender gen)
        {
            Name = name;
            LastName = lastName;
            Gender = gen;
        }

    }
}
