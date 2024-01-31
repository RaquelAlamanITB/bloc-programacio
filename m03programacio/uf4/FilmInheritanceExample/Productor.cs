using System;

namespace oop
{
    public class Productor : AbstractPerson, IPerson
    {
        //expression bodied property
        public override string? Name { get; set; }
        //expression bodied property
        public override string? Surname { get ; set; }

        public void DisplayName() => Console.WriteLine(Name);
        public override string GetFullName() => "Nom: " + Name;
    }
}
